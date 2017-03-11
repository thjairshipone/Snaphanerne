namespace Snaphanerne.Models.Entity
{
    /// <summary>
    /// This is a player holder class for helping setting up the tuornament schema
    /// </summary>
    /// <author>Lord Ni</author>
    public class Player
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the th leevel.
        /// </summary>
        /// <value>
        /// The th leevel.
        /// </value>
        public virtual string THLevel { get; set; }

        /// <summary>
        /// Gets or sets the match.
        /// </summary>
        /// <value>
        /// The match.
        /// </value>
        public virtual Match Match { get; set; }
    }
}