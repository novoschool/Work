using Calculator2.Business.Models;
using Calculator2.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Wpf.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private CalculatorService _service = new CalculatorService();

        private CalculatorModel _model = new CalculatorModel();

        public string DisplayString => _model.XRegister.ToString();

        public event PropertyChangedEventHandler PropertyChanged;

        public void PressDigit(string digitStr)
        {
            if (int.TryParse(digitStr, out var digit))
            {
                _service.AddDigit(_model, digit);
                OnPropertyChanged(nameof(DisplayString));
            }
        }

        public void Clear()
        {
            _service.Clear(_model);
            OnPropertyChanged(nameof(DisplayString));
        }

        public void PressOperator(string operatorStr)
        {
            _service.InsertOperator(_model, operatorStr);
            OnPropertyChanged(nameof(DisplayString));
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
