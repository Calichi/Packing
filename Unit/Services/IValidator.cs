namespace Packing.Unit.Service;

public interface IValidator<U,C>
{
    bool IsValid(U unit, C context);

    ArgumentOutOfRangeException BuildException(string source) =>
        new(source, $"{source} out of range!");

    U Validate(U unit, C context) {
        if(IsValid(unit, context)) return unit;
        throw BuildException(typeof(U).Name);
    }
}

public interface IValidator :
    IValidator<ILabel,Context.ILabelPack>,
    IValidator<IPalletProperties,Context.ILoteParameters>;