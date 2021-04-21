using System;
using System.Collections.Generic;
using System.Text;

namespace Class01.Task01.Logic.Services
{
    public class SearchService
    {

        public Dictionary<string, int> CountInText (string text, List<string> names)
        {
            Dictionary<string, int> searchResult = new Dictionary<string, int>();
            string[] searchText = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);



            return searchResult;
        }


        public void CountApperancesInText(string text, List<string> names)
        {
            string[] searchText = text.Split(" ");
            int counter = 0;

            foreach(string name in names)
            {


                foreach(string word in searchText)
                {
                    //
                    if(word.Trim().ToLower() == name.Trim().ToLower())
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The name: {name} is contained {counter} Times");
                counter = 0;
            }




        }

    }
}
