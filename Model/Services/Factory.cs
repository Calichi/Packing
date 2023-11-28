namespace Packing.Model.Services;

public class Factory : IFactory
{
    public ICalculatorTools NewCalculatorTools(IFactory factory,
                                               IPalletOperations palletOperations,
                                               IValidators validators) =>
        new CalculatorTools(factory, palletOperations, validators);

    public IContext NewContext(ILabelPack labelPack, ILoteParameters loteParameters) =>
        new Context(labelPack, loteParameters);

    public ILabel NewLabel(int number) =>
        new Label(number);

    public ILabelPack NewLabelPack(int minor, int major) =>
        new LabelPack(minor, major);

    public ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel) =>
        new LoteParameters(palletsByLote, levelsByPallet, boxesByLevel);

    public IPallet NewPallet(int number, int levels, int boxes) =>
        new Pallet(number, levels, boxes);

    public IPalletProperties NewPalletProperties(int levels, int boxes) =>
        new PalletProperties(levels, boxes);
}
