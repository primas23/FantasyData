// <copyright file="Startup.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.WebCrawler
{
    using System.IO;
    using System.Net;

    using Newtonsoft.Json;
    
    using FD.Data.Model;

    /// <summary>
    /// The Fantasy Premier League Information
    /// </summary>
    public static class FantasyPremierLeague
    {
        private const string Url = "https://fantasy.premierleague.com/drf/bootstrap-static";

        /// <summary>
        /// Gets the players information from web.
        /// </summary>
        /// <returns></returns>
        public static PlayersInformation GetPlayersInformationFromWeb()
        {
            PlayersInformation informations = new PlayersInformation();
            
            WebRequest webRequest = WebRequest.Create(Url);

            using (StreamReader objStream = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                string json = objStream.ReadToEnd();
                informations = JsonConvert.DeserializeObject<PlayersInformation>(json);
            }

            return informations;
        }
    }
}
