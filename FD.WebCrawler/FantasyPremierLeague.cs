// <copyright file="FantasyPremierLeague.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.WebCrawler
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Net;

    using Newtonsoft.Json;

    using FD.Data.Common.Contracts;
    using FD.Data.Context;
    using FD.Data.Model;

    /// <summary>
    /// The Fantasy Premier League Information
    /// </summary>
    public static class FantasyPremierLeague
    {
        /// <summary>
        /// The URL for the fantasy premier league 
        /// </summary>
        private const string Url = "https://fantasy.premierleague.com/drf/bootstrap-static";

        /// <summary>
        /// Gets the players information from web.
        /// </summary>
        /// <returns>The Players Information</returns>
        public static PlayersInformation GetPlayersInformationFromWeb()
        {
            PlayersInformation informations = new PlayersInformation();

            WebRequest webRequest = WebRequest.Create(Url);
            var responseStream = webRequest.GetResponse().GetResponseStream();
            
            if (responseStream != null)
            {
                using (StreamReader objStream = new StreamReader(responseStream))
                {
                    string json = objStream.ReadToEnd();
                    informations = JsonConvert.DeserializeObject<PlayersInformation>(json);
                }
            }

            ValidateDuplicateIds(informations.Phases);
            ValidateDuplicateIds(informations.Players);
            ValidateDuplicateIds(informations.Teams);
            ValidateDuplicateIds(informations.PlayerTypes);
            ValidateDuplicateIds(informations.Events);

            return informations;
        }

        /// <summary>
        /// Adds or updates the data base. It is tightly coupled to the FdContext.
        /// </summary>
        /// <param name="information">The information.</param>
        public static void AddOrUpdateDataBase(PlayersInformation information)
        {
            using (var db = new FdContext())
            {
                AddOrUpdateDbCollection(information.Phases, db.Phases);
                AddOrUpdateDbCollection(information.Players, db.Players);
                AddOrUpdateDbCollection(information.Teams, db.Teams);
                AddOrUpdateDbCollection(information.PlayerTypes, db.PlayerTypes);
                AddOrUpdateDbCollection(information.Events, db.Events);

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Adds or updates the data base with the Players Information form the web.
        /// </summary>
        public static void AddOrUpdateDataBase()
        {
            PlayersInformation information = GetPlayersInformationFromWeb();
            AddOrUpdateDataBase(information);
        }

        /// <summary>
        /// Adds or updates database collection.
        /// </summary>
        /// <typeparam name="T">Class that it is mapped in the context</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="dbSet">The database set.</param>
        private static void AddOrUpdateDbCollection<T>(IList<T> list, IDbSet<T> dbSet) where T : class
        {
            list
                .ToList()
                .ForEach(p => dbSet.AddOrUpdate(p));
        }

        /// <summary>
        /// Validates for duplicate ids.
        /// </summary>
        /// <typeparam name="T">Any class that has implemented IIdentifier of integer</typeparam>
        /// <param name="list">The list.</param>
        /// <exception cref="DuplicateNameException">There are duplicate ids!</exception>
        private static void ValidateDuplicateIds<T>(IList<T> list) where T : IIdentifier<int>
        {
            HashSet<int> hashSet = new HashSet<int>(list.Select(i => i.Id));

            if (hashSet.Count != list.Count)
            {
                throw new DuplicateNameException("There are duplicate ids!");
            }
        }
    }
}
