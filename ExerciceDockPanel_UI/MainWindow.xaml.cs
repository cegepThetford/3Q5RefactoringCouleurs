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

namespace ExerciceDockPanel_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAqua_Click(object sender, RoutedEventArgs e)
        {
            tbCouleur.Background = (Brush)new BrushConverter().ConvertFromString("Aqua");
            btnCrimson.FontWeight = btnLime.FontWeight = btnPeru.FontWeight = FontWeights.Normal;
            btnAqua.FontWeight = FontWeights.Bold;
        }

        private void BtnCrimson_Click(object sender, RoutedEventArgs e)
        {
            tbCouleur.Background = (Brush)new BrushConverter().ConvertFromString("Crimson");
            btnAqua.FontWeight = btnLime.FontWeight = btnPeru.FontWeight = FontWeights.Normal;
            btnCrimson.FontWeight = FontWeights.Bold;
        }

        private void BtnLime_Click(object sender, RoutedEventArgs e)
        {
            tbCouleur.Background = (Brush)new BrushConverter().ConvertFromString("Lime");
            btnAqua.FontWeight = btnCrimson.FontWeight = btnPeru.FontWeight = FontWeights.Normal;
            btnLime.FontWeight = FontWeights.Bold;
        }

        private void BtnPeru_Click(object sender, RoutedEventArgs e)
        {
            tbCouleur.Background = (Brush) new BrushConverter().ConvertFromString("Peru");
            btnAqua.FontWeight = btnCrimson.FontWeight = btnLime.FontWeight = FontWeights.Normal;
            btnPeru.FontWeight = FontWeights.Bold;
        }
    }
}
