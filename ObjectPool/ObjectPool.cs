namespace byt5_6.ObjectPool;

/// <summary>
/// Generic Object Pool implementation
/// </summary>
/// <typeparam name="T">
/// Type of object to be pooled
/// </typeparam>
/// <remarks>
/// Yes there can be more here but for not overcomplicating the example let's keep it simple
/// (or for example it could be into a separate file, but for debugging purposes it's more convenient to have it here)
/// </remarks>
public class ObjectPool<T> where T : new()
{
    private readonly Queue<T> _pool = new();
    
    /// <summary>
    /// Gets an object from the pool or creates a new one if the pool is empty
    /// </summary>
    /// <returns>
    /// An object of type <typeparamref name="T"/>
    /// </returns>
    public T Get()
    {
        return _pool.Count == 0 ? new T() : _pool.Dequeue();
    }
    
    /// <summary>
    /// Returns an object to the pool
    /// </summary>
    /// <param name="item">
    /// Object to be returned
    /// </param>
    public void Return(T item)
    {
        _pool.Enqueue(item);
    }
}