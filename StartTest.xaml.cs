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
    /// Логика взаимодействия для Window.xaml
    /// </summary>
    public partial class StartTest : Window
    {
        public StartTest(int title)
        {
            InitializeComponent();

            string titlelb = "Лабораторная работа№" + title;

            LBTitle.Content = titlelb;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Test test = new Test();
            test.Show();
            Close();

        }
    }
}
