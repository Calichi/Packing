namespace Packing.Factory;

class Units(Context.IBundle context, UnitValidation.IValidator validator) : IUnits
{
    public Context.IBundle Context { get; } = context;

    public UnitValidation.IValidator Validator { get; } = validator;

    public Unit.ILabel NewLabel(int number) =>
        Validator.Validate(new Label(number), Context.LabelPack);

    public Unit.IPalletProperties NewPalletProperties(int levels, int boxes) =>
        Validator.Validate(new PalletProperties(levels, boxes), Context.LoteParameters);
}

readonly record struct Label(int Number) : Unit.ILabel;
readonly record struct PalletProperties(int Levels, int Boxes) : Unit.IPalletProperties;
