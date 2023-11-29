namespace Packing.Model.Context;

public class FactoryService
{
    public ILabelPack NewLabelPack(int minor, int major) =>
        new LabelPack(minor, major);
    
    public ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel) =>
        new LoteParameters(palletsByLote, levelsByPallet, boxesByLevel);

    public IBundle NewBundle(ILabelPack labelPack, ILoteParameters loteParameters) =>
        new Bundle(labelPack, loteParameters);
}

record LabelPack(int Minor, int Major) : ILabelPack;
record LoteParameters(int PalletsByLote, int LevelsByPallet, int BoxesByLevel) : ILoteParameters;
record Bundle(ILabelPack LabelPack, ILoteParameters LoteParameters) : IBundle;
