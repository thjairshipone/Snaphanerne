namespace Snaphanerne
{
    using System.Data.Entity;
    using Models.Entity;

    /// <summary>
    /// The database context
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class SnaphanerneContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnaphanerneContext"/> class.
        /// </summary>
        public SnaphanerneContext()
            : base("name=SnaphanerneContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        // Here is the place to have pointer to the Database tables

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public DbSet<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the matches.
        /// </summary>
        /// <value>
        /// The matches.
        /// </value>
        public DbSet<Match> Matches { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        public DbSet<Tournament> Tournaments { get; set; }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Follow the fluint API to create tables aftrer models
            // Link: http://www.entityframeworktutorial.net/code-first/fluent-api-in-code-first.aspx
            // Ref: https://docs.google.com/document/d/13ChAjp-VtVRT_x3Hftf_TAFvO889a-J74x7wyK_54po/edit
            base.OnModelCreating(modelBuilder);
        }
    }
}