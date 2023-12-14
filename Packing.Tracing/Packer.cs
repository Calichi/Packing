using System.Collections.ObjectModel;
using Packing.Tracing.Model;

namespace Packing.Tracing;

public class
    Packer
        (ILot lot,
         LotProductionCompiler lotProduction)
{
    public ILot
        Lot
            { get; } = lot;

    public ObservableCollection<Packing.Model.ILabel>
        TracingLabels
            { get; } = [];

    public int
        CurrentLabelNumber
            { get; set; } = lot.BeginLabel.Number;

    public Packing.Model.ILabel
        CurrentLabel =>
            new Label(CurrentLabelNumber);

    public bool
        AreThereNotTracingLabels =>
            TracingLabels.Count == 0;

    public bool
        HasCurrentLabelNotBeenSavedYet =>
            AreThereNotTracingLabels ||
            TracingLabels.Last().Number != CurrentLabelNumber;

    public bool
        CanCurrentLabelBeAdded =>
            CurrentLabelNumber != 0 &&
            HasCurrentLabelNotBeenSavedYet;

    public int LotBoxesProduced =>
        lotProduction.Compute(this).Result;
        
    public void SaveCurrentLabel() {
        if(HasCurrentLabelNotBeenSavedYet)
            TracingLabels.Add(CurrentLabel);
    }

}