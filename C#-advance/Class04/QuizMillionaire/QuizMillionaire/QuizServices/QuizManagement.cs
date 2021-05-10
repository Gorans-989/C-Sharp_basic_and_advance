using QuizMillionaire_Domain;
using QuizMillionaire_Domain.Entities;
using QuizMillionaire_Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QuizServices
{
    
    public class QuizManagement
    {
        public static List<Question> Questions = DataBase.Questions;

        public void StartGame()
        {
            for(int i = 0; i < Questions.Count; i++)
            {
                if(i == 14)
                {
                    Console.WriteLine("Last Question. Good Luck");
                }
                Console.WriteLine($"Question number {i + 1}:");
                Questions[i].PrintQuestion();
                Questions[i].PrintAnswers();
                int userChoice = InputParser.CheckInput(1, 4);
                bool isCorrect = ValidateAnswer(Questions[i], userChoice);
                if (i == 14 && isCorrect)
                {
                    Console.WriteLine("CONGRATULATIONS. YOU WON 1 000 000 PESOS");
                    Environment.Exit(0);
                }
                if (!isCorrect)
                {
                    Environment.Exit(0);
                }
            }
        }

        public bool ValidateAnswer(Question currentQuestion, int userChoice)
        {
            bool isCorrect = currentQuestion.CheckAnswer(userChoice);
            if (!isCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Wrong answer");
                Console.ResetColor();
                Console.WriteLine($"The correct answer is : {currentQuestion.CorrectAnswer}");
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct Answer!!!");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            return true;
        }


    }
}
