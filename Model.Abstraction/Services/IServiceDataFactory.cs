namespace Packing.Model.Abstraction.Services;

public interface IServiceDataFactory
{
    ILabelPack NewLabelPack(int minor, int major);
    ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel);
    IContext NewContext(ILabelPack labelPack, ILoteParameters loteParameters);
    ICalculatorTools NewCalculatorTools(IModelFactory factory,
                                        IPalletOperations palletOperations);
}
