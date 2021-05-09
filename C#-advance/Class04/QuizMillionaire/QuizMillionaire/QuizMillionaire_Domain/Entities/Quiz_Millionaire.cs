using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.Entities
{
    public class Quiz_Millionaire
    {
        public Dictionary<string, int> Answers { get; set; }
        public void HelpFromAudience()
        {
            //some logic
        }
        public void HelpFromFriend()
        {
            //some logic
        }
        public void HelpFiftyFifty()
        {
            //some Logic
        }
        
    }


    
//### *`QuizMillionaire`*
//- Random rnd
//- Question[] questions15
//- Dictionary<string, int> answerChoices
//- HelpAudience hAA
//- HelpFriend hCF
//- HelpFiftyFifty hFF
//- void ShufflePossibleQuestions()
//- void GenerateQuestion15()
//- void PrintQuestion(int questionNumber, Question q)
//- void PrintHelOptions()
//- override void Start()
}
