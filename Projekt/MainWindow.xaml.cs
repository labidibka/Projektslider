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
            zolty.Checked += KolorTla;
            Bialo.Checked += KolorTla;
            Niebieski.Checked += KolorTla;
            Gradient.Checked += KolorTla;
            Arial.Checked += RodzinaCzcionki;
            David.Checked += RodzinaCzcionki;
            Verdana.Checked += RodzinaCzcionki;

            Czarny.Checked += Pasek;
            Czerwony.Checked += Pasek;
            Zielony.Checked += Pasek;
            Slider.ValueChanged += Pasek;
            Pogrubienie.Checked += Pasek;
            Pogrubienie.Unchecked += Pasek;
            Kursywa.Checked += Pasek;
            Kursywa.Unchecked += Pasek;
            Podkreslenie.Checked += Pasek;
            Podkreslenie.Unchecked += Pasek;
            zolty.Checked += Pasek;
            Bialo.Checked += Pasek;
            Niebieski.Checked += Pasek;
            Gradient.Checked += Pasek;
            Arial.Checked += Pasek;
            David.Checked += Pasek;
            Verdana.Checked += Pasek;


        }
        private void Pasek(object sender, RoutedEventArgs e)
        {
            int Postep = 2;

            Postep += Kursywa.IsChecked == true ? 1 : 0;
            Postep += Podkreslenie.IsChecked == true ? 1 : 0;
            Postep += Pogrubienie.IsChecked == true ? 1 : 0;

            if (Czarny.IsChecked == true || Czerwony.IsChecked == true || Zielony.IsChecked == true) 
            {
                Postep += 1;
            }
            if (zolty.IsChecked == true || Bialo.IsChecked == true || Niebieski.IsChecked == true || Gradient.IsChecked == true) 
            {
                Postep += 1;
            }
            if (Arial.IsChecked == true || David.IsChecked == true || Verdana.IsChecked == true) 
            {
                Postep += 1;
            }
            Progressbar.Value = Postep;

        }
        private void RodzinaCzcionki(object sender, RoutedEventArgs e) 
        {
            if (Arial.IsChecked == true) {
                TextBox.FontFamily = new FontFamily("Arial");
              }
            else if (David.IsChecked == true) {
                TextBox.FontFamily = new FontFamily("David");
            }
            else if(Verdana.IsChecked == true) 
            {
                TextBox.FontFamily = new FontFamily("Verdana");
            }
            
        }
        private void KolorTla(object sender, RoutedEventArgs e) 
        {
            if (zolty.IsChecked == true)
            {
                TextBox.Background = Brushes.Yellow;
            }
            else if (Bialo.IsChecked == true)
            {
                TextBox.Background = Brushes.White;
            }
            else if (Niebieski.IsChecked == true)
            {
                TextBox.Background = Brushes.Blue;
            }
            else if (Gradient.IsChecked == true)
            {
                var gradientBrush = new LinearGradientBrush
                {
                    StartPoint = new Point(0, 0),
                    EndPoint = new Point(1, 1)
                };

                gradientBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
                gradientBrush.GradientStops.Add(new GradientStop(Colors.Blue, 1.0));

                TextBox.Background = gradientBrush;
            }

        }
        private void lewo(object sender, EventArgs e) 
        {
            TextBox.TextAlignment = TextAlignment.Left;
           
        }
        private void Srodek(object sender, EventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Center;
        }
        private void Prawo(object sender, EventArgs e) 
        {
            TextBox.TextAlignment = TextAlignment.Right;
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
            
            TextBox.FontWeight = Pogrubienie.IsChecked == true ? FontWeights.Bold : FontWeights.Normal;

            
            TextBox.FontStyle = Kursywa.IsChecked == true ? FontStyles.Italic : FontStyles.Normal;

            
            if (Podkreslenie.IsChecked == true)
            {
                TextBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                TextBox.TextDecorations = null;
            }
        }
    }
    
}