using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svara_kalkulators.Core;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class MainViewModel : Observable
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CalculatorViewCommand { get; set; }
        public CalculatorViewModel CalcVm { get; set; }
        public HomeViewModel HomeVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                NotifyPropertyChanged("CurrentView");
            }
        }
        public MainViewModel()
        {
            CalcVm = new CalculatorViewModel();
            HomeVm = new HomeViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVm; });
            CalculatorViewCommand = new RelayCommand(o => { CurrentView = CalcVm; });
        }

    }
}
