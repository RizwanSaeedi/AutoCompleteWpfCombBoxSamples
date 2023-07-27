using SaeediSoftWpfUiControls;

using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
                new SearchModel(){DisplayField = "Raza",StringFeild1 = "Raza"},
                new SearchModel(){DisplayField = "Farhan",StringFeild1 = "Farhan"},
                new SearchModel(){DisplayField = "Rahseed",StringFeild1 = "Rahseed"},
            };

            uc_cbox.ItemsSource = dataList;
        }

        private async void autoCompleteComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Factory.StartNew(() => { Thread.Sleep(100); });

            if (uc_cbox.comboBoxControl is not null)
            {
                // Attach Events Here -------------------------
                uc_cbox.comboBoxControl.SelectionChanged += _comboBoxControl_SelectionChanged;
                // add other events here
            }
        }

        private void _comboBoxControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var seletion = uc_cbox.comboBoxControl.SelectedItem as SearchModel;
            if (seletion is not null)
            {
                MessageBox.Show($"{seletion.DisplayField} Selected");
            }
        }

    }
}
