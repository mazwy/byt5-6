namespace byt5_6.ResponsibilityDesign.Operations;

/// <summary>
/// The Handler interface declares a method for building the chain of handlers.
/// It also declares a method for executing a request.
/// </summary>
public interface IOperation
{
    /// <summary>
    /// Sets the next handler to receive the request.
    /// </summary>
    /// <param name="operation">
    /// The operation for the next handler.
    /// </param>
    void SetNext(IOperation? operation);
    
    /// <summary>
    /// Executes the request.
    /// </summary>
    /// <param name="operation">
    /// The operation model made of the two numbers and the operator.
    /// </param>
    void Handle(OperationModel operation);
}