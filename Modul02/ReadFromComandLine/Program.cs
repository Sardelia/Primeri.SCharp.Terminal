using System;

namespace ReadFromComandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write("Моля, въведете а: ");
			b = Convert.ToInt32(Console.ReadLine());

			//Печат на резултат
			Console.WriteLine ("Резултата а + в е  " +(a + b).ToString() + "\n\n\n");
			string test = "1";
			test += ", 2";
			test += ", 3";
			test += ", 4";
			test += ", 5";
			Console.WriteLine ("Събиране с += : " + test + "\n");

			test = test.Replace (", ","; " );
			Console.WriteLine ("Работа с Replace: " + test + "\n");
			//ще видим кой е третия знак от масива, нарича се парсване а командата е сплит
			Console.WriteLine ("Третия знак е: " + test.Split(';')[2]);

		}
	}
}
