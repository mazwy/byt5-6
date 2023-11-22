namespace byt5_6.ObjectPool;

/// <summary>
/// LogMessage model for custom <see cref="byt5_6.ObjectPool.Logger"/>
/// </summary>
public class LogMessage
{
    public string? Message { get; set; }
    public DateTime Sysdate { get; set; }

    /// <summary>
    /// Clears the <see cref="LogMessage"/> properties
    /// </summary>
    public void Clear()
    {
        Message = string.Empty;
        Sysdate = default;
    }
}