using System.Collections.ObjectModel;
using Packing.Tracing.Model;

namespace Packing.Tracing;

public class Lot : ILot
{
    public ILotParameters
        Parameters { get; }

    public ObservableCollection<ILabelPack>
        LabelScheduling { get; } = [];

    public Lot (ILotParameters parameters,
                IPallet beginPallet,
                Packing.Model.ILabel endPallet)
    {
        Parameters = parameters;
        InitializeLabelScheduling(beginPallet, endPallet);
    }

    void InitializeLabelScheduling (IPallet beginPallet,
                                    Packing.Model.ILabel endPallet) {
        LabelScheduling.Add(beginPallet.GetPendingLabels(Parameters));
        for(int number = beginPallet.Number + 1;
                number < endPallet.Number + 1;
                number++)
            LabelScheduling.Add(Parameters.Label.NewPack(number));
    }
}