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
    /// Логика взаимодействия для Katalog.xaml
    /// </summary>
    public partial class Katalog : Window
    {
        public Katalog()
        {
            InitializeComponent();

            var currenChasi = МастерскаяEntities.GetContext().Каталог.ToList();
            LViewZakaz.ItemsSource = currenChasi;
        }

        private void LViewZakaz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnНазад_Click(object sender, RoutedEventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            Close();
        }
    }
}
