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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }


        private void ChangeWindowColor(object sender, RoutedEventArgs e) {
            MenuItem menuItem = (MenuItem)sender;
            string color = menuItem.Header.ToString();

            if(color == "Синий") {
                TXTBLOCK.Background = Brushes.Blue;
            } else if(color == "Красный") {
                TXTBLOCK.Background = Brushes.Red;
            } else if(color == "Зеленый") {
                TXTBLOCK.Background = Brushes.Green;
            }

        }
        private void CloseWindow(object sender, RoutedEventArgs e) {
            this.Close();
        }
        private void Text(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}