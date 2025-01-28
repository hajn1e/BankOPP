namespace BankOPP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bank bank = new Bank();
			bool fut=true;

			while (fut)
			{
				Console.WriteLine("1. Új számla létrehozása");
				Console.WriteLine("2. Befizetés");
				Console.WriteLine("3. Kifizetés");
				Console.WriteLine("4. Egy számla adatai");
				Console.WriteLine("5. Összes számla listázása");
				Console.WriteLine("6. Kilépés");
                Console.WriteLine("Válasz egy lehetőséget");

				int opcio=Convert.ToInt32(Console.ReadLine());

				switch (opcio)
				{
					case 1:
						Console.WriteLine("Adja meg a tulajdonos nevét:");
						string tulajdonosNev = Console.ReadLine();
						Console.WriteLine("Adja meg a kezdő egyenleget:");
						int kezdoEgyenleg = Convert.ToInt32(Console.ReadLine());
						bank.SzamlaLetrehoz(tulajdonosNev, kezdoEgyenleg);
						break;
					case 2:
						Console.WriteLine("Adja meg a számlaszámot:");
						string szamlaSzamBefizet = Console.ReadLine();
						var szamlaBefizet = bank.SzamlaKeres(szamlaSzamBefizet);
						if (szamlaBefizet != null)
						{
							Console.WriteLine("Adja meg a befizetendő összeget:");
							int osszegBefizet = Convert.ToInt32(Console.ReadLine());
							szamlaBefizet.Befizet(osszegBefizet);
						}
						else
						{
							Console.WriteLine("Nincs ilyen számla");
						}
						break;
            }
			Console.ReadLine();
		}
	}
}
