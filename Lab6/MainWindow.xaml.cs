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
using Obliczenia;

namespace Lab6
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public double FunkcjaRosenbrocka(double x, double y) {
            
            return (1-x)*(1-x)+100*(y-x*x)*(y-x*x);
        }

        private void btnF3_Click(object sender, RoutedEventArgs e)
        {
            (double, double) wynik;
            wynik = Funkcje.ZnajdzMinimumFunkcji2D(-100, -100, 100, 100, 1000, (x, y) =>
            {
                if (x > -1 && x < 1 && y > -2 && y < 2){
                    return (x * x) + (y * y); 
                }
                else { return 30; } 
            
            });
            MessageBox.Show(wynik.Item1 + wynik.Item2.ToString());
        }

        private void btnF2_Click(object sender, RoutedEventArgs e)
        {
            (double, double) wynik;
            wynik = Funkcje.ZnajdzMinimumFunkcji2D(-100, -100, 100, 100, 1000, (x,y)=>((x-4)*(x-4))+((y+2)*(y+2)));
            MessageBox.Show(wynik.Item1 + wynik.Item2.ToString());
        }

        private void btnRosenbrocka_Click(object sender, RoutedEventArgs e)
        {
            (double, double) wynik;
            wynik = Funkcje.ZnajdzMinimumFunkcji2D(0, 0, 1, 1, 1000, FunkcjaRosenbrocka);
            MessageBox.Show(wynik.Item1 + wynik.Item2.ToString());
        }
    }
}
