namespace Packing.Model.Unit;

public class Converter(Context.IBundle context,
                       IFactory factory,
                       IPalletOperation palletOperation) : IConverter
{
    public Context.IBundle Context { get; } = context;
    public IFactory Factory { get; } = factory;
    public IPalletOperation PalletOperation { get; } = palletOperation;

    public ILabel ToLabel(IPalletProperties source) {
        var pendingBoxes = PalletOperation.GetPendingBoxes(source, Context.LoteParameters);
        return Factory.NewLabel(pendingBoxes + Context.LabelPack.Minor);
    }

    public IPalletProperties ToPalletProperties(ILabel source)
    {
        throw new NotImplementedException();
    }
}
