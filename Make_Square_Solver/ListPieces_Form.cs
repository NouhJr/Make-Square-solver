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
    public partial class ListPieces_Form : Form
    {
        public ListPieces_Form()
        {
            InitializeComponent();
            
        }

        private void ListPieces_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "");
            string Line;
            int row = 0;
            System.IO.StreamReader File = new System.IO.StreamReader(@"D:\FCIH-Materials\LV.3\S01\OS2\P&T\Make_Square_Solver\test_pieces.txt");
            while ((Line = File.ReadLine()) != null)
            {
                string[] columns = Line.Split(',');
                dataGridView1.Rows.Add();
                for (int i = 0; i < columns.Length; i++)
                {
                    dataGridView1[i, row].Value = columns[i];
                }
                row++;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Solve s = new Solve();
            s.display();
            Result_Form Result = new Result_Form();
            this.Hide();
            Result.ShowDialog();
            this.Show();
        }
    }
}
