using Svara_kalkulators.Core;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public MainViewModel(CalculatorViewModel calculatorViewModel,
            HomeViewModel homeViewModel)
        {
            CalculatorViewModel = calculatorViewModel;
            HomeViewModel = homeViewModel;
            SelectedViewModel = CalculatorViewModel;
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
        public CalculatorViewModel CalculatorViewModel { get; }
        public HomeViewModel HomeViewModel { get; }
        public DelegateCommand SelectViewModelCommand { get; }

        private void SelectViewModel(object parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
        }
    }
}
