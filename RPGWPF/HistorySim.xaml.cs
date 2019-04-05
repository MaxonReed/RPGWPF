using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;
using RPGv2;

namespace RPGWPF
{
    /// <summary>
    /// Interaction logic for HistorySim.xaml
    /// </summary>
    public partial class HistorySim : Page
    {
        private string factionCreatedText = "";
        private string factionFallenText = "";
        private string eventNameText = "";
        private string yearText = "";

        public string FactionCreatedText
        {
            get => factionCreatedText;
            set
            {
                factionCreatedText = value;
                RaisePropertyChanged("FactionCreatedText");
            }
        }
        public string FactionFallenText
        {
            get => factionFallenText;
            set
            {
                factionFallenText = value;
                RaisePropertyChanged("FactionFallenText");
            }
        }
        public string YearText
        {
            get => yearText;
            set
            {
                yearText = value;
                RaisePropertyChanged("YearText");
            }
        }
        public string EventNameText
        {
            get => eventNameText;
            set
            {
                eventNameText = value;
                RaisePropertyChanged("EventNameText");
                
            }
        }

        public HistorySim()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int inp = 0;
            if(int.TryParse(TextBox1.Text, out inp))
            {
                Game.hist = Game.StartHistory(inp);
            }
        }

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
