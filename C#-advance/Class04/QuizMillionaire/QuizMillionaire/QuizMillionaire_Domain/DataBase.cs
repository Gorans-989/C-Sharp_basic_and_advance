using QuizMillionaire_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain
{
    public static class DataBase
    {
        public static List<Question> Questions { get; set; }

        static DataBase()
        {
            AddQuestions();
        }


        public static void AddQuestions()
        {
            Questions = new List<Question>()
            {
                new Question ("Koj e glaven grad na Republika Makedonija", "Skopje")
                {Answers = { "Skopje", "Kumanovo", "Bitola", "Veles" } },
                new Question ("Kako se vika junakot od crtanite koj jade Spanjak", "Popaj")
                {Answers = {"Mile", "Popaj", "Supermen", "Apasiev"} },
                new Question ("Koja e bojata na sonceto", "Zolta")
                {Answers = {"Sina", "Crvena", "Rozeva", "Zolta"} },
                new Question ("Kaj kogo odi Crvenkapa vo istoimenata prikazna", "Baba i")
                {Answers = {"Baba i", "Zoran Zaev", "Volkot", "Dedo i"} },
                new Question("Kolku kontitenti ima vo svetot" , "7")
                {Answers = {"7", "10", "2","8"} },
                new Question ("Kolku e 5 + 5 * 0", "5")
                {Answers = {"0", "10", "5", "25"} },
                new Question ("Vo koja drzava se proizveduva avtomobilot Mercedes", "Germanija")
                {Answers = {"Anglija", "Veles", "Germanija", "Spanija"} },
                new Question ("Kako se vika najseverniot kontinent na svetot", "Antarktik")
                {Answers = {"Antarik", "Antarktik", "Atarktik", "Antartik" } },
                new Question ("Koi boi ja pravat kratenkata RGB", "Crvena - zelena - sina")
                {Answers = { "Crvena - zelena - sina", "Crvena - zolta - sina", "Zelena - sina - crna", "Crvena - sina - bela" } },
                new Question ("Kolku trkala ima avtomobilot", "4")
                {Answers = {"6", "4", "5", "8"} },
                new Question ("Sto mu rekol Betmen na Robin pred da vlezat vo BetMobilot", "Robin, vlezi vo Betmobilot")
                {Answers = {"Proveri dali e dupnata gumata", "Prati \"S\" za stop na parking", "Robin, vlezi vo Betmobilot", "Nisto"}},
                new Question ("Kolku prsti ima covekot na edna raka", "5")
                {Answers = {"2", "5", "1", "6" } },
                new Question("Kolku minuti ima vo eden cas", "60")
                {Answers = {"60", "30", "48", "90"}},
                new Question("Za koj fudbalski klub igra Messi", "Barcelona")
                {Answers = {"Vardar", "Bayern Minchen", "Barcelona", "Liverpool" } },
                new Question("Koj e glaven grad na Francija", "Paris")
                {Answers = {"Paris", "Tokio", "Skopje", "Dracevo"} }  
            };
        }



    }
}
