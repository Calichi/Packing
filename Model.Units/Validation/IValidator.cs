namespace Packing.Model.Units.Validation;

public interface IValidator<T,C>
{
    bool IsValid(T value, C context);

    T Validate(T value, C context) {
        if(IsValid(value, context)) return value;
        throw BuildException(nameof(T));
    }

    ArgumentOutOfRangeException BuildException(string source) =>
        new(source, $"{source} out of range!");
}
