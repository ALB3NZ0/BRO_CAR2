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

namespace CAR_BD2
{
    /// <summary>
    /// Логика взаимодействия для WhereTheCar.xaml
    /// </summary>
    public partial class WhereTheCar : Page
    {

        private SELLS_CAREntities whereTheCar = new SELLS_CAREntities();

        public WhereTheCar()
        {
            InitializeComponent();
            avto.ItemsSource = whereTheCar.WHERE_THE_CAR_COMES_FROM.ToList();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}
