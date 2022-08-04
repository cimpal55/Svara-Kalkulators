using Svara_kalkulators.Core;
using Svara_kalkulators.MVVM.Model;
using System;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class CalculatorViewModel : ValidationViewModelBase
    {
        private Mode _mode;
        public CalculatorViewModel()
        {
            ModeSwitchCommand = new DelegateCommand(ModeSwitch);
            CalculateCommand = new DelegateCommand(Calculate);
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

        public DelegateCommand ModeSwitchCommand { get; }
        public DelegateCommand CalculateCommand { get; }

        private void ModeSwitch(object? parameter)
        {
            string value = Convert.ToString(parameter);
            if ((string)parameter == "Plus")
            {

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

