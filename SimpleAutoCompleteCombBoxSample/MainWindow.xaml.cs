using SaeediSoftWpfUiControls;

using System.Collections.ObjectModel;
using System.Windows;

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
                new SearchModel(){DisplayField = "Ali",StringFeild1 = "Ali"},
                new SearchModel(){DisplayField = "Frahan",StringFeild1 = "Frahan"},
                new SearchModel(){DisplayField = "Raza",StringFeild1 = "Raza"},
            };

            autoCompleteComboBox.ItemsSource = dataList;
        }
    }
}
