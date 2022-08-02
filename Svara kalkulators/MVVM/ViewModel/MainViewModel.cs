using Svara_kalkulators.Core;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public MainViewModel(CalculatorViewModel calculatorViewModel,
            HomeViewModel homeViewModel)
        {
            CalcVm = calculatorViewModel;
            HomeVm = homeViewModel;
            SelectedViewModel = CalcVm;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }
        public ViewModelBase SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged();
            }
        }
        public CalculatorViewModel CalcVm { get; }
        public HomeViewModel HomeVm { get; }
        public DelegateCommand SelectViewModelCommand { get; }

        private void SelectViewModel(object parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
        }
    }
}
