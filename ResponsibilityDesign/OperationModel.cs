namespace byt5_6.ResponsibilityDesign;

/// <summary>
/// Model for the operation to be handled.
/// </summary>
public class OperationModel
{
    public char Operator { get; init; }
    public int Number1 { get; init; }
    public int Number2 { get; init; }
    public int Result { get; set; }
}