using QuizMillionaire_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.QuizHelpOptions
{
    public static class HelpFromFriend
    {
        public static bool IsUsed { get; set; }


        public static void UseHelp(Question question)
        {
            Question temp = question;
            int indexOfCorrectAnswer = temp.Answers.IndexOf(temp.CorrectAnswer);
            for (int i = 0; i < temp.Answers.Count; i++)
            {
                if (i == indexOfCorrectAnswer)
                {
                    int random = new Random().Next(50, 90);
                    Console.WriteLine($"{i + 1}.{temp.Answers[i]} {random} %");
                    continue;
                }
                Console.WriteLine($"{i + 1}.{temp.Answers[i]}");

            }

            
        }


    }
}
