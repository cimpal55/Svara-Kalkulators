using Svara_kalkulators.Core;
using Svara_kalkulators.MVVM.Model;
using System;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class CalculatorViewModel : ValidationViewModelBase
    {
        private readonly Calculator _model;

        private Mode _mode;
        public CalculatorViewModel(Calculator model)
        {
            ModeSwitchCommand = new DelegateCommand(ModeSwitch);
            CalculateCommand = new DelegateCommand(Calculate);
            _model = model;
        }
        public Mode Mode
        {
            get => _mode;
            set 
            { 
                _mode = value;
                RaisePropertyChanged();
            }
        }

        public string? Input
        {
            get => _model.Input;
            set 
            {
                _model.Input = value;
                if (_model.Input.Length != 12)
                    AddError("Barcode is incorrect. It should consist of 12 numbers.");
                else
                    ClearErrors();
                RaisePropertyChanged();
            }
        }
        
        public string InputFirstChars
        {
            get => _model.InputFirstChars;
            set
            {
                _model.InputFirstChars = _model.Input.Substring(0, 2);
                RaisePropertyChanged();
            }

        }

        public DelegateCommand ModeSwitchCommand { get; }
        public DelegateCommand CalculateCommand { get; }

        private void ModeSwitch(object? parameter)
        {
            if (parameter != null)
            {
                Mode = (Mode)parameter;
            }
        }
        private void Calculate(object? parameter)
        {
            throw new NotImplementedException();
        }

    }

    public enum Mode
    {
        Plus,
        Minus
    }
}

