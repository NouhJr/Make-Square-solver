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
    public partial class Result_Form : Form
    {
        public Result_Form()
        {
            InitializeComponent();
        }

        private void Result_Form_Load(object sender, EventArgs e)
        {
            Solve s = new Solve();
            string path = @"D:\FCIH-Materials\LV.3\S01\OS2\P&T\Make_Square_Solver\result.txt";
            if (s.check == 0)
            {
                Result.Columns.Add("", "");
                string Line;
                int row = 0;
                System.IO.StreamReader File = new System.IO.StreamReader(path);
                while ((Line = File.ReadLine()) != null)
                {
                    string[] columns = Line.Split(',');
                    Result.Rows.Add();
                    for (int i = 0; i < columns.Length; i++)
                    {
                        Result[i, row].Value = columns[i];
                    }
                    row++;
                }
            }
            
            else
            {
                Result.Columns.Add("", "");
                string Line;
                int row = 0;
                System.IO.StreamReader File = new System.IO.StreamReader(path);
                while ((Line = File.ReadLine()) != null)
                {
                    string[] columns = Line.Split(',');
                    Result.Rows.Add();
                    for (int i = 0; i < columns.Length; i++)
                    {
                        Result[i, row].Value = columns[i];
                    }
                    row++;
                }
            }
        }
    }
}
