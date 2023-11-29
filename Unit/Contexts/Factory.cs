namespace Packing.Unit.Context;

public class Factory
{
    public ILabelPack NewLabelPack(int minor, int major) =>
        new LabelPack(minor, major);
    
    public ILoteParameters NewLoteParameters(int palletsByLote,
                                             int levelsByPallet,
                                             int boxesByLevel) =>
        new LoteParameters(palletsByLote, levelsByPallet, boxesByLevel);

    public IBundle NewBundle(ILabelPack labelPack, ILoteParameters loteParameters) =>
        new Bundle(labelPack, loteParameters);
}

readonly record struct LabelPack(int Minor, int Major) : ILabelPack;
readonly record struct LoteParameters(int PalletsByLote,
                                      int LevelsByPallet,
                                      int BoxesByLevel) : ILoteParameters;

readonly record struct Bundle(ILabelPack LabelPack, ILoteParameters LoteParameters) : IBundle;