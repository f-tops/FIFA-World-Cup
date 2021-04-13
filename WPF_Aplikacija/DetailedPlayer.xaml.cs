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

namespace WPF_Aplikacija
{
    /// <summary>
    /// Interaction logic for DetailedPlayer.xaml
    /// </summary>
    public partial class DetailedPlayer : Window
    {
        public DetailedPlayer(MatchesPage.StartingEleven player)
        {

            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            lblIme.Content = player.Name;
            lblBrojDresa.Content = player.ShirtNumber;
            if(player.Captain == true)
            {
                lblKapetan.Content = "DA";
            }
            else
            {
                lblKapetan.Content = "NE";
            }
            lblPozicija.Content = player.Position.ToString(); ;
            lblGolovi.Content = player.Goals;
        }
    }
}
