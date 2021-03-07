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

namespace zad1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String adres = "Uniwersytet Wrocławski";
        private String uczelnia = "pl. Uniwersytecki 1, 50-137 Wrocław";
        private String cykl = "3-letnie licencjackie";
        private bool dz = false;
        private bool uzupelniajace = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            uczelnia = Nazwa.Text;
            adres = Adres.Text;
            cykl = Combo1.Text;
            Window1 objWindow1 = new Window1();
            objWindow1.uzupelnij(adres, uczelnia, cykl, dz, uzupelniajace);
            objWindow1.Show();
        }

        private void Anuluj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            dz = true;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            uzupelniajace = true;
        }
        private void ComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void dzienne_Unchecked(object sender, RoutedEventArgs e)
        {
            dz = false;
        }

        private void uzup_Unchecked(object sender, RoutedEventArgs e)
        {
            uzupelniajace = false;
        }
    }
}
