using System;
using System.Collections.Generic;
using System.Data;
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
using System.IO;

namespace LoginQuizDelvalleSantiago
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool pray;
        bool play;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtData.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text = Rutes.ReadAllFile();
            TxtData.Text = text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Rutes.Addname(RegisterUsername.Text);
            Rutes.Addname(Registerpassword.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Rutes.Delete();
            TxtData.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string[] p = Rutes.cont();

            for (int i = 0; i < p.Length; i += 2)
            {
                if (LoginUsername.Text == p[i])
                {
                    pray = true;
                }
                else
                {
                    pray = false;
                }
            }

            for (int x = 1; x < p.Length; x += 2)
            {
                if (LoginPassword.Text == p[x])
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }

            if(pray==true && play==true)
            {
                MessageBox.Show("Bienvenido de nuevo"+""+ LoginUsername.Text + "\n" + "Disfruta de todos nuestros servicios");
            }
            else
            {
                MessageBox.Show("Incredenciales invalidas");
            }
        }
    }
}
