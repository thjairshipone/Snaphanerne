namespace Snaphanerne.Repositories
{
    using Interfaces;
    using Models.Entity;

    /// <summary>
    /// This is the mirror of the database
    /// </summary>
    /// <author>Lord Ni</author>
    /// <seealso cref="Snaphanerne.Repositories.BaseRepository{Snaphanerne.Models.Entity.Player}" />
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public PlayerRepository(SnaphanerneContext context)
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