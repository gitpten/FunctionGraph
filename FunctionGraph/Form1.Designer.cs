namespace FunctionGraph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pTools = new System.Windows.Forms.Panel();
            this.chHyper = new System.Windows.Forms.CheckBox();
            this.chCube = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chSquare = new System.Windows.Forms.CheckBox();
            this.pGraph = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.pTools, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pGraph, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1246, 692);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.chHyper);
            this.pTools.Controls.Add(this.chCube);
            this.pTools.Controls.Add(this.trackBar1);
            this.pTools.Controls.Add(this.chSquare);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTools.Location = new System.Drawing.Point(3, 3);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(243, 686);
            this.pTools.TabIndex = 0;
            // 
            // chHyper
            // 
            this.chHyper.AutoSize = true;
            this.chHyper.Location = new System.Drawing.Point(58, 146);
            this.chHyper.Name = "chHyper";
            this.chHyper.Size = new System.Drawing.Size(72, 24);
            this.chHyper.TabIndex = 3;
            this.chHyper.Text = "y = Vx";
            this.chHyper.UseVisualStyleBackColor = true;
            this.chHyper.CheckedChanged += new System.EventHandler(this.chHyper_CheckedChanged);
            // 
            // chCube
            // 
            this.chCube.AutoSize = true;
            this.chCube.Location = new System.Drawing.Point(58, 107);
            this.chCube.Name = "chCube";
            this.chCube.Size = new System.Drawing.Size(81, 24);
            this.chCube.TabIndex = 2;
            this.chCube.Text = "y = x^3";
            this.chCube.UseVisualStyleBackColor = true;
            this.chCube.CheckedChanged += new System.EventHandler(this.chHyper_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(31, 277);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chSquare
            // 
            this.chSquare.AutoSize = true;
            this.chSquare.Location = new System.Drawing.Point(58, 61);
            this.chSquare.Name = "chSquare";
            this.chSquare.Size = new System.Drawing.Size(81, 24);
            this.chSquare.TabIndex = 0;
            this.chSquare.Text = "y = x^2";
            this.chSquare.UseVisualStyleBackColor = true;
            this.chSquare.CheckedChanged += new System.EventHandler(this.chHyper_CheckedChanged);
            // 
            // pGraph
            // 
            this.pGraph.BackColor = System.Drawing.Color.White;
            this.pGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGraph.Location = new System.Drawing.Point(252, 3);
            this.pGraph.Name = "pGraph";
            this.pGraph.Size = new System.Drawing.Size(991, 686);
            this.pGraph.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pTools;
        private Panel pGraph;
        private TrackBar trackBar1;
        private CheckBox chSquare;
        private CheckBox chCube;
        private CheckBox chHyper;
    }
}