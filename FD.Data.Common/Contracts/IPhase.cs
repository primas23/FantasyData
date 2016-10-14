namespace FD.Data.Common.Contracts
{
    public interface IPhase : IIdentifier<int>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the start event.
        /// </summary>
        /// <value>
        /// The start event.
        /// </value>
        int StartEvent { get; set; }

        /// <summary>
        /// Gets or sets the stop event.
        /// </summary>
        /// <value>
        /// The stop event.
        /// </value>
        int StopEvent { get; set; }
    }
}