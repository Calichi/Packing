namespace Packing.Context;

public interface IBundle
{
    IPack LabelPack { get; }
    ILoteParameters LoteParameters { get; }
}