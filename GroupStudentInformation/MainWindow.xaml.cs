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
using System.Collections.ObjectModel;
using System.ComponentModel;
using GroupStudentInformation.Views;

namespace GroupStudentInformation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToView(UserControl view)
        {
            Content = view;
        }

        private void btnCreateAcc_Click(object sender, RoutedEventArgs e)
        {
            NavigateToView(new CreateAccount());
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigateToView(new Login());
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            NavigateToView(new Reset());
        }

        private void btnEntryClick(object sender, RoutedEventArgs e)
        {
                //placeholder//
        }
        private void btnGroupClick(object sender, RoutedEventArgs e)
        {
            //placeholder//
        }


        // Define other event handlers similarly...

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
