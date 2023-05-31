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
    /// Логика взаимодействия для Mark.xaml
    /// </summary>
    public partial class Mark : Window
    {
        int mark;
        public Mark(int mark)
        {

            InitializeComponent();

            string s = mark + " правильных ответов из 10";

            ResultText.Content = s;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Close();

        }
    }
}
