using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Make_Square_Solver
{
    class Solve
    {
        long[, ,] pieces = new long[5, 4, 4]; 
        long[] piece_rows = new long[5];  
        long[] piece_cols = new long[5]; 
        long[,] board = new long[4, 4]; 
        string line; 
        long NumberOfPieces;
        public int check;

/*********************************************************************************************/

        public int read_input() 
        {
            string filePath = @"D:\FCIH-Materials\LV.3\S01\OS2\P&T\Make_Square_Solver\test.txt"; 

            StreamReader file = null;
            file = new StreamReader(filePath); 

            NumberOfPieces = Convert.ToInt64(file.ReadLine()); 
            if (NumberOfPieces == 0) return 0; 
            for (int i = 0; i < NumberOfPieces; i++) 
            {
                piece_rows[i] = Convert.ToInt64(file.ReadLine());
                piece_cols[i] = Convert.ToInt64(file.ReadLine());
                for (int j = 0; j < piece_rows[i]; j++)
                {
                    line = file.ReadLine();
                    char[] char_line = line.ToCharArray();
                    for (int k = 0; k < piece_cols[i]; k++)
                    {
                        if (char_line[k] == '1')
                            pieces[i, j, k] = 1;
                        else
                            pieces[i, j, k] = 0;
                    }
                }
            }
            file.Close();
            return 1;
        }

/*********************************************************************************************/

        public long fit(long current_try)
        {
            long solved = 0;
            long i, j, k;
            for (i = 0; i < 4; i++) //for loop through the board matrix to initialize it with zeros.
                for (j = 0; j < 4; j++)
                    board[i, j] = 0;
            for (i = 0; i < NumberOfPieces; i++)
            {
                long boardpos = Convert.ToInt64(current_try % Math.Pow(16, i + 1)) / Convert.ToInt64(Math.Pow(16, i));
                long boardrow = (boardpos / 4);
                long boardcol = (boardpos % 4);
                for (j = 0; j < piece_rows[i]; j++)
                    for (k = 0; k < piece_cols[i]; k++)
                        if ((boardrow + j < 4) && (boardcol + k < 4))
                            board[boardrow + j, boardcol + k] += pieces[i, j, k];
            }
            solved = 1;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    solved = Convert.ToInt64((solved == 1) && (board[i, j] == 1));
                }
            }
            return solved;

        }

/*********************************************************************************************/

        public long solve(ref long answer)
        {
            long solved = 0;
            long numtries = 1;
            long current_try;
            for (long x = 1; x <= NumberOfPieces; x++)
                numtries *= 16;

            for (current_try = 0; (current_try < numtries) && (solved == 0); current_try++)
            {
                Parallel.Invoke((Action)(() => fit(current_try)),
                  (Action)(() => fit(current_try + 1)));


                
                
                if (fit(current_try) == 1)
                    solved = 1;
            }
            


            /*for (current_try = 0; (current_try < numtries) && (solved == 0); current_try++)
            {
                if (fit(current_try) == 1)
                    solved = 1;
            }*/
            answer = current_try - 1;
            return solved;
        }

/*********************************************************************************************/

        public void print_solution(long answer)
        {
            long pos, row, col;
            string path = @"D:\FCIH-Materials\LV.3\S01\OS2\P&T\Make_Square_Solver\result.txt";

            if (answer == -1)
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("No possible solution !");
                }
                check = 0;
            }
            else
            {
                long[,] solution = new long[4, 4];
                int r, c;
                for (int i = 0; i < NumberOfPieces; i++)
                {
                    pos = Convert.ToInt64((answer % Convert.ToInt64(Math.Pow(16, i + 1)))) / Convert.ToInt64(Math.Pow(16, i));
                    row = pos / 4;
                    col = pos % 4;
                    for (r = 0; r < piece_rows[i]; r++)
                    {
                        for (c = 0; c < piece_cols[i]; c++)
                        {
                            if (pieces[i, r, c] == 1)
                                solution[row + r, col + c] = 1 + i;
                        }
                    }
                }
                string path1 = @"D:\FCIH-Materials\LV.3\S01\OS2\P&T\Make_Square_Solver\temp.txt";
                if (File.Exists(path1))
                {
                    using (StreamWriter sw = File.CreateText(path1))
                    {

                    }
                }
                for (long x = 0; x < 4; x++)
                {
                    for (long y = 0; y < 4; y++)
                    {
                        using (StreamWriter sw = File.AppendText(path1))
                        {
                            sw.Write(solution[x, y]);
                        }
                    }
                }

                StreamReader file = null;
                file = new StreamReader(path1);

                char[] Line = new char[5];
                char[] Line1 = new char[5];
                char[] Line2 = new char[5];
                char[] Line3 = new char[5];

                string ans = file.ReadLine();
                
                Line[0] = ans[0];
                Line[1] = ans[1];
                Line[2] = ans[2];
                Line[3] = ans[3];

                Line1[0] = ans[4];
                Line1[1] = ans[5];
                Line1[2] = ans[6];
                Line1[3] = ans[7];

                Line2[0] = ans[8];
                Line2[1] = ans[9];
                Line2[2] = ans[10];
                Line2[3] = ans[11];

                Line3[0] = ans[12];
                Line3[1] = ans[13];
                Line3[2] = ans[14];
                Line3[3] = ans[15];

                if (File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {

                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(Line[j]);
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("\n");
                }

                for (int j = 0; j < 4; j++)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(Line1[j]);
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("\n");
                }

                for (int j = 0; j < 4; j++)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(Line2[j]);
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("\n");
                }

                for (int j = 0; j < 4; j++)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(Line3[j]);
                    }
                }

            }
            check = 1;
        }


/*********************************************************************************************/
       
        public void display()
        {
            long answer = 0;
            if (read_input() == 1)
            {
                if (solve(ref answer) == 1)
                {
                    print_solution(answer);
                }
                else
                    print_solution(-1);

            }
        }

/*********************************************************************************************/
    }
}
