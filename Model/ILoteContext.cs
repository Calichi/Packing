namespace Packing.Model;

public interface ILoteContext
{
    int PalletsByLote { get; }
    int LevelsByPallet { get; }
    int BoxesByLevel { get; }
    int BoxesByPallet => BoxesByLevel * LevelsByPallet;
}
