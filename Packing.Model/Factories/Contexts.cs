namespace Packing.Factory;

public class Contexts : IContexts
{
    public Context.IPack NewLabelPack(int minor, int major) =>
        new LabelPack(minor, major);
    
    public Context.ILoteParameters NewLoteParameters(int palletsByLote,
                                                     int levelsByPallet,
                                                     int boxesByLevel) =>
        new LoteParameters(palletsByLote, levelsByPallet, boxesByLevel);

    public Context.IBundle NewBundle(Context.IPack labelPack, Context.ILoteParameters loteParameters) =>
        new Bundle(labelPack, loteParameters);
}

readonly record struct LabelPack(int Minor, int Major) : Context.IPack;
readonly record struct LoteParameters(int PalletsByLote,
                                      int LevelsByPallet,
                                      int BoxesByLevel) : Context.ILoteParameters;

readonly record struct Bundle(Context.IPack LabelPack,
                              Context.ILoteParameters LoteParameters) : Context.IBundle;
