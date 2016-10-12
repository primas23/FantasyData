// <copyright file="FdContext.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Context
{
    using System.Data.Entity;

    using FD.Data.Model;

    /// <summary>
    /// The Data context of the application
    /// </summary>
    public class FdContext : DbContext
    {
        /// <summary>
        /// Gets or sets the phases.
        /// </summary>
        /// <value>
        /// The phases.
        /// </value>
        public virtual IDbSet<Phase> Phases { get; set; }

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public virtual IDbSet<Player> Players { get; set; }
        
        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        /// <value>
        /// The teams.
        /// </value>
        public virtual IDbSet<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets the player types.
        /// </summary>
        /// <value>
        /// The player types.
        /// </value>
        public virtual IDbSet<PlayerType> PlayerTypes { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>
        /// The events.
        /// </value>
        public virtual IDbSet<Event> Events { get; set; }
    }
}
