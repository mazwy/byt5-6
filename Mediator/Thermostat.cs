namespace byt5_6.Mediator;

/// <summary>
/// Concrete implementation of the device. This is the Colleague in the Mediator pattern.
/// </summary>
public class Thermostat : IDevice
{
    private readonly IMediator _mediator;
    public string Name { get; }
    public double Temperature { get; set; }
    
    public StateEnum State { get; set; } = StateEnum.On;

    public Thermostat(IMediator mediator, string name)
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
        Console.WriteLine($"Thermostat {Name} received message: {message}");
    }
    
    /// <summary>
    /// Set the temperature of the thermostat.
    /// </summary>
    /// <param name="temp">
    /// Desired temperature.
    /// </param>
    public void SetTemp(double temp)
    {
        Temperature = temp;
        Console.WriteLine($"Thermostat {Name} set temperature to {temp}");
    }
}