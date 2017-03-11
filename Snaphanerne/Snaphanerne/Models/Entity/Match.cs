namespace Snaphanerne.Models.Entity
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This classs holds information about the matches created
    /// </summary>
    /// <author>Lord Ni</author>
    public class Match
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Match"/> class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "Entity Framework")]
        public Match()
        {
            this.Prepare = true;
            this.Rooster = new HashSet<Player>();
            this.Team = new HashSet<Player>();
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
        /// Gets or sets the opponent.
        /// </summary>
        /// <value>
        /// The opponent.
        /// </value>
        public string Opponent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Match"/> is prepare.
        /// </summary>
        /// <value>
        ///   <c>true</c> if prepare; otherwise, <c>false</c>.
        /// </value>
        public bool Prepare { get; set; }

        /// <summary>
        /// Gets or sets the other information.
        /// if there is other information it should be added here
        /// </summary>
        /// <value>
        /// The other information.
        /// </value>
        public string OtherInformation { get; set; }

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>
        /// The start.
        /// </value>
        public virtual DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>
        /// The end.
        /// </value>
        public virtual DateTime End { get; set; }

        /// <summary>
        /// Gets or sets the size of the match.
        /// </summary>
        /// <value>
        /// The size of the match.
        /// </value>
        public ICollection<string> MatchSize { get; set; }

        /// <summary>
        /// Gets or sets the tournament.
        /// </summary>
        /// <value>
        /// The tournament.
        /// </value>
        public virtual Tournament Tournament { get; set; }

        /// <summary>
        /// Gets or sets the rooster.
        /// </summary>
        /// <value>
        /// The rooster.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Entity Framework")]
        public virtual ICollection<Player> Rooster { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Entity Framework")]
        public virtual ICollection<Player> Team { get; set; }
    }
}