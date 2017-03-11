namespace Snaphanerne.Repositories
{
    using System.Data.Entity;

    public class BaseRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// The database context
        /// </summary>
        private DbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{T}" /> class.
        /// </summary>
        /// <param name="context">The DbContext</param>
        public BaseRepository(DbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        protected DbContext Context
        {
            get
            {
                return this.context;
            }
        }

        /// <summary>
        /// Finds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The entity to be found</returns>
        public TEntity Find(int id)
        {
            return this.Context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The created entity</returns>
        public TEntity Create(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
            this.Context.SaveChanges();
            return entity;
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The updated entity</returns>
        public TEntity Update(TEntity entity)
        {
            this.Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            this.Context.Set<TEntity>().Remove(
                this.Context.Set<TEntity>().Find(id));
        }
    }
}