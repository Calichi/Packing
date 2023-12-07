namespace Packing.Pallets;

//Pallet establece directivas generales

public static class Operation
{
    public static int GetProducedBoxes(this IPallet palletProps, IParameters parameters) =>
        (palletProps.Levels * parameters.BoxesPerLevel) + palletProps.Boxes;

    public static int GetPendingBoxes(this IPallet palletProps, IParameters parameters) =>
        parameters.BoxesPerPallet - GetProducedBoxes(palletProps, parameters);
}
