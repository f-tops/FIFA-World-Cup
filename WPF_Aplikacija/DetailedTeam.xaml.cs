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
    /// Interaction logic for DetailedTeam.xaml
    /// </summary>
    public partial class DetailedTeam : Window
    {
        public DetailedTeam(TeamsPage.Team team)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            lblCountry.Content = team.Country.ToString();
            lblFifaCode.Content = team.FifaCode.ToString();
            LblNumberOfGamesPlayed.Content = team.GamesPlayed;
            lblWon.Content = team.Wins;
            lblLost.Content = team.Losses;
            LblNeutral.Content = team.Draws;
            LblGoals1.Content = team.GoalsFor;
            lblGoals2.Content = team.GoalsAgainst;
            lblGoals3.Content = team.GoalDifferential;
        }
    }
}
