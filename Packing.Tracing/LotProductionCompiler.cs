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

    bool HasTheTourBeenCompletedYet =>
        _labelIndex == _packer?.TracingLabels.Count;

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
    

    void Initialize(Packer packer) {
        _packer = packer;
        _labelIndex = 0;
        _labelPackIndex = 0;
        _previousLabel = _packer.Lot.BeginLabel;
        Result = 0;
    }
    
    public LotProductionCompiler Compute(Packer packer) {
        Initialize(packer);
        ContinuousSum();
        AddCurrentLabel();
        return this;
    }

    void AddCurrentLabel(){
        if (_packer.CanCurrentLabelBeAdded)
            Add(_packer.CurrentLabel);
    }

    void ContinuousSum () {
        if(!HasTheTourBeenCompletedYet) {
            Add(PopLabel());
            ContinuousSum();
        }
    }

    void Add (Packing.Model.ILabel label) {
        _currentLabel = label;
        Result += GetBoxesProduced();
        _previousLabel = PopPreviousLabel();
    }

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

    Packing.Model.ILabel PopLabel() =>
        _packer.TracingLabels[_labelIndex++];

    Packing.Model.ILabel PopPreviousLabel() =>
        _packer.AreThereNotTracingLabels
            ? _packer.Lot.BeginLabel 
            : _packer.TracingLabels[_labelIndex - 1];

}