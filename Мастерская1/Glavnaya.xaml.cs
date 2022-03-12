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

namespace Мастерская1
{
    /// <summary>
    /// Логика взаимодействия для Glavnaya.xaml
    /// </summary>
    public partial class Glavnaya : Window
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Katalog katalog = new Katalog();
            katalog.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            zakaz zk = new zakaz();
            zk.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            info infor = new info();
            infor.Show();
            Close();
        }
    }
}
