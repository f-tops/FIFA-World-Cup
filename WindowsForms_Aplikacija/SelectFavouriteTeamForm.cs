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
using WindowsForms_Aplikacija.Models;

namespace WindowsForms_Aplikacija
{
    public partial class SelectFavouriteTeamForm : Form
    {
        const string MEN_TEAMS = "https://world-cup-json-2018.herokuapp.com/teams/results";
        const string WOMEN_TEAMS = "http://worldcup.sfg.io/teams/results";
        public SelectFavouriteTeamForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillComboBox();

        }

        private void FillComboBox()
        {
            List<TeamsPage.Team> timovi = APIParser.ParseTeams(checkSelectedCup());
            foreach (TeamsPage.Team team in timovi)
            {
                cbTimovi.Items.Add(team);
            }

            cbTimovi.DisplayMember = "Country";
            cbTimovi.ValueMember = "FifaCode";
            cbTimovi.DataSource = timovi;

        }

        private string checkSelectedCup()
        {
            if (Repo.GetStringLineFromFile(1, FilePath.Path).Equals("Žensko"))
            {
                return WOMEN_TEAMS;
            }
            else
            {
                return MEN_TEAMS;
            }
        }

        private void checkLanguage()
        {
            if (Repo.GetStringLineFromFile(2, FilePath.Path).Equals("hr"))
            {
                
            }
            else
            {
                
            }
        }


        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Repo.SaveInfoToFile(cbTimovi.SelectedValue.ToString(), 3, FilePath.Path);
            this.Hide();
            var MainForm = new MainForm();
            MainForm.ShowDialog();
            this.Close();
        }
    }
}
