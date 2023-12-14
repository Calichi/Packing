using Packing.Core;
using Packing.Model;

namespace Packing.Tracing;

public static class PackerHelper
{
    public static Model.ILabelPack GetPendingLabels
        (this Model.IPallet pallet,
              Model.ILotParameters loteParams) =>
            new Model.LabelPack(pallet.Number,
                                loteParams.Label.MinorNumber,
                                pallet.ToLabel(loteParams).Number - 1);

    public static Model.ILabelPack NewPack
        (this ILabelParameters labelParams, int number) =>
            new Model.LabelPack(number,
                                labelParams.MinorNumber,
                                labelParams.MajorNumber);
}
