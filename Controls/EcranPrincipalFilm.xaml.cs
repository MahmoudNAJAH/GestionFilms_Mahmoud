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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Page2.xaml
    /// </summary>
    public partial class EcranPrincipalFilm : Page
    {
        public EcranPrincipalFilm()
        {
            InitializeComponent();
        }
        // Bouton ajouter un producteur
        private void Lire_XML_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            

            XmlDocument monfichier = new XmlDocument();
            XmlTextReader monfichier = new XmlTextReader("XMLFile1.xml");
            monfichier.Load("XMLFile1.xml");
            XmlNodeList lst = monfichier.GetElementsByTagName("films");
            MessageBox.Show("ouverture de mon fichier xml effectuée");
            foreach (XmlNode n in lst)
            {
                ListBox.Items.add(n.Attributes[0].Value);
            }
        }
    }
}
