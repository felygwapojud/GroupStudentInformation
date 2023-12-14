using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GroupStudentInformation.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        // Event handler for when the text in the username TextBox changes
        private void txtCreateUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            // wala pa
        }

        // Event handler for when the 'Create Account' button is clicked
        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            // wala pa
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           
            Window parentWindow = Window.GetWindow(this);
            parentWindow?.Close();
        }
    }
}