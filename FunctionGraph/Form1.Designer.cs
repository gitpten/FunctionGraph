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
            this.label2 = new System.Windows.Forms.Label();
            this.nB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nK = new System.Windows.Forms.NumericUpDown();
            this.chLinear = new System.Windows.Forms.CheckBox();
            this.chHyper = new System.Windows.Forms.CheckBox();
            this.chCube = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chSquare = new System.Windows.Forms.CheckBox();
            this.pGraph = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nK)).BeginInit();
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
            this.pTools.Controls.Add(this.label2);
            this.pTools.Controls.Add(this.nB);
            this.pTools.Controls.Add(this.label1);
            this.pTools.Controls.Add(this.nK);
            this.pTools.Controls.Add(this.chLinear);
            this.pTools.Controls.Add(this.chHyper);
            this.pTools.Controls.Add(this.chCube);
            this.pTools.Controls.Add(this.trackBar1);
            this.pTools.Controls.Add(this.chSquare);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTools.Location = new System.Drawing.Point(3, 3);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(243, 686);
            this.pTools.TabIndex = 0;
            this.pTools.Paint += new System.Windows.Forms.PaintEventHandler(this.pTools_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "b";
            // 
            // nB
            // 
            this.nB.DecimalPlaces = 2;
            this.nB.Location = new System.Drawing.Point(34, 347);
            this.nB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nB.Name = "nB";
            this.nB.Size = new System.Drawing.Size(150, 27);
            this.nB.TabIndex = 7;
            this.nB.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "k";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nK
            // 
            this.nK.DecimalPlaces = 2;
            this.nK.Location = new System.Drawing.Point(34, 274);
            this.nK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nK.Name = "nK";
            this.nK.Size = new System.Drawing.Size(150, 27);
            this.nK.TabIndex = 5;
            this.nK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nK.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // chLinear
            // 
            this.chLinear.AutoSize = true;
            this.chLinear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chLinear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chLinear.Location = new System.Drawing.Point(51, 72);
            this.chLinear.Name = "chLinear";
            this.chLinear.Size = new System.Drawing.Size(102, 24);
            this.chLinear.TabIndex = 4;
            this.chLinear.Text = "y = kx + b";
            this.chLinear.UseVisualStyleBackColor = true;
            this.chLinear.CheckedChanged += new System.EventHandler(this.chHyper_CheckedChanged);
            // 
            // chHyper
            // 
            this.chHyper.AutoSize = true;
            this.chHyper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chHyper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chHyper.Location = new System.Drawing.Point(51, 196);
            this.chHyper.Name = "chHyper";
            this.chHyper.Size = new System.Drawing.Size(76, 24);
            this.chHyper.TabIndex = 3;
            this.chHyper.Text = "y = Vx";
            this.chHyper.UseVisualStyleBackColor = true;
            this.chHyper.CheckedChanged += new System.EventHandler(this.chHyper_CheckedChanged);
            // 
            // chCube
            // 
            this.chCube.AutoSize = true;
            this.chCube.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chCube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chCube.Location = new System.Drawing.Point(51, 157);
            this.chCube.Name = "chCube";
            this.chCube.Size = new System.Drawing.Size(86, 24);
            this.chCube.TabIndex = 2;
            this.chCube.Text = "y = x^3";
            this.chCube.UseVisualStyleBackColor = true;
            this.chCube.CheckedChanged += new System.EventHandler(this.chHyper_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 492);
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
            this.chSquare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chSquare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chSquare.Location = new System.Drawing.Point(51, 111);
            this.chSquare.Name = "chSquare";
            this.chSquare.Size = new System.Drawing.Size(86, 24);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nK)).EndInit();
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
        private CheckBox chLinear;
        private Label label1;
        private NumericUpDown nK;
        private Label label2;
        private NumericUpDown nB;
    }
}