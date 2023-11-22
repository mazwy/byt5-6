namespace byt5_6.ObjectPool;

/// <summary>
/// Custom logger using ObjectPool pattern
/// </summary>
public class Logger
{
    private readonly ObjectPool<LogMessage> _pool = new();
    
    /// <summary>
    /// Logs a message to the console through the <see cref="LogMessage"/> model
    /// </summary>
    /// <param name="message">
    /// Message to be logged
    /// </param>
    public void Log(string message)
    {
        var logMessage = _pool.Get();
        
        logMessage.Message = message;
        logMessage.Sysdate = DateTime.Now;
        
        Console.WriteLine($"LOG::{logMessage.Sysdate}::{logMessage.Message}");
        
        logMessage.Clear();
        _pool.Return(logMessage);
    }
}