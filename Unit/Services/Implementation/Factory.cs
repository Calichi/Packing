namespace Packing.Unit.Service;

public class Factory(Context.IBundle context, IValidator validator) : IFactory
{
    public Context.IBundle Context { get; } = context;

    public IValidator Validator { get; } = validator;

    public ILabel NewLabel(int number) =>
        Validator.Validate(new Label(number), Context.LabelPack);

    public IPalletProperties NewPalletProperties(int levels, int boxes) =>
        Validator.Validate(new PalletProperties(levels, boxes), Context.LoteParameters);
}

readonly record struct Label(int Number) : ILabel;
readonly record struct PalletProperties(int Levels, int Boxes) : IPalletProperties;
