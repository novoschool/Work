using Calculator.Wpf.CalculatorServiceReference;
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
        private ICalculatorService _service = new CalculatorServiceClient();

        private CalculatorServiceModel _model = new CalculatorServiceModel();

        public string DisplayString => _model.XRegister.ToString();

        public event PropertyChangedEventHandler PropertyChanged;

        public void PressDigit(string digitStr)
        {
            if (int.TryParse(digitStr, out var digit))
            {
                _model = _service.AddDigit(_model, digit);
                OnPropertyChanged(nameof(DisplayString));
            }
        }

        public void Clear()
        {
            _model = _service.Clear(_model);
            OnPropertyChanged(nameof(DisplayString));
        }

        public void PressOperator(string operatorStr)
        {
            _model = _service.InsertOperator(_model, operatorStr);
            OnPropertyChanged(nameof(DisplayString));
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
