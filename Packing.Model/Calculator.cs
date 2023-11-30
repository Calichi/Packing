namespace Packing;

public class Calculator(Context.IBundle context,
                        Service.IPalletOperation palletOp,
                        Factory.IUnits unitFactory,
                        Factory.IContexts contextFactory,
                        Service.IConverter converter)
{
    public Context.ILabelPack ToLabelPack(Unit.IPalletProperties palletProps) {
        var major = converter.ToLabel(palletProps).Number - 1;
        return contextFactory.NewLabelPack(2, major);
    }
}
