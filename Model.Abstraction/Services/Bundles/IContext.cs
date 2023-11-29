namespace Packing.Model.Abstraction.Services;

public interface IContext
{
    ILabelPack LabelPack { get; }
    ILoteParameters LoteParameters { get; }
}
