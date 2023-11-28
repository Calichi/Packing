namespace Packing.Model.Abstraction.Services;

public interface ICalculatorTools
{
    IModelFactory Factory { get; }
    IPalletOperations PalletOperation { get; }
}
