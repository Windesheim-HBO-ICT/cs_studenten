using System.Collections.ObjectModel;
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

namespace MeldJeAan_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Persoon> personen;

        public MainWindow()
        {
            InitializeComponent();

            personen = new ObservableCollection<Persoon>();  this.PeopleListView.ItemsSource = personen;

        }


        private void MeldMeerderePersonenAanButton_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new NaamWindowModeless();
            dlg.Owner = this;
            dlg.NaamToevoegEvent += NaamToevoeg_EventHandler;
            dlg.ShowDialog();
            dlg.NaamToevoegEvent -= NaamToevoeg_EventHandler;
            dlg.Close();
        }

        private void NaamToevoeg_EventHandler(object sender, NaamEventArgs e)
        {
            personen.Add(new Persoon { Naam = e.Naam });
        }

        private void MeldEenPersoonAanButton_Click(object sender, RoutedEventArgs e)
        {
            //zie vergelijkbare oplossing BMI_Applicatie _Dialog
            throw new NotImplementedException();
        }
    }
}