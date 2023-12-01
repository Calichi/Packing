﻿namespace Packing;

//PalletCalculator
public class Calculator(/*Context.IBundle context,*/
                        Service.IPalletOperation palletOp,
                        /*Factory.IUnits unitFactory,*/
                        Factory.IContexts contextFactory,
                        Service.IConverter converter)
{
    public Context.IPack ToLabelPack(Unit.IPalletProperties palletProps) {
        var major = converter.ToLabel(palletProps).Number - 1;
        return contextFactory.NewLabelPack(2, major);
    }

    public int GetPendingBoxes(Unit.ILabel label, Context.IPack pack) =>
        palletOp.GetPendingBoxes(label, pack);

    public int GetProducedBoxes(Unit.ILabel label, Context.IPack pack) =>
        palletOp.GetProducedBoxes(label, pack);
}