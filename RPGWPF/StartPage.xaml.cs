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
using RPGv2;


namespace RPGWPF
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        public int WaitForInput()
        {
            do
            {

            } while (GlobalValues.Inp == -1);
            return GlobalValues.Inp;
        }

        public void ChangeInp(int inp)
        {
            GlobalValues.Inp = inp;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ChangeInp(0);
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ChangeInp(1);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ChangeInp(2);
        }
    }
}
