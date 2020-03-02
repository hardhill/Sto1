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

namespace Sto1
{
    /// <summary>
    /// Логика взаимодействия для RoundOne.xaml
    /// </summary>
    public partial class RoundOne : Window
    {
        StoOdin stoodin;
        public RoundOne()
        {
            InitializeComponent();
            
        }

        private void Txt_1_MouseUp(object sender, MouseButtonEventArgs e)
        {

            //Txt_1.Text = stoodin.OtvetVerny(1);
        }

        private void FrmOne_Loaded(object sender, RoutedEventArgs e)
        {
            stoodin = new StoOdin(1);
            stoodin.Init();
            Txt_1.Text = "1";
        }
    }
}
