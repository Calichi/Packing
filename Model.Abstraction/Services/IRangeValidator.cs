namespace Packing.Model.Abstraction.Services;

public interface IRangeValidator<T,C>
{
    bool IsValid(T value, C context);

    T Validate(T value, C context) {
        if(IsValid(value, context)) return value;
        throw BuildException(nameof(T));
    }

    ArgumentOutOfRangeException BuildException(string parameterName) =>
        new(parameterName, $"{parameterName} out of range.");
}