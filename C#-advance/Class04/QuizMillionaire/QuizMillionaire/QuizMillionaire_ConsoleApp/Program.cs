using System;
using System.Collections.Generic;
using System.Threading;

namespace QuizMillionaire_ConsoleApp
{
    class Program
    {
        public static int _userSelection;
        public static string _currentQuestion;
        public static int _correctAnswer;

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Welcome to Who Wants To Be a MILLIONAIRE \n Press any key to start");
            Console.ReadKey();

            List<string> questions = new List<string>();
            questions.Add("Koj e glaven grad na MK");

            Dictionary<string, List<string>> questionsAndAnswers = new Dictionary<string, List<string>>();
            //questionsAndAnswers.Add(questions[0], "Skopje Kumanovo Tetovo Bitola");
            
            questionsAndAnswers.Add(questions[0], new List<string> {"Skopje","Kumanovo","Tetovo","Bitola"});
            Dictionary<string, int> answers = new Dictionary<string, int>();
            answers.Add(questions[0], 1);


            for (int i = 0; i < 15; i++)
            {
                Console.Clear();
                if(i == 14)
                {
                    Console.WriteLine("Last Question!!!!");
                }
                _currentQuestion = questions[i];
                _correctAnswer = answers[_currentQuestion];
                Console.WriteLine($"Question number: {i + 1}:");
                Console.WriteLine($"{questions[i]}");
                // cw the answers
                Console.WriteLine("Please Choose one answer");
                Thread.Sleep(3000);
                questionsAndAnswers[_currentQuestion].ForEach(x => Console.WriteLine($"\n{++i}. {x}"));

                bool isValid = int.TryParse(Console.ReadLine(), out int selection);
                if (isValid)
                {
                    _userSelection = selection;
                    if (selection != _correctAnswer)
                    {
                        Console.WriteLine($"Sorry wrong answer. The answer is under {answers[_currentQuestion]}");
                        break;
                    }
                    else if (_correctAnswer == selection)
                    {
                        Console.WriteLine("Correct answer!!!");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
            }
            
            */
            Console.ReadLine();
        }

        //public static bool CheckAnswer(Dictionary<string,int> questionsAndAnswers,string question, int userAnswer)
        //{
        //    if (questionsAndAnswers.TryGetValue(question, out int answerValue))
        //    {
        //        if(answerValue == userAnswer)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
