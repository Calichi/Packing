using Packing.Model;

namespace Packing.Core;

public static class ModelConverter
{
    public static ILabel ToLabel(this IPallet pallet, IConverterParameters parameters) {
        int pendingBoxes = pallet.GetPalletPendingBoxes(parameters.Pallet);
        int minorNumber = parameters.Label.MinorNumber;
        return new Label(pendingBoxes + minorNumber);
    }

    public static ILabel GetMajorLabel(this ILabelParameters pack) =>
        new Label(pack.MajorNumber);

    public static IPallet ToPallet(this ILabel label, IConverterParameters parameters) {
        int boxes = label.GetPalletProducedBoxes(parameters.Label);
        int levels = Math.DivRem(boxes, parameters.Pallet.BoxesPerLevel, out boxes);
        return new Pallet(levels, boxes);
    }

    public static ILabelParameters ToLabelParameters(this ILabel majorLabel, ILabelParameters labelParams) =>
        new LabelParameters(labelParams.MinorNumber, majorLabel.Number);
}
