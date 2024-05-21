using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnPractice_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = ($"CheckBox1: {chkBox1.IsChecked}\nCheckBox2 {chkBox2.IsChecked}\nRadioButton1: {radioBtn1.IsChecked}\nRadioButton2: {radioBtn2.IsChecked}");
        }

        private void btnPart2_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order(txtBoxName.Text, chkBoxOvernightDelivery.IsChecked == true, chkBoxPerishable.IsChecked == true);
            lblStatus.Content = order.ToString();
        }

        private void radioButtonBlue_Checked(object sender, RoutedEventArgs e)
        {
            gridMain.Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void radioButtonRed_Checked(object sender, RoutedEventArgs e)
        {
            gridMain.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void radioButtonGreen_Checked(object sender, RoutedEventArgs e)
        {
            gridMain.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void radioButtonYellow_Checked(object sender, RoutedEventArgs e)
        {
            gridMain.Background = new SolidColorBrush(Colors.LightGoldenrodYellow);
        }
    }
}