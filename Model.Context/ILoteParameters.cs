namespace Packing.Model.Context;

public interface ILoteParameters
{
    int PalletsByLote { get; }
    int LevelsByPallet { get; }
    int BoxesByLevel { get; }
    int BoxesByPallet => BoxesByLevel * LevelsByPallet;
}