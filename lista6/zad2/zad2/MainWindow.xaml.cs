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
using System.Threading;

namespace zad2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Firmy.Items.Add("Samsung");
            Firmy.Items.Add("Huawei");
            Firmy.Items.Add("Xiaomi");
            Firmy.Items.Add("Oneplus");
        }

        private void Firmy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Firmy.SelectedItem.ToString() == "Samsung")
            {

                Modele.Items.Clear();
                Modele.Items.Add("S20");
                Modele.Items.Add("S20 Ultra");
                Modele.Items.Add("A70");
                Modele.Items.Add("S10e");

            }
            if (Firmy.SelectedItem.ToString() == "Huawei")
            {
                Modele.Items.Clear();
                Modele.Items.Add("P40 Pro");
                Modele.Items.Add("P40");
                Modele.Items.Add("Mate30 Pro");
                Modele.Items.Add("P30");
            }
            if (Firmy.SelectedItem.ToString() == "Xiaomi")
            {
                Modele.Items.Clear();
                Modele.Items.Add("Mi 9");
                Modele.Items.Add("Mi Note 10");
                Modele.Items.Add("Redmi Note 9");
                Modele.Items.Add("Mi 10");
            }
            if (Firmy.SelectedItem.ToString() == "Oneplus")
            {
                Modele.Items.Clear();
                Modele.Items.Add("8");
                Modele.Items.Add("8 Pro");
                Modele.Items.Add("7T");
                Modele.Items.Add("7T Pro");
            }
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            progressBar.Value = 0;
            Task.Run(() =>
            {
                for (int i = 0; i < 101; i++)
                {
                    Thread.Sleep(10);
                    this.Dispatcher.Invoke(() =>
                    {
                        progressBar.Value = i;
                    });
                }
            });
        }

    }

}

