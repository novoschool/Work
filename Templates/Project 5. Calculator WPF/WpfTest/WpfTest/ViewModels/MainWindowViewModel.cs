using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string InputName { get; set; }

        public string HelloMessage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GetHelloMessage()
        {
            if (string.IsNullOrEmpty(InputName))
            {
                HelloMessage = "Здравствуй, незнакомец";
            }
            else
            {
                HelloMessage = $"Здравствуй, {InputName}!";
            }

            OnPropertyChanged(nameof(HelloMessage));
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
