namespace Packing.Model.Abstraction.Services;

public interface IFactory
{
    ILabel NewLabel(int number);
    IPalletProperties NewPalletProperties(int levels, int boxes);
    ILabelPack NewLabelPack(int minor, int major);
    IPallet NewPallet(int number, int levels, int boxes);
    ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel);
}
