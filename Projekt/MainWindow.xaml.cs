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

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Czarny.Checked += KolorTekstu;
            Czerwony.Checked += KolorTekstu;
            Zielony.Checked += KolorTekstu;
            Slider.ValueChanged += GruboscTekstu;
            Pogrubienie.Checked += StylTekstu;
            Pogrubienie.Unchecked += StylTekstu;
            Kursywa.Checked += StylTekstu;
            Kursywa.Unchecked += StylTekstu;
            Podkreslenie.Checked += StylTekstu;
            Podkreslenie.Unchecked += StylTekstu;

        }
        private void KolorTekstu(object sender, RoutedEventArgs e) 
        {
            if (Czarny.IsChecked == true)
            {
                TextBox.Foreground = Brushes.Black;
            }
            else if (Czerwony.IsChecked == true)
            {
                TextBox.Foreground = Brushes.Red;
            }
            else if(Zielony.IsChecked == true) 
            {
                TextBox.Foreground= Brushes.Green;
            }

        }
        private void GruboscTekstu(object sender, RoutedPropertyChangedEventArgs<double> e) 
        {
            TextBox.FontSize = Slider.Value + 1;
        }
        private void StylTekstu( object sender, RoutedEventArgs e) 
        {

        }
    }
    
}