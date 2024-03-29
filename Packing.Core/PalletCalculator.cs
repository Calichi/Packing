﻿using Packing.Model;

namespace Packing.Core;

public static class PalletCalculator
{
    public static int GetPalletProducedBoxes(this IPallet palletProps, IPalletParameters palletParams) =>
        (palletProps.Levels * palletParams.BoxesPerLevel) + palletProps.Boxes;

    public static int GetPalletPendingBoxes(this IPallet palletProps, IPalletParameters palletParams) =>
        palletParams.BoxesPerPallet - GetPalletProducedBoxes(palletProps, palletParams);

    public static int GetPalletPendingBoxes(this ILabel label, ILabelParameters labelParams) =>
        label.Number - labelParams.MinorNumber;

    public static int GetPalletProducedBoxes(this ILabel label, ILabelParameters labelParams) =>
        labelParams.LabelsAmount - GetPalletPendingBoxes(label, labelParams);

    public static IBoxes GetPalletProductionReport(this ILabel label, ILabelParameters labelParams) =>
        new Boxes(label.GetPalletProducedBoxes(labelParams),
                             label.GetPalletPendingBoxes(labelParams));
}
