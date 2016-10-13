// <copyright file="IId.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Common.Contracts
{
    /// <summary>
    /// The Interface for id property of any type
    /// </summary>
    /// <typeparam name="T">Any struct</typeparam>
    public interface IIdentifier<T> where T : struct
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        T Id { get; set; }
    }
}
