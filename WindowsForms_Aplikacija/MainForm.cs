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
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
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

        }
    }
}
