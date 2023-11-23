namespace byt5_6.Mediator;

/// <summary>
/// A bulb device. This is the concrete example of the Colleague in the Mediator pattern.
/// </summary>
public class Bulb : IDevice
{
    private readonly IMediator _mediator;
    public string Name { get; }
    
    public StateEnum State { get; set; } = StateEnum.Off;

    public Bulb(IMediator mediator, string name)
    {
        _mediator = mediator;
        Name = name;
    }
    
    /// <inheritdoc />
    public void Send(string message)
    {
        _mediator.Send(this, message);
    }

    /// <inheritdoc />
    public void Receive(string message)
    {
        Console.WriteLine($"Bulb {Name} received message: {message}");
    }
    
    public void TurnOn() => State = StateEnum.On;
    public void TurnOff() => State = StateEnum.Off;
}