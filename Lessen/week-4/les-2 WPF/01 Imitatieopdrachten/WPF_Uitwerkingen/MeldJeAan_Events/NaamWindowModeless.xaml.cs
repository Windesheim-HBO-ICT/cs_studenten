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

namespace MeldJeAan_Events
{
    /// <summary>
    /// Interaction logic for NaamWindowModeless.xaml
    /// </summary>
    public partial class NaamWindowModeless : Window
    {
        public event NaamDelegate? NaamToevoegEvent;

        public NaamWindowModeless()
        {
            InitializeComponent();
        }

        private void VoegToeButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NaamTextBox.Text)) 
            {
                OnNaamToevoeg();            
            }
        }
        protected virtual void OnNaamToevoeg()
        {
            if (NaamToevoegEvent is not null) 
            {
                NaamToevoegEvent(this, new NaamEventArgs(NaamTextBox.Text));
            }
        }
    }
}
