namespace byt5_6.Mediator;

/// <summary>
/// A bulb device. This is the ConcreteColleague in the Mediator pattern.
/// </summary>
public class Hub : IMediator
{
    private IReadOnlyCollection<IDevice> _devices = new List<IDevice>();
    
    public void AddDevice(IDevice device)
    {
        _devices = _devices.Append(device).ToList();
    }
    
    /// <inheritdoc />
    public void Send(IDevice device, string message)
    {
        foreach (var d in _devices)
        {
            if (d != device && d.State == StateEnum.On)
                d.Receive(message);
        }
    }
    
    /// <inheritdoc />
    public void Receive(IDevice device, string message)
    {
        foreach (var d in _devices)
        {
            if (d != device && d.State == StateEnum.On)
                d.Receive(message);
        }
    }
}