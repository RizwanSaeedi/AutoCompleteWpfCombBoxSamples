using SaeediSoftWpfUiControls;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SimpleAutoCompleteCombBoxSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ObservableCollection<SearchModel> dataList = new ObservableCollection<SearchModel>
                {
                    new SearchModel(){DisplayField = "Item 1",StringFeild1 = "Ali"},
                    new SearchModel(){DisplayField = "Item 2",StringFeild1 = "Frahan"},
                    new SearchModel(){DisplayField = "Item 3",StringFeild1 = "Raza"},
                };

            autoCompleteComboBox.ItemsSource = dataList;
        }
    }
}
