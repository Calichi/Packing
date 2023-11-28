
namespace Packing.Model.Services;

public class ServiceDataFactory : IServiceDataFactory
{
    public ICalculatorTools NewCalculatorTools(IModelFactory factory,
                                               IPalletOperations palletOperations) =>
        new CalculatorTools(factory, palletOperations);

    public IContext NewContext(ILabelPack labelPack, ILoteParameters loteParameters) =>
        new Context(labelPack, loteParameters);

    public ILabelPack NewLabelPack(int minor, int major) =>
        new LabelPack(minor, major);

    public ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel) =>
        new LoteParameters(palletsByLote, levelsByPallet, boxesByLevel);
}
