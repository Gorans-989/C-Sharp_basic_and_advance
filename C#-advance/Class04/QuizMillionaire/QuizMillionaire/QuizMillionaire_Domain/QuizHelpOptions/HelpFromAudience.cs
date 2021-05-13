using QuizMillionaire_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.QuizHelpOptions
{
    public static class HelpFromAudience
    {
        public static bool IsUsed { get; set; }


        public static Question UseHelp(Question question)
        {// prvicno ja napraviv da vrakja question ama se poremeti i posle ja smeniv da printa.
            Question temp = question;
            int indexOfCorrectAnswer = temp.Answers.IndexOf(temp.CorrectAnswer);
            for (int i = 0; i < temp.Answers.Count; i++)
            {
                int random = new Random().Next(50, 90);
                if(i == indexOfCorrectAnswer)
                {
                    random = new Random().Next(80, 100);

                    Console.WriteLine($"{i + 1}.{temp.Answers[i]} {random} %");
                    continue;
                }
                Console.WriteLine($"{i + 1}.{temp.Answers[i]} {random} %");
                
            }
            
            return temp;
        }


    }
}
