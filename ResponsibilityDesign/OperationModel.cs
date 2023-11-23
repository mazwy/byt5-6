namespace byt5_6.ResponsibilityDesign;

/// <summary>
/// Model for the operation to be handled.
/// </summary>
public class OperationModel
{
    public char Operator { get; init; }
    public double Number1 { get; init; }
    public double Number2 { get; init; }
    public double Result { get; set; }
}