using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOPP
{
	internal class Bank
	{
		//attribútomok
		private List<BankSzamla> szamlak= new List<BankSzamla>();
		//új számla létrehozása
		public void SzamlaLetrehoz(string tulajdonosNev, int kezdoEgyenleg)
		{
			BankSzamla ujSzanla=new BankSzamla(tulajdonosNev, kezdoEgyenleg);
			szamlak.Add(ujSzanla);
            Console.WriteLine($"Új számla létrehozva! {ujSzanla.GetSzamlaAdatok()}");
        }

		//számla keresés

		public BankSzamla SzamlaKeres(string szamlaSzam)
		{
			foreach (var szamla in szamlak)
			{
				if (szamla.SzamlaSzam == szamlaSzam)
				{
					return szamla;
				}
			}
			return null;
		}

		public void OsszesSzamlaAdatok()
		{ 
			if (szamlak.Count == 0)
			{
				Console.WriteLine("Nincs egyetlen számla rendszerben");

			}
			else {
                Console.WriteLine("Összes számla:");
                foreach (var szamla in szamlak)
				{
					Console.WriteLine(szamla.GetSzamlaAdatok());
				}
			}
			
		}
	}
}
