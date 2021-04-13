using MatchesPage;
using PodatkovniSloj;
using PodatkovniSloj.Models;
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
using WPF_Aplikacija.Models;

namespace WPF_Aplikacija
{
    /// <summary>
    /// Interaction logic for FootballForm.xaml
    /// </summary>
    public partial class FootballForm : Window
    {
        public string ŽENSKA_STRANICA = "http://worldcup.sfg.io/teams/results";
        public string MUŠKA_STRANICA = "http://world-cup-json-2018.herokuapp.com/teams/results";
        public FootballForm()
        {
            InitializeComponent();
            FillCbHomeTeam();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void FillCbHomeTeam()
        {
            try
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                List<TeamsPage.Team> teams = APIParser.ParseTeams(GetPage());
                foreach (var item in teams)
                {
                    dictionary.Add(item.Country.ToString(), item.FifaCode.ToString());
                }

                cbHomeTeam.ItemsSource = dictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

        }

        private string GetPage()
        {
            if (Repo.GetStringLineFromFile(1, FilePath.Path).Equals("Žensko"))
            {
                return ŽENSKA_STRANICA;
            }
            else
            {
                return MUŠKA_STRANICA;
            }
        }

        private void cbHomeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                FillCbAway();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void FillCbAway()
        {
            KeyValuePair<string, string> dictionary = (KeyValuePair<string,string>)cbHomeTeam.SelectedItem;
            string SelectedCode = dictionary.Value.ToString();
            cbAwayTeam.ItemsSource = APIParser.GetSuprotniTeams(SelectedCode);
        }

        private void cbAwayTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                KeyValuePair<string, string> par1 = (KeyValuePair<string, string>)cbAwayTeam.SelectedItem;
                KeyValuePair<string, string> par2 = (KeyValuePair<string, string>)cbHomeTeam.SelectedItem;
                MatchesPage.Match match = APIParser.getSpecificMatch(par1.Value.ToString(), par2.Value.ToString());
                lblAwayGoal.Content = match.AwayTeam.Goals.ToString();
                lblHomeGoal.Content = match.HomeTeam.Goals.ToString();
                ClearAwayTeam();
                ClearHomeTeam();
                PlayersToField(match.HomeTeamStatistics.StartingEleven, true);
                PlayersToField(match.AwayTeamStatistics.StartingEleven, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        private void ClearAwayTeam()
        {
            spGoalAway.Children.Clear();
            spDefendAway.Children.Clear();
            spMiddleAway.Children.Clear();
            spAttackAway.Children.Clear();
        }

        private void ClearHomeTeam()
        {
            spGoalHome.Children.Clear();
            spDefendHome.Children.Clear();
            spMiddleHome.Children.Clear();
            spAttackHome.Children.Clear();
        }

        private void PlayersToField(List<StartingEleven> startingElevens, bool awayTeam)
        {
            foreach (var player in startingElevens)
            {
                Player playerShow = new Player(player);
                if (awayTeam == false)
                {
                    SetPlayersToFieldHome(player.Position.Value.ToString(), playerShow);
            }
                else
                {
                    SetPlayersToFieldAway(player.Position.Value.ToString(), playerShow);
                }
            }

        }

        private void BtnAwayTeam_Click(object sender, RoutedEventArgs e)
        {
            if(cbAwayTeam.SelectedItem != null)
            {
                KeyValuePair<string, string> par1 = (KeyValuePair<string, string>)cbAwayTeam.SelectedItem;
                List<TeamsPage.Team> teams = APIParser.ParseTeams(GetPage());
                TeamsPage.Team team = new TeamsPage.Team();
                foreach (var item in teams)
                {
                    if (par1.Value.ToString() == item.FifaCode)
                    {
                        team = item;
                    }
                }
                DetailedTeam detailedTeam = new DetailedTeam(team);
                detailedTeam.Show();
            }
            else
            {
                MessageBox.Show("Odaberite tim iz comboboxa");
            }



        }
        private void BtnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            if (cbHomeTeam.SelectedItem != null)
            {
                KeyValuePair<string, string> par1 = (KeyValuePair<string, string>)cbHomeTeam.SelectedItem;
                List<TeamsPage.Team> teams = APIParser.ParseTeams(GetPage());
                TeamsPage.Team team = new TeamsPage.Team();
                foreach (var item in teams)
                {
                    if (par1.Value.ToString() == item.FifaCode)
                    {
                        team = item;
                    }
                }
                DetailedTeam detailedTeam = new DetailedTeam(team);
                detailedTeam.Show();
            }
            else
            {
                MessageBox.Show("Odaberite tim iz comboboxa");
            }


        }

        private void SetPlayersToFieldHome(string position, Player playerShow)
        {
            switch (position)
            {
                case "Defender":
                    spDefendHome.Children.Add(playerShow);
                    break;
                case "Forward":
                    spAttackHome.Children.Add(playerShow);
                    break;
                case "Goalie":
                    spGoalHome.Children.Add(playerShow);
                    break;
                case "Midfield":
                    spMiddleHome.Children.Add(playerShow);
                    break;
                default:
                    break;
            }
        }

        

        private void SetPlayersToFieldAway(string position, Player playerShow)
        {
            switch (position)
            {
                case "Defender":
                    spDefendAway.Children.Add(playerShow);
                    break;
                case "Forward":
                    spAttackAway.Children.Add(playerShow);
                    break;
                case "Goalie":
                    spGoalAway.Children.Add(playerShow);
                    break;
                case "Midfield":
                    spMiddleAway.Children.Add(playerShow);
                    break;
                default:
                    break;
            }
        }
    }
}
