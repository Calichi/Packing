namespace Packing.Model.Context;

public interface IBundle
{
    ILabelPack LabelPack { get; }
    ILoteParameters LoteParameters { get; }
}