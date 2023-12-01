namespace Packing.Factory;

public interface IContexts
{
    Context.ILabelPack NewLabelPack(int number, int minor, int major);
    Context.ILoteParameters NewLoteParameters(int palletsByLote, int levelsByPallet, int boxesByLevel);
    Context.IBundle NewBundle(Context.ILabelPack labelPack, Context.ILoteParameters loteParameters);
}
