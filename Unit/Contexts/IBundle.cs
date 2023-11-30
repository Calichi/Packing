namespace Packing.Unit.Context;

public interface IBundle
{
    ILabelPack LabelPack { get; }
    ILoteParameters LoteParameters { get; }
}