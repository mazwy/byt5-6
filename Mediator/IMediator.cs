namespace byt5_6.Mediator;

/// <summary>
/// Interface for the mediator. Nothing special
/// </summary>
public interface IMediator
{
    /// <summary>
    /// Send a message to the mediator.
    /// </summary>
    /// <param name="device">
    /// The device that sent the message.
    /// </param>
    /// <param name="message">
    /// The message to send.
    /// </param>
    void Send(IDevice device, string message);
    
    /// <summary>
    /// Receive a message from the mediator.
    /// </summary>
    /// <param name="device">
    /// The device that sent the message.
    /// </param>
    /// <param name="message">
    /// The message to receive.
    /// </param>
    void Receive(IDevice device, string message);
}