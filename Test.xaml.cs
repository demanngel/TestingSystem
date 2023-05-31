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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace TestingSystem
{

    public partial class Test : Window
    {
        ApplicationContext DB;
        Random random = new Random();
        List<Question> questions;
        int i, n = 1, mark = 0, rightanswer = -1, answer = -1;

        public Test()
        {

            InitializeComponent();

            DB = new ApplicationContext();

            questions = DB.Questions.ToList();

            OutData();

        }

        private void OutData()
        {

            i = random.Next(0, questions.Count());

            string QNum = "Вопрос №" + n;
            QuestionNumber.Content = QNum;
            QuestionText.Source = ToImage(questions[i].Text);

            List<string> answers = new List<string>();

            answers.Add(questions[i].Answer1);
            answers.Add(questions[i].Answer2);
            answers.Add(questions[i].Answer3);
            answers.Add(questions[i].Answer4);

            for (int g = answers.Count - 1; g >= 1; g--)
            {

                int j = random.Next(g + 1);
                string temp = answers[j];
                answers[j] = answers[g];
                answers[g] = temp;

            }

            for (int g = 0; g < answers.Count; g++)
            {

                if (answers[g] == questions[i].Answer1) rightanswer = g + 1;

            }

            RadioButton1.Content = answers[0];
            RadioButton2.Content = answers[1];
            RadioButton3.Content = answers[2];
            RadioButton4.Content = answers[3];

            questions.Remove(questions[i]);

            if (n == 10)
            {

                Button.Content = "Завершить тест";
                Button.Width = 180;
                Button.Click += Button2_Click;
                Button.Click -= Button1_Click;

            }

            n++;

            answer = -1;

            RadioButton1.IsChecked = false;
            RadioButton2.IsChecked = false;
            RadioButton3.IsChecked = false;
            RadioButton4.IsChecked = false;

        }

        public BitmapImage ToImage(byte[] array)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = new System.IO.MemoryStream(array);
            image.EndInit();
            return image;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (answer != -1)
            {

                if (rightanswer == answer) mark++;

                OutData();

            }

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            if (rightanswer == answer) mark++;

            Mark newWindow = new Mark(mark);
            newWindow.Show();

            Close();

        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {

            answer = 1;

        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {

            answer = 2;

        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {

            answer = 3;

        }

        private void RadioButton4_Checked(object sender, RoutedEventArgs e)
        {

            answer = 4;

        }

    }
}

