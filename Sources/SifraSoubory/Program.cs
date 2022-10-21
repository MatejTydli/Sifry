using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SifraSoubory
{
	class Program // C:\Users\matej\Documents\text.txt
	{
		static string path;
		static string readedtext;

		static string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
		static string symbols = "@$?!*°/|_.:,;~+-=";
		static string lettersAndSymbols = letters + symbols;

		static StreamReader fileReader;
		static StreamWriter fileWriter;

		static List<byte[]> cryptedText = new List<byte[]>();

		static List<char> decryptedText = new List<char>();

		static uint key;

		static bool next = true;

		static void Main(string[] args)
		{
			do
			{
				try
				{
					Console.Write("Chcete sifrovat/desifrovat (s/d): ");
					char sd = Console.ReadKey().KeyChar.ToString().ToLower()[0];
					Console.WriteLine();

					if (sd == 's')
					{
						path = getPath();
						key = getKey();
						setFile();
						crypt();
					}
					else if (sd == 'd')
					{
						path = getPath();
						key = getKey();
						setFile();
						decrypt();
					}
					else
					{
						throw new Exception("Spatne zadany vztup.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine();
					Console.WriteLine("Nastala neocekavana vyjimka, program bude zpusten znova.");
					Console.WriteLine("Chybova zprava (nekdy v anglictine): {0}", e.Message);
				}
				finally
				{
					Finally();
				}
			} while (next);
		}

		private static string getPath()
		{
			Console.WriteLine();
			Console.Write("Napiste cestu k souboru ktery chcete zasifrovat/desifrovat: ");
			return @$"{Console.ReadLine()}";
		}

		private static uint getKey()
		{
			Console.WriteLine();
			Console.Write("Napiste klic k zasifrovani/desifrovani (kladne cislo): ");
			return Convert.ToUInt32(Console.ReadLine());
		}

		private static void setFile()
		{
			fileReader = new StreamReader(path);
			readedtext = fileReader.ReadToEnd();
			fileReader.Close();

			fileWriter = new StreamWriter(path);
		}

		private static void crypt()
		{
			cryptedText.Clear();

			foreach (char charInLine in readedtext)
			{
				cryptedText.Add(Encoding.UTF8.GetBytes(new string(new char[] { charInLine })));
			}

			Random random = new Random();
			foreach (byte[] textBytes in cryptedText)
			{
				int letterOrSymbol = random.Next(10);
				int symbolIndex = random.Next(symbols.Length);
				int letterIndex = random.Next(letters.Length);

				uint charNumber;
				switch (textBytes.Length)
				{
					case 1:
						charNumber = Convert.ToUInt32(textBytes[0]);
						break;

					case 2:
						charNumber = BitConverter.ToUInt32(new byte[] { textBytes[0], textBytes[1], 0, 0 });
						break;

					case 3:
						charNumber = BitConverter.ToUInt32(new byte[] { textBytes[0], textBytes[1], textBytes[2], 0 });
						break;

					case 4:
						charNumber = BitConverter.ToUInt32(new byte[] { textBytes[0], textBytes[1], textBytes[2], textBytes[3] });
						break;

					default:
						throw new Exception($"{textBytes.Length} - Nedefinovana delka bytu.");
				}

				if (letterOrSymbol <= 8)
				{
					fileWriter.Write((charNumber * key).ToString() + symbols[symbolIndex]);
				}
				else
				{
					fileWriter.Write((charNumber * key).ToString() + symbols[symbolIndex]);
				}
			}
			fileWriter.Close();
		}

		private static void decrypt()
		{
			decryptedText.Clear();

			foreach (char charInCrypt in readedtext)
			{
				if (readedtext.Split(charInCrypt).Length < 2)
				{
					break;
				}


				foreach (char letter in lettersAndSymbols)
				{
					if (charInCrypt == letter)
					{
						byte[] decryptedCharBytes = BitConverter.GetBytes(Convert.ToUInt32(readedtext.Split(charInCrypt)[0]) / key);
						decryptedText.Add(Encoding.UTF8.GetString(decryptedCharBytes)[0]);

						readedtext = readedtext.Substring(readedtext.Split(charInCrypt)[0].Length + 1);

						break;
					}
				}
			}

			foreach (char charInDecryptedText in decryptedText)
			{
				fileWriter.Write(charInDecryptedText);
			}

			fileWriter.Close();
		}

		private static void Finally()
		{
			try
			{
				Console.WriteLine();
				Console.Write("Chcete provest dalsi desifrovani/sifrovani? (ano/ne): ");
				string chceteDalsiVypocet = Console.ReadLine().ToLower();

				if (chceteDalsiVypocet == "ano" || chceteDalsiVypocet == "a" || chceteDalsiVypocet == "yes" || chceteDalsiVypocet == "y")
				{
					Console.WriteLine();
					Console.Write("Chcete vymazat vsechen text na konzoli? (ano/ne): ");
					string chceteVymazatKonzoli = Console.ReadLine().ToLower();

					if (chceteVymazatKonzoli == "ano" || chceteVymazatKonzoli == "a" || chceteVymazatKonzoli == "yes" || chceteVymazatKonzoli == "y")
					{
						Console.Clear();
					}
					else if (chceteVymazatKonzoli == "ne" || chceteVymazatKonzoli == "n" || chceteVymazatKonzoli == "no")
					{
						Console.WriteLine();
					}
					else
					{
						throw new Exception("Spatne zadany vztup.");
					}
				}
				else if (chceteDalsiVypocet == "ne" || chceteDalsiVypocet == "n" || chceteDalsiVypocet == "no")
				{
					next = false;
				}
				else
				{
					throw new Exception("Spatne zadany vztup.");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine();
				Console.WriteLine("Doslo k neocekavane vyjimce a spadnuti programu, muze byt zpusobeno spatne zadanym vstupem.");
				Console.WriteLine("Chybova hlazka (nekdy v anglictine): " + e.Message);
				Finally();
			}
		}
	}
}