using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BMI_Applicatie_Dialog
{
    /// <summary>
    /// Interaction logic for NaamDialogWindow.xaml
    /// </summary>
    public partial class NaamDialogWindow : Window
    {
        public NaamDialogWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        public string Naam { get { return NaamTextBox.Text; } }
    }
}
