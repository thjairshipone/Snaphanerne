namespace Snaphanerne.Repositories
{
    using Models.Entity;

    /// <summary>
    /// The mirror of the database table tournament
    /// </summary>
    /// <author>Lord Ni</author>
    /// <seealso cref="Snaphanerne.Repositories.BaseRepository{Snaphanerne.Models.Entity.Tournament}" />
    public class TournamentRepository : BaseRepository<Tournament>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TournamentRepository(SnaphanerneContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the snaphanerne context.
        /// </summary>
        /// <value>
        /// The snaphanerne context.
        /// </value>
        private SnaphanerneContext SnaphanerneContext
        {
            get
            {
                return (SnaphanerneContext)this.Context;
            }
        }
    }
}