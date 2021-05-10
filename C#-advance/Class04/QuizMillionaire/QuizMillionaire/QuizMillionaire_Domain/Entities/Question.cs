using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Answers { get; set; }

        public Question(string title,  string answer)
        {
            Id = ++Id;
            Title = title;
            CorrectAnswer = answer;
            Answers = new List<string>();
        }
        public bool CheckAnswer(int userChoice)
        {
            if(Answers[userChoice - 1].ToLower() == CorrectAnswer.ToLower())
            {
                return true;
            }
            return false;
        }
        public void PrintQuestion()
        {
            Console.WriteLine($"{Title}:");
        }
        public void PrintAnswers()
        {
            for( int i = 0; i< Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i]}");
            }
        }
    }
}
