namespace Packing.Labels;

public static class Validation
{
    public static bool IsValid(this ILabel label, IPack pack) =>
        pack.MinorNumber <= label.Number &&
        label.Number <= pack.MajorNumber; 
}
