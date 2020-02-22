namespace Make_Square_Solver
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Make_Square_Puzzle_Solver = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Make_Square_Puzzle_Solver
            // 
            this.Make_Square_Puzzle_Solver.BackColor = System.Drawing.Color.Silver;
            this.Make_Square_Puzzle_Solver.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_Square_Puzzle_Solver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Make_Square_Puzzle_Solver.Location = new System.Drawing.Point(78, 40);
            this.Make_Square_Puzzle_Solver.Name = "Make_Square_Puzzle_Solver";
            this.Make_Square_Puzzle_Solver.Size = new System.Drawing.Size(324, 53);
            this.Make_Square_Puzzle_Solver.TabIndex = 0;
            this.Make_Square_Puzzle_Solver.Text = "Make Square Solver";
            this.Make_Square_Puzzle_Solver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(171, 194);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(121, 43);
            this.Next.TabIndex = 1;
            this.Next.Text = "List Pieces";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 299);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Make_Square_Puzzle_Solver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Make Square Solver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Make_Square_Puzzle_Solver;
        private System.Windows.Forms.Button Next;
    }
}

