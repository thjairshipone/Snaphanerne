namespace Snaphanerne.Models.Entity
{
    using System.Collections.Generic;

    /// <summary>
    /// This is the parent class for a tournament
    /// </summary>
    public class Tournament
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tournament"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "Entity Framework")]
        public Tournament()
        {
            this.Matches = new HashSet<Match>();
        }

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
        /// Gets or sets the matches.
        /// </summary>
        /// <value>
        /// The matches.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Entity Framework")]
        public virtual ICollection<Match> Matches { get; set; }
    }
}