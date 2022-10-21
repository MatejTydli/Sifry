
namespace SifraApp
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
			this.btStart1 = new System.Windows.Forms.Button();
			this.btStart2 = new System.Windows.Forms.Button();
			this.txtVystup = new System.Windows.Forms.TextBox();
			this.btSifraDesifra = new System.Windows.Forms.Button();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.txtVstup = new System.Windows.Forms.TextBox();
			this.btProhodit = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.chbVstup = new System.Windows.Forms.CheckBox();
			this.chbVystup = new System.Windows.Forms.CheckBox();
			this.lbl4 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.lsbKlic = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btStart1
			// 
			this.btStart1.Location = new System.Drawing.Point(147, 12);
			this.btStart1.Name = "btStart1";
			this.btStart1.Size = new System.Drawing.Size(129, 42);
			this.btStart1.TabIndex = 0;
			this.btStart1.Text = "Start sifra";
			this.btStart1.UseVisualStyleBackColor = true;
			this.btStart1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btStart2
			// 
			this.btStart2.Location = new System.Drawing.Point(393, 12);
			this.btStart2.Name = "btStart2";
			this.btStart2.Size = new System.Drawing.Size(129, 42);
			this.btStart2.TabIndex = 1;
			this.btStart2.Text = "Start desifra";
			this.btStart2.UseVisualStyleBackColor = true;
			this.btStart2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtVystup
			// 
			this.txtVystup.Enabled = false;
			this.txtVystup.Location = new System.Drawing.Point(147, 255);
			this.txtVystup.Multiline = true;
			this.txtVystup.Name = "txtVystup";
			this.txtVystup.Size = new System.Drawing.Size(375, 99);
			this.txtVystup.TabIndex = 3;
			this.txtVystup.Visible = false;
			this.txtVystup.TextChanged += new System.EventHandler(this.txtVystup_TextChanged);
			// 
			// btSifraDesifra
			// 
			this.btSifraDesifra.Cursor = System.Windows.Forms.Cursors.Default;
			this.btSifraDesifra.Enabled = false;
			this.btSifraDesifra.Location = new System.Drawing.Point(528, 171);
			this.btSifraDesifra.Name = "btSifraDesifra";
			this.btSifraDesifra.Size = new System.Drawing.Size(129, 42);
			this.btSifraDesifra.TabIndex = 4;
			this.btSifraDesifra.UseVisualStyleBackColor = true;
			this.btSifraDesifra.Visible = false;
			this.btSifraDesifra.Click += new System.EventHandler(this.btSifraDesifra_Click);
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Enabled = false;
			this.lbl2.Location = new System.Drawing.Point(12, 114);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(135, 13);
			this.lbl2.TabIndex = 5;
			this.lbl2.Text = "Vstup[ piste bez diakritiky ]:";
			this.lbl2.Visible = false;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(15, 12);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(31, 13);
			this.lbl1.TabIndex = 6;
			this.lbl1.Text = "Mod:";
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Enabled = false;
			this.lbl3.Location = new System.Drawing.Point(15, 255);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(42, 13);
			this.lbl3.TabIndex = 7;
			this.lbl3.Text = "Vystup:";
			this.lbl3.Visible = false;
			// 
			// txtVstup
			// 
			this.txtVstup.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtVstup.Enabled = false;
			this.txtVstup.Location = new System.Drawing.Point(147, 114);
			this.txtVstup.Multiline = true;
			this.txtVstup.Name = "txtVstup";
			this.txtVstup.Size = new System.Drawing.Size(375, 99);
			this.txtVstup.TabIndex = 2;
			this.txtVstup.Visible = false;
			this.txtVstup.WordWrap = false;
			this.txtVstup.TextChanged += new System.EventHandler(this.txtVstup_TextChanged);
			// 
			// btProhodit
			// 
			this.btProhodit.Enabled = false;
			this.btProhodit.Location = new System.Drawing.Point(273, 219);
			this.btProhodit.Name = "btProhodit";
			this.btProhodit.Size = new System.Drawing.Size(125, 23);
			this.btProhodit.TabIndex = 8;
			this.btProhodit.Text = "Prohodit";
			this.btProhodit.UseVisualStyleBackColor = true;
			this.btProhodit.Visible = false;
			this.btProhodit.Click += new System.EventHandler(this.btProhodit_Click);
			// 
			// btClose
			// 
			this.btClose.Location = new System.Drawing.Point(528, 312);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(129, 42);
			this.btClose.TabIndex = 9;
			this.btClose.Text = "Ukoncit";
			this.btClose.UseVisualStyleBackColor = true;
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// chbVstup
			// 
			this.chbVstup.AutoSize = true;
			this.chbVstup.Checked = true;
			this.chbVstup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbVstup.Enabled = false;
			this.chbVstup.Location = new System.Drawing.Point(393, 89);
			this.chbVstup.Name = "chbVstup";
			this.chbVstup.Size = new System.Drawing.Size(222, 17);
			this.chbVstup.TabIndex = 10;
			this.chbVstup.Text = "Po přehození módu nevymazávat (Vstup)";
			this.chbVstup.UseVisualStyleBackColor = true;
			this.chbVstup.Visible = false;
			// 
			// chbVystup
			// 
			this.chbVystup.AutoSize = true;
			this.chbVystup.Checked = true;
			this.chbVystup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbVystup.Enabled = false;
			this.chbVystup.Location = new System.Drawing.Point(393, 71);
			this.chbVystup.Name = "chbVystup";
			this.chbVystup.Size = new System.Drawing.Size(227, 17);
			this.chbVystup.TabIndex = 11;
			this.chbVystup.Text = "Po přehození módu nevymazávat (Vystup)";
			this.chbVystup.UseVisualStyleBackColor = true;
			this.chbVystup.Visible = false;
			// 
			// lbl4
			// 
			this.lbl4.AutoSize = true;
			this.lbl4.Location = new System.Drawing.Point(15, 55);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(125, 13);
			this.lbl4.TabIndex = 12;
			this.lbl4.Text = "Sifrační / Desifrační klíč";
			this.lbl4.Visible = false;
			// 
			// lbl5
			// 
			this.lbl5.AutoSize = true;
			this.lbl5.Location = new System.Drawing.Point(68, 72);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(72, 13);
			this.lbl5.TabIndex = 14;
			this.lbl5.Text = "min 1, max 51";
			this.lbl5.Visible = false;
			// 
			// lsbKlic
			// 
			this.lsbKlic.Enabled = false;
			this.lsbKlic.FormattingEnabled = true;
			this.lsbKlic.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51"});
			this.lsbKlic.Location = new System.Drawing.Point(18, 72);
			this.lsbKlic.Name = "lsbKlic";
			this.lsbKlic.Size = new System.Drawing.Size(39, 43);
			this.lsbKlic.TabIndex = 15;
			this.lsbKlic.Visible = false;
			this.lsbKlic.SelectedIndexChanged += new System.EventHandler(this.lsbKlic_SelectedIndexChanged_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 380);
			this.Controls.Add(this.lsbKlic);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.lbl4);
			this.Controls.Add(this.chbVystup);
			this.Controls.Add(this.chbVstup);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btProhodit);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.btSifraDesifra);
			this.Controls.Add(this.txtVystup);
			this.Controls.Add(this.txtVstup);
			this.Controls.Add(this.btStart2);
			this.Controls.Add(this.btStart1);
			this.Name = "Form1";
			this.Text = "SifraApp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btStart1;
		private System.Windows.Forms.Button btStart2;
		private System.Windows.Forms.TextBox txtVystup;
		private System.Windows.Forms.Button btSifraDesifra;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.TextBox txtVstup;
		private System.Windows.Forms.Button btProhodit;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.CheckBox chbVstup;
		private System.Windows.Forms.CheckBox chbVystup;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.ListBox lsbKlic;
	}
}

