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

namespace BMI_Applicatie_Dialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BmiCalculatorWindow : Window
    {
        string bmiMelding = string.Empty;

        public BmiCalculatorWindow()
        {
            InitializeComponent();
        }

        private void BerekenBmiButton_Click(object sender, RoutedEventArgs e)
        {
            double lengteInM = int.Parse(this.LengteInCmTextBox.Text) / 100D;
            int gewichtInKg = int.Parse(this.GewichtInKgTextBox.Text);

            bmiMelding += Math.Round( gewichtInKg / Math.Pow(lengteInM, 2), 2);
            BmiResultaatLabel.Content = bmiMelding;
        }

        private void BMI_CalculatorForm_Loaded(object sender, RoutedEventArgs e)
        {
            var naamDialogWindow = new NaamDialogWindow();
            naamDialogWindow.Owner = this;
            bool? result = naamDialogWindow.ShowDialog();

            if (result.HasValue && result == true)
            {
                string naam = naamDialogWindow.Naam;
                if (!string.IsNullOrEmpty(naam)) 
                {
                    bmiMelding = naam + " heeft een BMI van ";            
                }
            }
        }
    }
}