namespace byt5_6.Mediator;

/// <summary>
/// Interface for the device. This is the Colleague in the Mediator pattern.
/// </summary>
public interface IDevice
{
    string Name { get; }
    StateEnum State { get; set; }

    /// <summary>
    /// Send a message to the mediator.
    /// </summary>
    /// <param name="message">
    /// The message to send.
    /// </param>
    void Send(string message);
    
    /// <summary>
    /// Receive a message from the mediator.
    /// </summary>
    /// <param name="message">
    /// The message to receive.
    /// </param>
    void Receive(string message);
}