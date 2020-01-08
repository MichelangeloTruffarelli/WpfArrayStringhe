using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfArrayStringhe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] array = new string[5];
        int c;

        private void BtnInserisci_Click(object sender, RoutedEventArgs e)
        {
            array[c] = TxtStringa.Text;
            c++;
            TxtStringa.Clear();
            TxtStringa.Focus();
            if (c >= 5)
            {
                BtnInserisci.IsEnabled = false;
                BtnPubblica.IsEnabled = true;
                BtnStampa.IsEnabled = true;
            }
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            BtnStampa.IsEnabled = false;
            for(c = 0; c < array.Length; c++)
            {
                LblRisultato.Content += $"Posizione {c} : {array[c]} \n";
            }
        }

        private void BtnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pubblica.txt", false, Encoding.UTF8);
            for(c = 0; c < array.Length; c++)
            {
                sw.WriteLine($" Posizione {c} : {array[c]} \n");
            }
            sw.Flush();
            sw.Close();
        }
    }
}
