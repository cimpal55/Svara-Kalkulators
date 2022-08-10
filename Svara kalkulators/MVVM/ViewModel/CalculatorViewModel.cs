using Svara_kalkulators.Core;
using Svara_kalkulators.MVVM.Model;
using System;
using System.Threading;
using System.Windows.Controls;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class CalculatorViewModel : ValidationViewModelBase
    {
        private readonly Calculator _model;

        private Mode _mode;

        private int _numbersToDegree;

        public CalculatorViewModel(Calculator model)
        {
            ModeSwitchCommand = new DelegateCommand(ModeSwitch);
            CalculateCommand = new DelegateCommand(Calculate);
            ResetResultCommand = new DelegateCommand(ResetResult);
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

        public int NumberToDegree
        {
            get => _numbersToDegree;
            set
            {
                _numbersToDegree = value;
                RaisePropertyChanged();
            }
        }
        public string? Input
        {
            get => _model.Input;
            set
            {
                _model.Input = value;
                if (_model.Input.Length == 12)
                {
                    if (InputFirstChars == "23" || InputFirstChars == "24" || InputFirstChars == "25")
                        ClearErrors();
                    else
                        AddError("Barcode should begin from 25, 24 or 23.");
                }
                else
                {
                    AddError("Barcode should contain 12 numbers.");
                }
                RaisePropertyChanged();
            }
        }
        
        public float Weight
        {
            get => _model.Weight;
            set
            {
                _model.Weight = value;
                RaisePropertyChanged();
            }
        }
        public float Result
        {
            get => _model.Result;
            set 
            { 
                _model.Result = value;
                if (_model.Result < 0)
                    _model.Result = 0;
                RaisePropertyChanged();
            }
        }
        public string InputFirstChars => Input.Substring(0, 2);

        public DelegateCommand ModeSwitchCommand { get; }
        public DelegateCommand CalculateCommand { get; }
        public DelegateCommand ResetResultCommand { get; }

        private void ModeSwitch(object? parameter)
        {
            if (parameter != null)
            {
                Mode = (Mode)parameter;
            }
        }
        private void Calculate(object? parameter)
        {
            Weight = float.Parse(Input.Substring(8));

            switch (InputFirstChars)
            {
                case "23":
                    _numbersToDegree = 1000;
                    break;
                case "24":
                    _numbersToDegree = 100;
                    break;
                case "25":
                    _numbersToDegree = 10;
                    break;
            }

            switch (Mode)
            {
                case Mode.Plus:
                    Result += Weight / NumberToDegree; 
                    break;
                case Mode.Minus:
                    Result -= Weight / NumberToDegree;
                    break;
            }
        }

        private void ResetResult(object? parameter)
        {
            Result = 0;
        }

    }

    public enum Mode
    {
        Plus,
        Minus
    }
}

