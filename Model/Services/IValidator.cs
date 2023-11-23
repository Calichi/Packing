namespace Packing.Model.Services;

public interface IValidator<T>
{
    T Validate(T value);
}