namespace byt5_6.ResponsibilityDesign.Operations;

/// <summary>
/// The Concrete Handler for requests handling division of operators.
/// </summary>
public class Division : IOperation
{
    private IOperation? _next;
    
    /// <inheritdoc />
    public void SetNext(IOperation? operation)
    {
        _next = operation;
    }

    /// <inheritdoc />
    public void Handle(OperationModel operation)
    {
        if (operation.Operator == '/')
        {
            if (operation.Number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            
            operation.Result = operation.Number1 / operation.Number2;
            Console.WriteLine($"{operation.Number1} / {operation.Number2} = {operation.Result}");
        }
        else
        {
            _next?.Handle(operation);
        }
    }
}