// <copyright file="Startup.cs" company="Primas">
//     Company copyright tag.
// </copyright>

using FD.Data.Model;
using FD.WebCrawler;

namespace FD.ConsoleApplication
{
    /// <summary>
    /// The startup class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            PlayersInformation information = new PlayersInformation();
            information = FantasyPremierLeague.GetPlayersInformationFromWeb();


        }
    }
}
