using CardFile.ViewModels;
using CardFile.Views;
using Microsoft.Win32;
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
    public partial class MainWindow : Window
    {
        internal MainWindowViewModel ViewModel => (MainWindowViewModel)DataContext;

        private const string FileNameFilter = "Текстовые файлы картотеки|*.crdtxt|Двоичные файлы картотеки|*.crdbin" +
            "|XML = file|*.crdxml|JSON-file|*.crdjson|zip archive|*.crdzip" + "|Все файлы|*.*";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddEmployeeWindow();
            ViewModel.CreateNewEmployee(window);
            if (window.ShowDialog() == true)
            {
                ViewModel.SaveEmployee(window);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddEmployeeWindow();
            ViewModel.EditEmployee(window);
            if (window.ShowDialog() == true)
            {
                ViewModel.SaveEmployee(window);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.DeleteSelectedItem();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.UpdateButtons();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
