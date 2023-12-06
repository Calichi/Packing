using Packing.Labels;
using Packing.Pallets;

namespace Packing.Convertion;

public static class Converter
{
    public static ILabel ToLabel(this IPallet pallet, IParameters parameters) {
        int pendingBoxes = pallet.GetPendingBoxes(parameters.Pallet);
        int minorNumber = parameters.Label.MinorNumber;
        return new Label(pendingBoxes + minorNumber);
    }

    public static ILabel GetMajorLabel(this IPack pack) =>
        new Label(pack.MajorNumber);

    public static IPallet ToPallet(this ILabel label, IParameters parameters) {
        int boxes = label.GetProducedBoxes(parameters.Label);
        int levels = Math.DivRem(boxes, parameters.Pallet.BoxesPerLevel, out boxes);
        return new Pallet(levels, boxes);
    }

    public static IPack ToLabelPack(this ILabel majorLabel, IPack basePack) =>
        new Pack(basePack.MinorNumber, majorLabel.Number);
}
