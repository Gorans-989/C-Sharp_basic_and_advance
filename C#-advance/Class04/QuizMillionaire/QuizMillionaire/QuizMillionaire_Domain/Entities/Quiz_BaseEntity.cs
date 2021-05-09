using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.Entities
{
    public class Quiz_BaseEntity
    {
        public string Name { get; set; }
        public List<string> Questions { get; set; }

        public Quiz_BaseEntity()
        {
            Questions = new List<string>();
        }
        public virtual void Start()
        {
            //some Logic
        }
    }
}
