using QuizMillionaire_Domain;
using QuizMillionaire_Domain.Entities;
using QuizMillionaire_Domain.Helpers;
using QuizMillionaire_Domain.QuizHelpOptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QuizServices
{
    
    public class QuizManagement
    {
        public static List<Question> Questions = DataBase.Questions;
        public static Question _CurrentQuestion;
        

        public void StartGame()
        {
            for(int i = 0; i < Questions.Count; i++)
            {
                _CurrentQuestion = Questions[i];
                List<string> helpOptions = CheckHelpOptions();

                if(i == 14)
                {
                    Console.WriteLine("Last Question. Good Luck");
                }
                Console.WriteLine($"Question number {i + 1}:");
                _CurrentQuestion.PrintQuestion();
                _CurrentQuestion.PrintAnswers();

                if(helpOptions.Count != 0)
                {
                    PrintHelpOptions(helpOptions);
                }

                int userChoice = InputParser.CheckInput(1, (_CurrentQuestion.Answers.Count + helpOptions.Count));

                if(userChoice > 4)
                {
                    userChoice = ChooseHelpOption(userChoice, helpOptions);
                }

                bool isCorrect = ValidateAnswer(_CurrentQuestion, userChoice);
                if (i == 14 && isCorrect)
                {
                    Console.WriteLine("CONGRATULATIONS. YOU WON 1 000 000 PESOS");
                    Environment.Exit(0);
                }
                if (!isCorrect)
                {
                    Thread.Sleep(2000);
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

        public List<string> CheckHelpOptions()
        {
            List<string> helpOptions = new List<string>();
            if (!HelpFiftyFifty.IsUsed)
            {
                helpOptions.Add("Fifty - Fifty");
            }
            if (!HelpFromAudience.IsUsed)
            {
                helpOptions.Add("Ask the Audience");
            }
            if (!HelpFromFriend.IsUsed)
            {
                helpOptions.Add("Call a Friend");
            }
            return helpOptions;
        }
        public void PrintHelpOptions(List<string> helpOptions)
        {
            Console.WriteLine("Available Help");
            for (int i = 0; i< helpOptions.Count; i++)
            {
                Console.WriteLine($"{i + 5}.{helpOptions[i]}");
            }
        }

        public int ChooseHelpOption(int userChoice, List<string> helpOptions)
        {
            int chosenAnswer = 0;
            string chosenHelp = "";
            chosenHelp = helpOptions[userChoice - 5];

            switch (chosenHelp)
            {
                case "Fifty - Fifty":
                    _CurrentQuestion = HelpFiftyFifty.UseHelp(_CurrentQuestion);
                    HelpFiftyFifty.IsUsed = true;
                    Console.WriteLine("The answers after using Fifty Fifty are:");
                    _CurrentQuestion.PrintAnswers();
                    return chosenAnswer = InputParser.CheckInput(1, _CurrentQuestion.Answers.Count);

                case "Ask the Audience":
                    Console.WriteLine("You choose to ask the audience");
                    Question temp = HelpFromAudience.UseHelp(_CurrentQuestion);
                    HelpFromAudience.IsUsed = true;
                    //temp.PrintAnswers();
                    return chosenAnswer = InputParser.CheckInput(1, _CurrentQuestion.Answers.Count);

                case "Call a Friend":
                    Console.WriteLine("You choose to call a friend");
                    HelpFromFriend.UseHelp(_CurrentQuestion);
                    HelpFromFriend.IsUsed = true;
                    return chosenAnswer = InputParser.CheckInput(1, _CurrentQuestion.Answers.Count);
            }
            return chosenAnswer;
        }

    }
}
