namespace Packing.Model;

public interface IProductionReport
{
    int ProducedBoxes { get; }
    int PendingBoxes { get; }
}
