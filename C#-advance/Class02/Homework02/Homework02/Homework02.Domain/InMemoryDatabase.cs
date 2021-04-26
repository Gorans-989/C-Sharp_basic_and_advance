using Homework02.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain
{
    public static class InMemoryDatabase
    {
        public static List<Moderator> Moderators { get; set; }
        public static List<Guest> Guests { get; set; }
        public static List<Poster> Posters { get; set; }
        public static List<User> ListOfUsers { get; set; }
       
        static InMemoryDatabase()
        {
            GenerateGuests();
            GeneratePosters();
            GenerateModerators();
            FillUsers();
            FillModeratorsWithUsers();


            //asignSubjectsToStudents();
        }

        private static void GenerateGuests() { 
            Guests = new List<Guest>
            {
                new Guest("Goran", 1),
                new Guest("Zoran", 2),
                new Guest("Jack", 3),
                new Guest("Jill", 4),
                new Guest("Hannah", 5)
            };
        }
        private static void GenerateModerators()
        {
            Moderators = new List<Moderator>
            {
                new Moderator("Bill"),
                new Moderator("Ted"),
                new Moderator("Kelly"),
                new Moderator("Kyra"),
                new Moderator("John")
            };
        }
        private static void GeneratePosters()
        {
            Posters = new List<Poster>
            {
                new Poster("Ana", 239),
                new Poster("Jana", 238),
                new Poster("Pero", 178),
                new Poster("Jane", 332),
                new Poster("Tarzan", 150)
            };
        }

        private static void FillUsers()
        {
            ListOfUsers = new List<User>();
            foreach (Guest item in Guests)
            {
                ListOfUsers.Add(item);
            }
            foreach (Poster item in Posters)
            {
                ListOfUsers.Add(item);
            }
        }

        private static void FillModeratorsWithUsers()
        {
            foreach (Moderator item in Moderators)
            {
                item.Users = new List<User>(ListOfUsers);
            }
        }
    }
}
