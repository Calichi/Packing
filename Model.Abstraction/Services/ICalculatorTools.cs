namespace Packing.Model.Abstraction.Services;

public interface ICalculatorTools
{
    IFactory Factory { get; }
    IPalletOperations PalletOperation { get; }
    IValidators Validator { get; }
}
