using System.Collections.ObjectModel;

namespace Packing.Tracing.Model;

public interface ILot
{
    ILotParameters
        Parameters { get; }

    ObservableCollection<ILabelPack>
        LabelScheduling { get; }

    int
        ScheduledProduction =>
            LabelScheduling.Sum(pack => pack.LabelsAmount);

    ILabelPack
        BeginLabelPack =>
            LabelScheduling.First();

    Packing.Model.ILabel
        BeginLabel =>
            new Label(BeginLabelPack.MajorNumber + 1);

    
}
