namespace Packing.Pallet;

//Pallet establece directivas generales

public static class Operation
{
    public static int GetProducedBoxes(this IProperties palletProps, IParameters parameters) =>
        (palletProps.Levels * parameters.BoxesPerLevel) + palletProps.Boxes;

    public static int GetPendingBoxes(this IProperties palletProps, IParameters parameters) =>
        parameters.BoxesPerPallet - GetProducedBoxes(palletProps, parameters);
}
