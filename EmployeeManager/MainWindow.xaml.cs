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

namespace EmployeeManager
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

        private void ShowTextButton_Click(object sender, RoutedEventArgs e)
        {
            
            string name = Name.Text;
            string age = Age.Text;
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(age))
            {
                try
                {
                    int a = Int32.Parse(age);
                    MessageBox.Show($"Name: {name}, Age: {a}");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Please enter a number: {ex.Message}");
                }
            }
        }
    }
}