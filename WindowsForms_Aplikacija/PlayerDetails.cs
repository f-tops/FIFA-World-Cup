using MatchesPage;
using PodatkovniSloj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Aplikacija
{
    public partial class PlayerDetails : Form
    {
        List<StartingEleven> allPlayers = APIParser.GetAllPlayers();
        public PlayerDetails()
        {
            InitializeComponent();
            FillListBox();
            this.CenterToScreen();
        }

        private void FillListBox()
        {

            foreach (var item in allPlayers)
            {
                lbAllPlayers.Items.Add(item);
            }

            lbAllPlayers.DisplayMember = "Name";
            lbAllPlayers.ValueMember = "Name";
            lbAllPlayers.DataSource = allPlayers;

        }

        private void lbAllPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDetails(lbAllPlayers.SelectedValue, allPlayers);
        }

        private void FillDetails(object selectedValue, List<StartingEleven> allPlayers)
        {
            foreach (var player in allPlayers)
            {
                if (selectedValue.Equals(player.Name))
                {
                    lblOdgBrojDresa.Text = player.ShirtNumber.ToString();
                    label8.Text = player.Name.ToString();
                    if (player.Captain == true)
                    {
                        lblOdgKapetan.Text = "Da";
                    }
                    else
                    {
                        lblOdgKapetan.Text = "Ne";
                    }
                    if (player.Favourite == true)
                    {
                        lblOdgFavorit.Text = "Da";
                    }
                    else
                    {
                        lblOdgFavorit.Text = "Ne";
                    }
                }
            }
        }
    }
}
