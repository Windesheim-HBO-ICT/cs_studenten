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

namespace ASimpleWindow
{
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        private Person person;

        public PersonWindow()
        {
            InitializeComponent();

            #region extra binding info
            //Omdat de Person in de designer is gebonden, kan deze ook via de BindingContext uitgelezen worden.
            //Person p = (Person)NameTextBox.DataContext;
            //Een DataContext kan ook op het Grid ingesteld worden, dat is handig wanneer er meerdere formuliervelden in het Grid het dezelfde object gebonden moeten worden.
            //Ook properties zoals de breedte of achtergrondkleur van een UI element kunnen gebonden worden.
            #endregion

            person = new Person();
            NameTextBox.DataContext = person;
        }

        private void PersonButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Variable/object person, property Name: {person.Name}");
        }

        private void AlterNameButton_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "altered..";
        }
    }
}
