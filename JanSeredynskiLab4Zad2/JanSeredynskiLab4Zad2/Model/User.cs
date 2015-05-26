using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanSeredynskiLab4Zad2.Model
{
    partial class User
    {
        #region Pobieranie podstawowych danych o uzytkowniku
        /// <summary>
        /// Sprawdza czy haslo in login sa poprawne
        /// </summary>
        /// <returns>-1 gdy nie poprawne lub 0 gdy poprawne</returns>
        public static int getIDByNameAndPassword(string nameArgument, string passwordArgument)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            List<User> query = (from user in dataContext.Users
                               where user.Name == nameArgument
                               where user.Password == passwordArgument
                               select user).ToList();
            if (query.Count == 0) return -1;
            return query.First().UserID;
        }

        public static int getIDByName(string nameArgument)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            List<User> query = (from user in dataContext.Users
                                where user.Name == nameArgument
                                select user).ToList();
            if (query.Count == 0) return -1; // Taki użytkownik nie istnieje
            return query.First().UserID;
        }

        /// <summary>
        /// Pobiera podstawowe informacje o pokemonie
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static User getStatusByID(int userID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            List<User> query = (from user in dataContext.Users
                                where user.UserID == userID
                                select user).ToList();
            if (query.Count == 0) return null; // Taki użytkownik nie istnieje
            return query.First();
        }


        

        /// <summary>
        /// Dodawanie punktów graczowi, np po wygranej
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="points"></param>
        #endregion
        #region Dodawanie Punktów
        public static void addPoints(int userID, int points)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            int query = (from user in dataContext.Users
                                  where user.UserID == userID
                                  select user.Point).ToList().First();
            query += points;
            dataContext.SubmitChanges();
            return;
        }
        #endregion
        #region Tworzenie użytkowników
        public static int createAccount(string userName, string userPassword)
        {
            if (getIDByName(userName) >= 0)
                return -1; // Taki użytkownik już istnieje


            User user = new User();
            user.Name = userName;
            user.Password = userPassword;
            user.Point = 0;
            user.Money = 500;

            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            dataContext.Users.InsertOnSubmit(user);
            dataContext.SubmitChanges();
            return user.UserID;
        }
        #endregion
        #region Pobieranie list graczy
        /// <summary>
        /// pobiera liste graczy z którymi mozemy walczyć
        /// </summary>
        public static List<string> getUserListToFight(int userID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            List<string> query = (from user in dataContext.Users
                                  where user.UserID != userID
                                  select user.Name).ToList();
            if (query.Count == 0) return null; // Taki użytkownik nie istnieje
            return query;
        }
        #endregion
    }
}
