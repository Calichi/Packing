namespace Packing.Labels;

public static class Operation
{
    public static int GetPendingBoxes(this ILabel label, IPack pack) =>
        label.Number - pack.MinorNumber;

    public static int GetProducedBoxes(this ILabel label, IPack pack) =>
        pack.LabelsAmount - GetPendingBoxes(label, pack);
}
