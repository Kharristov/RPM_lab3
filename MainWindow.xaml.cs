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

namespace lab3 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ChangeWindowColor(object sender, RoutedEventArgs e) {
            MenuItem menuItem = (MenuItem)sender;
            string color = menuItem.Header.ToString();

            if(color == "Песочный") {
                MainGrid.Background = Brushes.Tan;
            } else if(color == "Светлый") {
                MainGrid.Background = Brushes.PapayaWhip;
            } else if(color == "Серый") {
                MainGrid.Background = Brushes.LightGray;
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Вахрушева Анна", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information); 
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if(sender is FrameworkElement el)
            {
                StText.Text = el.Tag.ToString();
            }
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            StText.Text = ""; 
        }

        private void ChageWndColorTan(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = Brushes.Tan;
        }

        private void ChageWndColorPapayaWhip(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = Brushes.PapayaWhip;
        }

        private void PapayaLightGray(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = Brushes.LightGray;
        }

    }
}