using CardFile.ViewModels;
using CardFile.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CardFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal MainWindowViewModel ViewModel => (MainWindowViewModel)DataContext;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddAnimalWindow();
            ViewModel.CreateNewAnimal(window);
            if (window.ShowDialog() == true)
            {
                ViewModel.SaveAnimal(window);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddAnimalWindow();
            ViewModel.EditAnimal(window);
            if (window.ShowDialog() == true)
            {
                ViewModel.SaveAnimal(window);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.UpdateButtons();
        }
    }
}
