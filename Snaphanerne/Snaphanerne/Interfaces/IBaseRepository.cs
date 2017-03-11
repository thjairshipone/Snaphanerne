namespace Snaphanerne.Interfaces
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Finds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The entity to be found</returns>
        TEntity Find(int id);

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The created entity</returns>
        TEntity Create(TEntity entity);
        
        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The updated entity</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);
    }
}
