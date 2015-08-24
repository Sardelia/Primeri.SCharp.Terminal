using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = 0, b = 0, c = 0;
			Console.Write ("> a ="); a = System.Convert.ToDouble(Console.ReadLine ());

			Console.Write ("> b ="); b = System.Convert.ToDouble(Console.ReadLine ());
			//форматиране с дименсия
			string _format = "#0.00 m3";
			//степенуване
			Console.WriteLine (" \n\n > a / b = " + ( a/b ).ToString(_format));
			c = Math.Pow (a, b);
			Console.WriteLine (" \n\n > a ^ b = " + ( c ).ToString(_format));
			//коренуване
			c = Math.Sqrt ( b );
			Console.WriteLine (" \n\n > b ^ 1/2 = " + ( c ).ToString(_format));
			// закръгляне
			c = Math.Round( a/ b );
			Console.WriteLine (" \n\n > a / b = " +  c.ToString());
		}
	}
}
