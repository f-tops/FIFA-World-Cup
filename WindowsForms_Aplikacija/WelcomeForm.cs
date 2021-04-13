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
using PodatkovniSloj;

namespace WindowsForms_Aplikacija
{
    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillComboBox();
        }

        private void FillComboBox()
        {
            List<CbItem> cbJezikItems = new List<CbItem>();
            List<CbItem> cbOdabirPrvenstvaItems = new List<CbItem>();
            cbOdabirPrvenstvaItems.Add(new CbItem("Muško", "Muško"));
            cbOdabirPrvenstvaItems.Add(new CbItem("Žensko", "Žensko"));
            cbJezikItems.Add(new CbItem("Hrvatski", "hr"));
            cbJezikItems.Add(new CbItem("Engleski", "en"));

            cbOdabirPrvenstva.DisplayMember = "Name";
            cbOdabirPrvenstva.ValueMember = "Value";
            cbOdabirPrvenstva.DataSource = cbOdabirPrvenstvaItems;
            
            cbJezik.DisplayMember = "Name";
            cbJezik.ValueMember = "Value";
            cbJezik.DataSource = cbJezikItems;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Repo.SaveInfoToFile(cbOdabirPrvenstva.SelectedValue.ToString(), 1, FilePath.Path);
            Repo.SaveInfoToFile(cbJezik.SelectedValue.ToString(), 2, FilePath.Path);
            this.Hide();
            var selectFavouriteTeamForm = new SelectFavouriteTeamForm();
            selectFavouriteTeamForm.ShowDialog();;
            this.Close();
        }
    }
}
