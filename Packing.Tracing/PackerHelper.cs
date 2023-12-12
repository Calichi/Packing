using Packing.Core;

namespace Packing.Tracing;

public static class PackerHelper
{
    public static ILabelPack ToLabelPack(this IPallet pallet, ILoteParameters loteParams) =>
        new LabelPack(pallet.Number, loteParams.Label.MinorNumber, pallet.ToLabel(loteParams).Number);

    public static ILabelPack NewPack(this Model.ILabelParameters labelParams, int number) =>
        new LabelPack(number, labelParams.MinorNumber, labelParams.MajorNumber);
}
