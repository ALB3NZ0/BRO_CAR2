using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Avto.xaml
    /// </summary>
    public partial class Avto : Page
    {

        private SELLS_CAREntities avtO = new SELLS_CAREntities();
        public Avto()
        {
            InitializeComponent();
            avto.ItemsSource = avtO.CAR.ToList();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}
