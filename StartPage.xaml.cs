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

namespace TestingSystem
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Window
    {
        public StartPage()
        {

            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(1);
            newpage.Show();
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(2);
            newpage.Show();
            Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(3);
            newpage.Show();
            Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(4);
            newpage.Show();
            Close();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(5);
            newpage.Show();
            Close();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(6);
            newpage.Show();
            Close();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(7);
            newpage.Show();
            Close();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            StartTest newpage = new StartTest(8);
            newpage.Show();
            Close();

        }
    }
}
