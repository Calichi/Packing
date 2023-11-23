namespace Packing.Model;

public interface ILabelPack : ILabel, ILabelContext
{
    int Length => (Major - Minor) + 1;
}
