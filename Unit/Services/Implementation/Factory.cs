namespace Packing.Unit;

public class Factory(Context.IBundle context, Validation.IValidator validator) : IFactory
{
    public Context.IBundle Context { get; } = context;

    public Validation.IValidator Validator { get; } = validator;

    public ILabel NewLabel(int number) =>
        Validator.Validate(new Label(number), Context.LabelPack);

    public IPalletProperties NewPalletProperties(int levels, int boxes) =>
        Validator.Validate(new PalletProperties(levels, boxes), Context.LoteParameters);
}

readonly record struct Label(int Number) : ILabel;
readonly record struct PalletProperties(int Levels, int Boxes) : IPalletProperties;
