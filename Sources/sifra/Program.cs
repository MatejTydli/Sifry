using System;

namespace sifra
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Pokud chcete sifrovat napite \"s\" a pokud desifrovat tak \"d\" : ");
			
			ConsoleKeyInfo keyInfo = Console.ReadKey();

			//string sifraDesifra = Console.ReadLine();

			char sifraDesifra = keyInfo.KeyChar;
			switch (sifraDesifra)
			{
				case 's':
					Console.WriteLine(" Napiste \"text na zasifrovani\" max x znaku piste bez diakrityky: ");

					string zadanyText = Console.ReadLine();
					Console.WriteLine("Napsali jste: {0}", zadanyText);

					string sifrovanyText = Sifruj(zadanyText);
					Console.WriteLine("Zasifrovany text: {0}", sifrovanyText);
					Console.ReadKey();

					break;
				case 'd':
					Console.WriteLine(" Napiste \"text na desifrovani\" max x znaku \"[Pouze napiste sifrovany text z tohoto programu]\": ");

					string zadanyText2 = Console.ReadLine();
					Console.WriteLine("Napsali jste: {0}", zadanyText2);

					string deSifrovanyText = DeSifruj(zadanyText2);
					Console.WriteLine("Zasifrovany text: {0}", deSifrovanyText);
					Console.ReadKey();

					break;
				default:
					Console.WriteLine("neplatny vstup");
					Console.ReadKey();
					break;

			}
		}
		static string Sifruj(string text)
		{
			const int posun = 4;
			
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
		static string DeSifruj(string text)
		{
			const int posun = 4;

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
					// neznamy znak nebudeme sifrovat
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
