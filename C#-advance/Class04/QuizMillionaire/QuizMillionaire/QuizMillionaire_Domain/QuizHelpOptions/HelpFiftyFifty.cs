using QuizMillionaire_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.QuizHelpOptions
{
    public static class HelpFiftyFifty
    {
        
        public static bool IsUsed { get ; set ; }
        

        public static Question UseHelp(Question question)
        {
            
            Question temp = question;
            
            while(temp.Answers.Count != 2)
            {
                int indexOfCorrectAnswer = temp.Answers.IndexOf(temp.CorrectAnswer);
                int random = new Random().Next(0, temp.Answers.Count);
                if(indexOfCorrectAnswer == random)
                {
                    continue;
                }
                temp.Answers.RemoveAt(random);
            }

            return temp;
        }
    }
}
