using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanSeredynskiLab4Zad2.Model
{
    partial class Pokemon
    {

        #region Wyświetlanie informacji o pokemonach - ich nazw, wsp ataku, cen ...

        /// <summary>
        /// Zwraca ID pokemona na podstawie jego nazwy
        /// </summary>
        /// <param name="pokemonName"></param>
        /// <returns></returns>
        public static int getIDByName(string pokemonName)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            int query = (from pokemon in dataContext.Pokemons
                         where pokemon.Name == pokemonName
                         select pokemon.PokemonID).ToList().First();
            return query;
        }

        /// <summary>
        /// Pobiera liste Pokemonów
        /// </summary>
        /// <returns></returns>
        public static List<Pokemon> getPokemonList()
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            List<Pokemon> query = (from pokemon in dataContext.Pokemons
                                   select pokemon).ToList();
            if (query.Count == 0) return null;
            return query;
        }

        /// <summary>
        /// Pobiera liste poemonów ktore posiada użytkownik
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static List<View_User_PokemonList> getMyPokemonList(int userID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            List<View_User_PokemonList> query = (from pokemon in dataContext.View_User_PokemonLists
                                                 where pokemon.UserID == userID
                                                 select pokemon).ToList();
//            if (query.Count == 0) return null;
            return query;
        }

        /// <summary>
        /// Pobiera informacje o pokemonie
        /// </summary>
        public static View_PokemonType_Pokemon getInfoByName(string pokemonName)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            View_PokemonType_Pokemon query = (from pokemon in dataContext.View_PokemonType_Pokemons
                             where pokemon.PokemonName == pokemonName
                             select pokemon).ToList().First();
            
            return query;
        }
        #endregion
        #region Kupowanie, edycja pokemonów
        /// <summary>
        /// Kupuje pokemona o wyznacyonej nazwie dla wyznaczonego uzykownika
        /// </summary>
        public static int buyPokemon(string pokemonName, int userID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();


            UserPokemonList userPokemonList = new UserPokemonList();
            var query                 = (from pokemon in dataContext.Pokemons
                                         where pokemon.Name == pokemonName
                                         select new { pokemon.PokemonID, pokemon.Cost })
                                         .ToList().First();
            userPokemonList.PokemonID = query.PokemonID;
            userPokemonList.UserID = userID;

            var user =             (from dcUser in dataContext.Users
                                   where dcUser.UserID == userID
                                   select dcUser).ToList().First();

            if (query.Cost > user.Money) return -1; // Nie stać uzytkowanika na tego pokemona

            user.Money = user.Money - query.Cost;
            dataContext.UserPokemonLists.InsertOnSubmit(userPokemonList);
            dataContext.SubmitChanges();
            return 0;
        }

        #endregion
        #region Opracowanie walki pokemonów - algorytmy walki, wysylanie wyzwania, przyjmowanie wyzwania

        /// <summary>
        /// Rozpoczyna walke
        /// Wysyla wyzwanie do walki lub je przyjmuje. Następnie zlicza parametry pokemonów
        /// i wyswietla osoboe ktora wygrala
        /// </summary>
        /// <returns></returns>
        public static string fight(int thisUserID, int opponentID, int pokemon1, int pokemon2, int pokemon3)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            var fightInfo = (from fight in dataContext.FightResults
                             where fight.UserAgressorID == opponentID
                             where fight.UserDefenderID == thisUserID
                             where fight.Result == -1 // -1 znaczy ze jeszcze nie walczono
                             select fight).ToList();

            if(fightInfo.Count > 0) // byl juz wczesniej wyzwany
            {
                int resultOfFight = 0;
                int fightBalance = 0; // positive is for agressor
                string winner;
                if (whoWins(fightInfo.First().PokemonAgressor1ID, pokemon1) == 1) fightBalance++;
                else if (whoWins(fightInfo.First().PokemonAgressor1ID, pokemon1) == 2) fightBalance--;

                if (whoWins(fightInfo.First().PokemonAgressor2ID, pokemon2) == 1) fightBalance++;
                else if (whoWins(fightInfo.First().PokemonAgressor2ID, pokemon2) == 2) fightBalance--;

                if (whoWins(fightInfo.First().PokemonAgressor3ID, pokemon3) == 1) fightBalance++;
                else if (whoWins(fightInfo.First().PokemonAgressor3ID, pokemon3) == 2) fightBalance--;
                //koniec wojny
                if (fightBalance > 0)
                { 
                    resultOfFight = 1;
                    winner = Model.User.getStatusByID(opponentID).Name;
                    fightInfo.First().ResultDescription = "Mecz wygrał " + Model.User.getStatusByID(opponentID).Name;
                    Model.User.addPoints(opponentID, 5);
                }
                else if (fightBalance < 0)
                {
                    resultOfFight = 2;
                    winner = Model.User.getStatusByID(thisUserID).Name;
                    fightInfo.First().ResultDescription = "Mecz wygrał " + Model.User.getStatusByID(thisUserID).Name;
                    Model.User.addPoints(thisUserID, 5);
                }
                else 
                { 
                    resultOfFight = 0; 
                    winner = " REMIS ";
                    fightInfo.First().ResultDescription = "Mecz zakończono remisem ";
                
                }

               
                fightInfo.First().Result = resultOfFight;
                dataContext.SubmitChanges();

                return "Wojne wygrał " + winner;
            }

            else // wyzywam przeciwnika
            {
                FightResult fightResult = new FightResult();
                fightResult.UserAgressorID = thisUserID;
                fightResult.UserDefenderID = opponentID;
                fightResult.Result = -1;
                fightResult.PokemonAgressor1ID = pokemon1;
                fightResult.PokemonAgressor2ID = pokemon2;
                fightResult.PokemonAgressor3ID = pokemon3;
                fightResult.ResultDescription = "Nowe wyzwanie od " + Model.User.getStatusByID(thisUserID).Name;
                fightResult.ResultDescription +=
                                                " dla " + Model.User.getStatusByID(opponentID).Name;
                dataContext.FightResults.InsertOnSubmit(fightResult);
                dataContext.SubmitChanges(); // Zapisujemy zmiany
                return "Twoje pokemony poszły do boju\nTeraz czekaj aż oponent wybierze swoje pokemony do walki.";
            }
  
        }

        
        /// <summary>
        /// Sprawdza wsp ataku konkretnej rasy na inną
        /// </summary>
        /// <returns></returns>
        public static int getAttackRate(int pokemonAgressorID, int pokemonDefenderID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            var query = (from pokemon in dataContext.View_FightBonus_PokemonTypes
                         where pokemon.IDPokemonTypeAgressor == pokemonAgressorID
                         where pokemon.IDPokemonTypeDefender == pokemonDefenderID
                         select pokemon).ToList();
            if (query.Count == 0) return 0;
            return query.First().BonusRate;
        }

        /// <summary>
        /// Funkcja mierzy pokemony i pokazuje zwyciezce
        /// </summary>
        /// <param name="firstPokemonID"></param>
        /// <param name="secondPokemonID"></param>
        /// <returns></returns>
        public static int whoWins(int firstPokemonID, int secondPokemonID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            var queryFirstPokemon = (from pokemon in dataContext.Pokemons
                                     where pokemon.PokemonID == firstPokemonID
                                     select pokemon).ToList().First();

            var querySecondPokemon = (from pokemon in dataContext.Pokemons
                                      where pokemon.PokemonID == secondPokemonID
                                      select pokemon).ToList().First();


            while (queryFirstPokemon.HitPoint > 0 && querySecondPokemon.HitPoint > 0)
            {
                queryFirstPokemon.HitPoint =
                    queryFirstPokemon.HitPoint -
                    querySecondPokemon.DamageRate -
                        getAttackRate(querySecondPokemon.PokemonID, queryFirstPokemon.PokemonID);

                querySecondPokemon.HitPoint =
                    querySecondPokemon.HitPoint -
                    queryFirstPokemon.DamageRate -
                        getAttackRate(queryFirstPokemon.PokemonID, querySecondPokemon.PokemonID);
            }
            if (queryFirstPokemon.HitPoint < 0 && querySecondPokemon.HitPoint < 0)
                return 0;
            else if (queryFirstPokemon.HitPoint < 0)
                return 2; // wygral drugibo ten przegral
            else if(querySecondPokemon.HitPoint < 0)
                return 1; // wygral pierwszy bo ten przegral

            return 0;
        }
#endregion
        #region Powiadomienia
        /// <summary>
        /// Pobiera powiadomienia o np wyzwaniu, wygranej, przegranej
        /// </summary>
        public static List<string> getNotification(int userID)
        {
            DataClassesGamePokemonDataContext dataContext = new DataClassesGamePokemonDataContext();
            var query = (from pokemon in dataContext.FightResults
                         where( pokemon.UserAgressorID == userID ||
                                pokemon.UserDefenderID == userID)
                          orderby pokemon.FightID descending
                         select pokemon.ResultDescription).ToList();
            if (query.Count == 0) return null;
            return query;
        }
        #endregion
    }

}
