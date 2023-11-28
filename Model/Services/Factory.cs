namespace Packing.Model;

public class Factory : IFactory
{
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
