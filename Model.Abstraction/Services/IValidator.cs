namespace Packing.Model.Abstraction.Services;

public interface IValidator<T>
{
    T Validate(T value);
}
