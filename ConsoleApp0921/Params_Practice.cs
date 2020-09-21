using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	class Params_Practice
	{
		static int SumParams(params int[] arr) // 형식은 같으나 매개 변수의 개수만 유연하게 달라질 수 있는 경우에 적합.
											   // params 키워드와 배열 이용
		{
			int tot = 0;
			foreach (int num in arr)
			{
				tot += num;
			}
			return tot;
		}
		static int Sum(int[] arr) // 이방법으로 여러개의 매개변수를 쓸수있지만 매번 배열을 선언해줘야하는 단점이있음
		{
			int tot = 0;
			foreach(int num in arr)
			{
				tot += num;
			}
			return tot;
		}
		static int Sum(int a, int b)
		{
			return a + b;
		}
		static int Sum(int a, int b, int c, int d)
		{
			return a + b + c + d;
		}
		static void Main()
		{
			Sum(3, 5);
			int[] arr = new int[5] { 1, 2, 3, 4, 5 };
			int result = Sum(arr);
			Console.WriteLine(result);

			Console.WriteLine(Sum(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

			Console.WriteLine(SumParams(1,2,3,4,5,6,7,8,9,10));
		}
	}
}
