using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	class class1
	{
		//static int Divide(int x, int y, ref int mod) //ref
		//{
		//	mod = x % y;
		//	return x / y;
		//}
		static int Divide(int x, int y, out int mod) //out
		{
			mod = x % y;
			return x / y;
		}

		static void Main()
		{
			int x = 10;
			int y = 4;
			//int mod = 0;  //ref
			int mod;  //out


			//Console.WriteLine($"몫 : {Divide(x, y, ref mod)} 나머지 : {mod}");  //ref
			Console.WriteLine($"몫 : {Divide(x, y, out mod)} 나머지 : {mod}");  //out

			int result = Divide(x, y, out mod);
			Console.WriteLine($"몫 : {result} 나머지 : {mod}"); // 이런방법으로도 가능
		}
	}
}
