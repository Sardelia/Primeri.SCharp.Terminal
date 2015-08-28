using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			bool _b = true;
//			bool _test =  5 > 10;
//			Console.WriteLine ( _b );
//			Console.WriteLine (_test);
			int[] _i = new int[] { 4, 3, 2 };
			int _ui = Convert.ToInt32(Console.ReadLine ());
//			bool _check01 = _ui <= _i.Length;
//			bool _check02 = _ui > 0;
//			Console.WriteLine (_check01);
//			Console.WriteLine (_check02);
//
//			bool _exp01 = _check01 && _check02;//логическо и &&
//			bool _exp02 = _check01 || _check02;// логическо или ||
//			bool _exp03 = !_check01;// отрицание !

//			Console.WriteLine (_i [_ui -1]);

//			Console.WriteLine ("Логическо и: " + _exp01.ToString());
//			Console.WriteLine ("Логичско или: " + _exp02.ToString());
//			Console.WriteLine ("Отрицание на " +  _check01.ToString() + ": " + _exp03);
			if (_ui > 0 && _ui <= _i.Length)
			{
				Console.WriteLine (_i [_ui - 1]);
			}
			else 
			{
				if (_ui > _i.Length) 
				{
					Console.WriteLine ("Индекса е прекалено голям!\n\n\n");
				}
				if (_ui <= 0)
				{
					Console.WriteLine ("Индекса е прекалено малък!\n\n\n");
				}
			}
		}
	}
}
