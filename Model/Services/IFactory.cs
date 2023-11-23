namespace Packing.Model.Services;

public interface IFactory
{
    ILabel BuildLabel(int number);
    IPalletProperties BuildPalletProperties(int levels, int boxes);
    ILabelContext BuildLabelContext(int minor, int major);
    ILoteContext BuildLoteContext(int palletsByLote, int levelsByPallet, int boxesByLevel);
    ILabelPack BuildLabelPack(int number, int minor, int major);
    IPallet BuildPallet(int number, int levels, int boxes);
}
