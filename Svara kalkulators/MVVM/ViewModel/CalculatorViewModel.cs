using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Svara_kalkulators.Core;

namespace Svara_kalkulators.MVVM.ViewModel
{
    class CalculatorViewModel : Observable
    {
        private string _myText;
        public string MyText
        {
            get { return _myText; }
            set
            {
                _myText = value;
                NotifyPropertyChanged("MyText");
            }
        }

    }
}

