using MatchesPage;
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

namespace WPF_Aplikacija.Models
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl
    {
        private StartingEleven player;
        public Player(StartingEleven player)
        {
            InitializeComponent();
            this.player = player;
            lblName.Content = player.Name.ToString();
            lblShirtNumber.Content = player.ShirtNumber.ToString();
            Margin = new Thickness(0, 6, 0, 6);
        }

        private void Player_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DetailedPlayer details = new DetailedPlayer(player);


            details.Show();
        }
    }
}
