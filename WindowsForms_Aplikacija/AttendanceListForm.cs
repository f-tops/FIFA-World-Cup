using PodatkovniSloj;
using PodatkovniSloj.Models;
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
    public partial class AttendanceListForm : Form
    {
        private const string MEN_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string WOMEN_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";
        public AttendanceListForm()
        {
            InitializeComponent();
            FillGridView();
            this.CenterToScreen();
        }

        private void FillGridView()
        {
            List<RangListaBrojPosjetitelja> list = RangListaBrojPosjetitelja.GetRangListaBrojPosjetitelja(GetPage(), GetCode());
            dataGridView1.DataSource = list;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
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
    }
}
