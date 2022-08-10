using System;

namespace Svara_kalkulators.MVVM.Model
{
    public class Calculator
    {
        public string? Barcode { get; set; }
        public float Weight { get; set; }
        public DateTime DateTime { get; set; }
        public string? Input { get; set; }
        public float Result { get; set; }

    }
}
