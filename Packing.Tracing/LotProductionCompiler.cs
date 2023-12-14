using Packing.Core;
using Packing.Tracing.Model;

namespace Packing.Tracing;

public class LotProductionCompiler
{
    int _labelIndex = 0; 
    int _labelPackIndex = 0;
    Packing.Model.ILabel? _previousLabel;
    Packing.Model.ILabel? _currentLabel;
    Packer? _packer;

    public int Result { get; private set; } = 0;

    bool HasNotTheTourConcluded =>
        _labelIndex < _packer?.TracingLabels.Count;

    bool HasThePalletChanged =>
        _currentLabel?.Number > _previousLabel?.Number;

    ILabelPack CurrentLabelPack =>
        _packer.Lot.LabelScheduling[_labelPackIndex];

    ILabelPack PreviousLabelPack =>
        _packer.Lot.LabelScheduling[_labelPackIndex - 1];

    int PreviousPalletPendingBoxes =>
        _previousLabel.GetPalletPendingBoxes(PreviousLabelPack);

    int CurrentPalletProducedBoxes =>
        _currentLabel.GetPalletProducedBoxes(CurrentLabelPack);

    Packing.Model.ILabel NextLabel =>
        _packer.TracingLabels[_labelIndex++];

    Packing.Model.ILabel LastTracingLabelOrDefault =>
        _packer.AreThereNotTracingLabels
            ? _packer.Lot.BeginLabel 
            : _packer.TracingLabels.Last();
    
    int GetBoxesProduced () {
        if (HasThePalletChanged) {
            _labelPackIndex++;
            return
                PreviousPalletPendingBoxes +
                CurrentPalletProducedBoxes;
        }
        else {
            return
                _previousLabel.Number -
                _currentLabel.Number;
        }
    }

    void Add (Packing.Model.ILabel label) {
        _currentLabel = label;
        Result += GetBoxesProduced();
        _previousLabel = label;
    }


    void Initialize(Packer packer) {
        _packer = packer;
        _labelIndex = 0;
        _labelPackIndex = 0;
        _previousLabel = _packer.Lot.BeginLabel;
        Result = 0;
    }

    void ContinuousSum () {
        if(HasNotTheTourConcluded) {
            Add(NextLabel);
            ContinuousSum();
        }
    }
    
    void AddCurrentLabel(){
        if (_packer.CanCurrentLabelBeAdded) {
            _currentLabel = _packer.CurrentLabel;
            Result += GetBoxesProduced();
            _previousLabel = LastTracingLabelOrDefault;
        }
    }

    public LotProductionCompiler Compute(Packer packer) {
        Initialize(packer);
        ContinuousSum();
        AddCurrentLabel();
        return this;
    }

}