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

namespace Мастерская1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnРЕГ_Click(object sender, RoutedEventArgs e)
        {
            registr reg = new registr();
            reg.Show();
            Close();
        }

        private void BtnВХ_Click(object sender, RoutedEventArgs e)
        {
            Vxod vxod = new Vxod();
            vxod.Show();
            Close();
        }
    }
}
