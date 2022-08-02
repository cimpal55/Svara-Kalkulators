using Svara_kalkulators.Core;
using Svara_kalkulators.MVVM.Model;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class CalculatorViewModel : ViewModelBase
    {
        private readonly Calculator _calculator;
        public CalculatorViewModel()
        {

        }
        public int Input
        {
            get => _calculator.Input;
            set 
            {  
                _calculator.Input = value;
                RaisePropertyChanged();

            }
        }

        public float Result 
        { 
            get => _calculator.Result; 
            set
            {
                _calculator.Result = value;
                RaisePropertyChanged();
            }
        }


        public DelegateCommand PlusMode { get; }
        public DelegateCommand MinusMode { get; }
        public DelegateCommand Calculate { get; }


    }
}

