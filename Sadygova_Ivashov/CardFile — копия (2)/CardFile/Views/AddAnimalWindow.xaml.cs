using CardFile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CardFile.Views
{
    /// <summary>
    /// Interaction logic for AddAnimalWindow.xaml
    /// </summary>
    public partial class AddAnimalWindow : Window, IAnimalWindow
    {
        public AnimalViewModel ViewModel
        {
            get => (AnimalViewModel)DataContext;
            set => DataContext = value;
        }

        public AddAnimalWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
