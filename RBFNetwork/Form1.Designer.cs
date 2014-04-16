namespace MultilayerPerceptron
{
	using System.Security.AccessControl;

	partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxLetter = new System.Windows.Forms.ComboBox();
            this.comboBoxPercentOfNoise = new System.Windows.Forms.ComboBox();
            this.buttonGenerateNoise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxK = new System.Windows.Forms.PictureBox();
            this.pictureBoxL = new System.Windows.Forms.PictureBox();
            this.pictureBoxM = new System.Windows.Forms.PictureBox();
            this.pictureBoxN = new System.Windows.Forms.PictureBox();
            this.labelK = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxN)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.51625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27076F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLetter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPercentOfNoise, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonGenerateNoise, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonStart, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(563, 93);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // comboBoxLetter
            // 
            this.comboBoxLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLetter.FormattingEnabled = true;
            this.comboBoxLetter.Items.AddRange(new object[] {
            "К",
            "Л",
            "М",
            "Н"});
            this.comboBoxLetter.Location = new System.Drawing.Point(3, 49);
            this.comboBoxLetter.Name = "comboBoxLetter";
            this.comboBoxLetter.Size = new System.Drawing.Size(180, 21);
            this.comboBoxLetter.TabIndex = 0;
            this.comboBoxLetter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxPercentOfNoise
            // 
            this.comboBoxPercentOfNoise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPercentOfNoise.FormattingEnabled = true;
            this.comboBoxPercentOfNoise.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBoxPercentOfNoise.Location = new System.Drawing.Point(189, 49);
            this.comboBoxPercentOfNoise.Name = "comboBoxPercentOfNoise";
            this.comboBoxPercentOfNoise.Size = new System.Drawing.Size(227, 21);
            this.comboBoxPercentOfNoise.TabIndex = 1;
            this.comboBoxPercentOfNoise.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonGenerateNoise
            // 
            this.buttonGenerateNoise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerateNoise.Location = new System.Drawing.Point(422, 49);
            this.buttonGenerateNoise.Name = "buttonGenerateNoise";
            this.buttonGenerateNoise.Size = new System.Drawing.Size(138, 41);
            this.buttonGenerateNoise.TabIndex = 2;
            this.buttonGenerateNoise.Text = "Generate noise";
            this.buttonGenerateNoise.UseVisualStyleBackColor = true;
            this.buttonGenerateNoise.Click += new System.EventHandler(this.buttonGenerateNoise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select letter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(189, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Percent of noise:";
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Location = new System.Drawing.Point(422, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(138, 40);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxOriginal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(563, 234);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxOriginal.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(275, 228);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxK, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxL, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxM, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxN, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelK, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelL, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelM, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelN, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(284, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(276, 228);
            this.tableLayoutPanel4.TabIndex = 2;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // pictureBoxK
            // 
            this.pictureBoxK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxK.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxK.Name = "pictureBoxK";
            this.pictureBoxK.Size = new System.Drawing.Size(63, 108);
            this.pictureBoxK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxK.TabIndex = 0;
            this.pictureBoxK.TabStop = false;
            // 
            // pictureBoxL
            // 
            this.pictureBoxL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxL.Location = new System.Drawing.Point(72, 3);
            this.pictureBoxL.Name = "pictureBoxL";
            this.pictureBoxL.Size = new System.Drawing.Size(63, 108);
            this.pictureBoxL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL.TabIndex = 1;
            this.pictureBoxL.TabStop = false;
            // 
            // pictureBoxM
            // 
            this.pictureBoxM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxM.Location = new System.Drawing.Point(141, 3);
            this.pictureBoxM.Name = "pictureBoxM";
            this.pictureBoxM.Size = new System.Drawing.Size(63, 108);
            this.pictureBoxM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxM.TabIndex = 2;
            this.pictureBoxM.TabStop = false;
            // 
            // pictureBoxN
            // 
            this.pictureBoxN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxN.Location = new System.Drawing.Point(210, 3);
            this.pictureBoxN.Name = "pictureBoxN";
            this.pictureBoxN.Size = new System.Drawing.Size(63, 108);
            this.pictureBoxN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxN.TabIndex = 3;
            this.pictureBoxN.TabStop = false;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelK.Location = new System.Drawing.Point(3, 114);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(63, 114);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "K:";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(72, 114);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(16, 13);
            this.labelL.TabIndex = 5;
            this.labelL.Text = "L:";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(141, 114);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(19, 13);
            this.labelM.TabIndex = 6;
            this.labelM.Text = "M:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(210, 114);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(18, 13);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "lab 4 RBFNetwork";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxN)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBoxOriginal;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ComboBox comboBoxLetter;
		private System.Windows.Forms.ComboBox comboBoxPercentOfNoise;
		private System.Windows.Forms.Button buttonGenerateNoise;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBoxK;
        private System.Windows.Forms.PictureBox pictureBoxL;
        private System.Windows.Forms.PictureBox pictureBoxM;
        private System.Windows.Forms.PictureBox pictureBoxN;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelN;
	}
}

