using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOPP
{
	internal class BankSzamla
	{
		//Osztály attributomok
		//staticus változók lényege, hogy ne változik
		private static int kovSzamlaSzam = 1000;
		public string SzamlaSzam { get; private set; }
		public string TulajdonosNev { get; private set; }
		public int Egyenleg { get; private set; }

		//konstruktor
		//init=> kezdeti értéket adunk a változóknak

		public BankSzamla(string tulajdonosNev, int kezdoEgyenleg)
		{
			SzamlaSzam = $"ACC {kovSzamlaSzam++}";
			TulajdonosNev = tulajdonosNev;
			Egyenleg = kezdoEgyenleg;
		}

		//Befizet metódus
		public void Befizet(int osszeg)
		{
			if (osszeg > 0)
			{
				Egyenleg += osszeg;
				Console.WriteLine($"{osszeg} HUF befizetve a(z) {SzamlaSzam} számlára");
			} else
			{
                Console.WriteLine("Hibás összeg, nem lehet negatív vagy nulla.");
            }
		}

		public void Kifizet(int osszeg)
		{
			if (osszeg > 0 && osszeg <= Egyenleg)
			{
				Egyenleg -= osszeg;
				Console.WriteLine($"{osszeg} HUF kifizetve a(z) {SzamlaSzam} számlaszámról ");
			}
			else
			{
				Console.WriteLine("Hibás öszeg, nincs elég pénz a számláján");
			}
		}

		public string GetSzamlaAdatok() 
		{
			return $"Számlaszám: {SzamlaSzam}, Tulajdonos: {TulajdonosNev}, Egyenleg: {Egyenleg} HUF";
		}
	}
}
