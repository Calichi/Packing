namespace Packing.Model.Services;

public class ModelFactory(IContext context, IValidators validators) : IModelFactory
{
    public IContext Context { get; } = context;
    public IValidators Validator { get; } = validators;

    public ILabel NewLabel(int number) =>
        Validator.Validate(new Label(number), Context.LabelPack);

    public IPalletProperties NewPalletProperties(int levels, int boxes) =>
        Validator.Validate(new PalletProperties(levels, boxes), Context.LoteParameters);
    
    // public IPallet NewPallet(int number, int levels, int boxes) =>
    //     new Pallet(number, levels, boxes);
}
