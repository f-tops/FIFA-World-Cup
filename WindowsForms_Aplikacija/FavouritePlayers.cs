using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodatkovniSloj;
using MatchesPage;
using WindowsForms_Aplikacija.Models;
using System.IO;
using System.Reflection;

namespace WindowsForms_Aplikacija
{
    public partial class FavouritePlayers : UserControl
    {
        private const string MEN_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string WOMEN_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";

        List<MatchesPage.StartingEleven> allPlayers = new List<MatchesPage.StartingEleven>();
        List<MatchesPage.StartingEleven> favPlayers = new List<MatchesPage.StartingEleven>();
        public FavouritePlayers()
        {

            InitializeComponent();
            FillListBox(true);
            lbFavPlayers.AllowDrop = true;
            lbAllPlayers.AllowDrop = true;

        }

        private void FillListBox(bool firstTime)
        {
            if(firstTime == false)
            {
                lbAllPlayers.Items.Clear();
                lbFavPlayers.Items.Clear();
            }
            else
            {
                FillPlayersAndFavourite(allPlayers, false);
                FillPlayersAndFavourite(favPlayers, true);
            }





            foreach (var player in allPlayers)
            {
                lbAllPlayers.Items.Add(player);
            }
            foreach (var player in favPlayers)
            {
                lbFavPlayers.Items.Add(player);
            }


            lbAllPlayers.DisplayMember = "Name";
            lbAllPlayers.ValueMember = "Name";
            lbAllPlayers.DataSource = allPlayers;



            lbFavPlayers.DisplayMember = "Name";
            lbFavPlayers.ValueMember = "Name";
            lbFavPlayers.DataSource = favPlayers;





        }


        private void RefreshListBox()
        {


            lbAllPlayers.DataSource = null;
            lbAllPlayers.DataSource = allPlayers;
            lbFavPlayers.DisplayMember = "Name";
            lbFavPlayers.ValueMember = "Name";




            lbFavPlayers.DataSource = null;
            lbFavPlayers.DataSource = favPlayers;
            lbFavPlayers.DisplayMember = "Name";
            lbFavPlayers.ValueMember = "Name";

        }


        private void FillPlayersAndFavourite(List<StartingEleven> allPlayers, bool favourite)
        {
            MatchesPage.Match matchOne = APIParser.ParseMatches(GetPage(), GetCode()).FirstOrDefault();
            if (CheckIfHome(GetCode(), matchOne))
            {
                foreach (MatchesPage.StartingEleven player in matchOne.HomeTeamStatistics.StartingEleven)
                {
                    if((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
                foreach (MatchesPage.StartingEleven player in matchOne.HomeTeamStatistics.Substitutes)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
            }
            else
            {
                foreach (MatchesPage.StartingEleven player in matchOne.AwayTeamStatistics.StartingEleven)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
                foreach (MatchesPage.StartingEleven player in matchOne.AwayTeamStatistics.Substitutes)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
            }
        }

        private bool CheckIfHome(string code, MatchesPage.Match match)
        {
            try
            {
                if (match.HomeTeam.Code.Equals(code))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        private string GetCode()
        {
            return Repo.GetStringLineFromFile(3, FilePath.Path);
        }

        private string GetPage()
        {
            if (Repo.GetStringLineFromFile(1, FilePath.Path).Equals("Žensko"))
            {
                return WOMEN_MATCHES;
            }
            else
            {
                return MEN_MATCHES;
            }
        }


   


        private void btnDesno_Click(object sender, EventArgs e)
        {
            try
            {
                StartingEleven player = GetPlayer((StartingEleven)lbAllPlayers.SelectedItem);
                player.Favourite = true;
                favPlayers.Add(player);
                allPlayers.Remove(GetPlayer((StartingEleven)lbAllPlayers.SelectedItem));
                RefreshListBox();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Greška kod prebacivanja igrača", "Greška",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            try
            {
                StartingEleven player = GetPlayer((StartingEleven)lbFavPlayers.SelectedItem);
                player.Favourite = false;
                allPlayers.Add(player);
                favPlayers.Remove(GetPlayer((StartingEleven)lbFavPlayers.SelectedItem));
                RefreshListBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Greška kod prebacivanja igrača", "Greška",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private StartingEleven GetPlayer(StartingEleven name)
        {
            string CheckName = name.Name.ToString();
            foreach (var item in allPlayers)
            {
                if(CheckName.Equals(item.Name.ToString()))
                {
                    return item;
                }
            }
            foreach (var item in favPlayers)
            {
                if (CheckName.Equals(item.Name.ToString()))
                {
                    return item;
                }
            }
            return null;
        }

        private void brojPosjetiteljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var attendanceForm = new AttendanceListForm();
            attendanceForm.ShowDialog();
            
        }

        private void brojGolovaIKartonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rangLista = new RangListaIgraca();
            rangLista.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var postavke = new Options();
            postavke.ShowDialog();
        }

        private void igračiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var igraci = new PlayerDetails();
            igraci.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

        }
    }
}
