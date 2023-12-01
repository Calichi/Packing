namespace Packing.Factory;

public interface IContexts
{
    Context.IPack NewLabelPack(int minor, int major);
    Context.ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel);
    Context.IBundle NewBundle(Context.IPack labelPack, Context.ILoteParameters loteParameters);
}
