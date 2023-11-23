using byt5_6.Mediator;
using byt5_6.ObjectPool;
using byt5_6.ResponsibilityDesign;
using byt5_6.ResponsibilityDesign.Operations;

namespace byt5_6;

// ReSharper disable once ClassNeverInstantiated.Global
public class Program
{
    public static void Main(string[] args)
    {
        #region Calculator-ResponsibilityDesign
        
        IOperation division = new Division();
        IOperation multiplication = new Multiplication();
        IOperation subtraction = new Subtraction();
        IOperation addition = new Addition();
        
        division.SetNext(multiplication);
        multiplication.SetNext(subtraction);
        subtraction.SetNext(addition);

        var divide = new OperationModel
        {
            Number1 = 22,
            Number2 = 2,
            Operator = '/'
        };
        
        var multiply = new OperationModel
        {
            Number1 = 22,
            Number2 = 2,
            Operator = '*'
        };
        
        var subtract = new OperationModel
        {
            Number1 = 22,
            Number2 = 2,
            Operator = '-'
        };
        
        var add = new OperationModel
        {
            Number1 = 22,
            Number2 = 2,
            Operator = '+'
        };
        
        division.Handle(divide);
        division.Handle(multiply);
        division.Handle(subtract);
        division.Handle(add);
        
        #endregion

        #region SmartHome-MediatorPattern

        var hub = new Hub();
        var bulb = new Bulb(hub, "Bulb1");
        var thermostat = new Thermostat(hub, "Thermostat1");
        
        hub.AddDevice(bulb);
        hub.AddDevice(thermostat);
        
        bulb.TurnOn();
        
        thermostat.SetTemp(28);

        const string bulbMessage = "Bulb says hello";
        const string thermostatMessage = "Thermostat says hello";
        const string hubMessage = "Hub says hello";
        
        hub.Send(bulb, hubMessage);
        
        bulb.Send(bulbMessage);
        thermostat.Send(thermostatMessage);
        
        #endregion
        
        #region ObjectPool

        var logger = new Logger();
        
        logger.Log("byt5_6");
        logger.Log("byt5_6 part 2");
        logger.Log("byt5_6 part 3");
        logger.Log("byt5_6 part 4");
        logger.Log("byt5_6 part 5");

        #endregion
    }
}