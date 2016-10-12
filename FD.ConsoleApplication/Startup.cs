// <copyright file="Startup.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.ConsoleApplication
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    using FD.Data.Context;
    using FD.Data.Model;
    using FD.WebCrawler;

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
            FantasyPremierLeague.AddOrUpdateDataBase();
        }
    }
}
