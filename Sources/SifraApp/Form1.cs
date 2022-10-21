using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SifraApp
{
	public partial class Form1 : Form
	{
		private bool lsbKlicTextVhodny;
		private int lsbKlicTextInt;
		private string lsbKlickTextString;

		public Form1()
		{
			InitializeComponent();
		}

		public void button1_Click(object sender, EventArgs e)
		{
			btStart1.Enabled = false;
			btStart2.Enabled = true;

			Nastav();
			VymazVystupVstup();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			btStart2.Enabled = false;
			btStart1.Enabled = true;

			Nastav();
			VymazVystupVstup();
		}

		private void btSifraDesifra_Click(object sender, EventArgs e)
		{
			if (btSifraDesifra.Text == "Sifrovat")
			{
				txtVystup.Text = Sifruj(txtVstup.Text, lsbKlicTextInt);

			}
			else if (btSifraDesifra.Text == "Desifrovat")
			{
				txtVystup.Text = DeSifruj(txtVstup.Text, lsbKlicTextInt);
			}
		}

		private void btClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btProhodit_Click(object sender, EventArgs e)
		{
			string textprohodit1 = txtVstup.Text;
			string textprohodit2 = txtVystup.Text;

			txtVstup.Text = textprohodit2;
			txtVystup.Text = textprohodit1;

		}
		public void txtVstup_TextChanged(object sender, EventArgs e)
		{
			NastavText();
		}

		public void txtVystup_TextChanged(object sender, EventArgs e)
		{
			NastavText();
		}
		private void lsbKlic_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			NastavText();
		}
		private void Nastav()
		{
			lsbKlic.Enabled = true;

			chbVstup.Enabled = true;
			chbVystup.Enabled = true;

			lbl2.Enabled = true;

			txtVstup.Enabled = true;

			lsbKlic.Visible = true;

			chbVstup.Visible = true;
			chbVystup.Visible = true;

			lbl2.Visible = true;
			lbl3.Visible = true;
			lbl4.Visible = true;
			lbl5.Visible = true;

			btSifraDesifra.Visible = true;

			btProhodit.Visible = true;

			txtVstup.Visible = true;
			txtVystup.Visible = true;

			if (btStart1.Enabled == true)
			{
				btSifraDesifra.Text = "Desifrovat";
			}
			else
			{
				btSifraDesifra.Text = "Sifrovat";
			}

			if (txtVstup.Text != "")
			{
				btSifraDesifra.Enabled = true;
			}
			else
			{
				btSifraDesifra.Enabled = false;
			}

			if (txtVstup.Text != "" || txtVystup.Text != "")
			{
				btProhodit.Enabled = true;
				lbl3.Enabled = true;
			}
			else
			{
				btProhodit.Enabled = false;
				lbl3.Enabled = false;
			}
		}
		private void NastavText()
		{
			lsbKlickTextString = lsbKlic.Text;

			lsbKlicTextVhodny = Int32.TryParse(lsbKlickTextString, out lsbKlicTextInt);
			if (txtVstup.Text != "" && lsbKlicTextVhodny == true)
			{
				txtVystup.Enabled = true;
				btSifraDesifra.Enabled = true;
			}
			else
			{
				btSifraDesifra.Enabled = false;
				if (txtVystup.Text != "")
				{
					txtVystup.Enabled = true;
				}
				else
				{
					txtVystup.Enabled = false;
				}
			}

			if (txtVstup.Text != "" || txtVystup.Text != "")
			{
				btProhodit.Enabled = true;
				lbl3.Enabled = true;
			}
			else
			{
				btProhodit.Enabled = false;
				lbl3.Enabled = false;
			}
		}
		private void VymazVystupVstup()
		{
			if (chbVstup.Checked == false)
			{
				txtVstup.Text = "";	
			}

			if (chbVystup.Checked == false)
			{
				txtVystup.Text = "";

				txtVystup.Enabled = false;
			}
		}
		private static string Sifruj(string text, int posun)
		{
			string sifrovanyText = "";

			string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			char[] abecedaPole = abeceda.ToCharArray();

			char[] textJakoPole = text.ToCharArray();

			int delka = text.Length;
			for (int ii = 0; ii < delka; ii++)
			{
				char znak = textJakoPole[ii];
				int indexZnaku = abeceda.IndexOf(znak);

				if (indexZnaku == -1)
				{
					// neznamy znak nebudeme sifrovat
					sifrovanyText = sifrovanyText + znak;
				}
				else
				{
					int posunutyIndex = indexZnaku + posun;

					if (!(abecedaPole.Length > posunutyIndex))
					{
						posunutyIndex = posunutyIndex - abecedaPole.Length;
					}

					sifrovanyText = sifrovanyText + abecedaPole[posunutyIndex];
				}
			}
			return sifrovanyText;
		}
		static string DeSifruj(string text, int posun)
		{
			string deSifrovanyText = "";

			string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			char[] abecedaPole = abeceda.ToCharArray();

			char[] textJakoPole = text.ToCharArray();

			int delka = text.Length;
			for (int ii = 0; ii < delka; ii++)
			{
				char znak = textJakoPole[ii];
				int indexZnaku = abeceda.IndexOf(znak);

				if (indexZnaku == -1)
				{
					// neznamy znak nebudeme desifrovat
					deSifrovanyText = deSifrovanyText + znak;
				}
				else
				{
					int posunutyIndex = indexZnaku - posun;

					if (posunutyIndex < 0)
					{
						posunutyIndex = posunutyIndex + abecedaPole.Length;
					}

					deSifrovanyText = deSifrovanyText + abecedaPole[posunutyIndex];
				}
			}
			return deSifrovanyText;
		}
	}
}