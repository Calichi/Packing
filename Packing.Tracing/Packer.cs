using System.Collections.ObjectModel;

namespace Packing.Tracing;

public class Packer
{
    public Packer(ILoteParameters loteParams, IPallet beginPallet, ILabel endPallet) {
        LoteParameters = loteParams;

        // Make Scheduling
        Scheduling.Add(beginPallet.ToLabelPack(loteParams));
        for(int number = beginPallet.Number; number < endPallet.Number + 1; number++)
            Scheduling.Add(loteParams.Label.NewPack(number));
    }

    public ILoteParameters LoteParameters { get; }
    public ObservableCollection<ILabelPack> Scheduling { get; } = [];
    public ObservableCollection<ILabel> Tracing { get; } = [];
}
