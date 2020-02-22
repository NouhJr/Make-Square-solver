using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Square_Solver
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ListPieces_Form ListPieces = new ListPieces_Form();
            this.Hide();
            ListPieces.ShowDialog();
            this.Show();
        }

    }
}
