namespace SyllableParser_TR
{
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHecele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHeceSayisi = new System.Windows.Forms.TextBox();
            this.tbGirilenMetin = new System.Windows.Forms.RichTextBox();
            this.tbHeceler = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hecelerine ayırmak istediğiniz cümleyi girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hece Sayısı:";
            // 
            // btnHecele
            // 
            this.btnHecele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHecele.Location = new System.Drawing.Point(374, 13);
            this.btnHecele.Margin = new System.Windows.Forms.Padding(4);
            this.btnHecele.Name = "btnHecele";
            this.btnHecele.Size = new System.Drawing.Size(130, 29);
            this.btnHecele.TabIndex = 3;
            this.btnHecele.Text = "Hecele";
            this.btnHecele.UseVisualStyleBackColor = true;
            this.btnHecele.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heceler:";
            // 
            // tbHeceSayisi
            // 
            this.tbHeceSayisi.Location = new System.Drawing.Point(112, 13);
            this.tbHeceSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.tbHeceSayisi.Name = "tbHeceSayisi";
            this.tbHeceSayisi.Size = new System.Drawing.Size(89, 27);
            this.tbHeceSayisi.TabIndex = 5;
            // 
            // tbGirilenMetin
            // 
            this.tbGirilenMetin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGirilenMetin.AutoWordSelection = true;
            this.tbGirilenMetin.DetectUrls = false;
            this.tbGirilenMetin.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGirilenMetin.Location = new System.Drawing.Point(12, 33);
            this.tbGirilenMetin.Name = "tbGirilenMetin";
            this.tbGirilenMetin.Size = new System.Drawing.Size(492, 191);
            this.tbGirilenMetin.TabIndex = 7;
            this.tbGirilenMetin.Text = "";
            this.tbGirilenMetin.TextChanged += new System.EventHandler(this.tbGirilenMetin_TextChanged);
            // 
            // tbHeceler
            // 
            this.tbHeceler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeceler.DetectUrls = false;
            this.tbHeceler.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHeceler.Location = new System.Drawing.Point(12, 67);
            this.tbHeceler.Name = "tbHeceler";
            this.tbHeceler.Size = new System.Drawing.Size(492, 199);
            this.tbHeceler.TabIndex = 8;
            this.tbHeceler.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbGirilenMetin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tbHeceler);
            this.splitContainer1.Panel2.Controls.Add(this.tbHeceSayisi);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnHecele);
            this.splitContainer1.Size = new System.Drawing.Size(516, 525);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 549);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Türkçe Sözcük Heceleme Yazılımı";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnHecele;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHeceSayisi;
        private System.Windows.Forms.RichTextBox tbGirilenMetin;
        private System.Windows.Forms.RichTextBox tbHeceler;
        private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

