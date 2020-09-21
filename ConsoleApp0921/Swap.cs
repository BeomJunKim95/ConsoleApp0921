using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	class MyCalc
	{

	}

	class swap
	{
		#region 첫번째 방법 (전역변수)
		//static int x = 3; // 전역변수로 빼게 되면 클래스가 끝날때 까지 사라지지않아 좋지않음
		//static int y = 5; // 변수는 가장 짧게 메모리에 있는 경우가 가장 좋음, 가능한 쓰지 않는게 좋음

		//static void Swap()
		//{
		//	int temp = y; // 임시변수를 하나 둬야 둘이 바꿀수있음
		//	y = x;
		//	x = temp;

		//}
		#endregion

		#region 두번째 방법 (매개변수)
		static void Swap(int a, int b) // call by value
									   // 메소드 호출 시 데이터를 복사해 매개 변수에 전달
		{
			int temp = b; // 임시변수를 하나 둬야 둘이 바꿀수있음
			b = a;
			a = temp;

			Console.WriteLine($"x={a}, y={b}"); // 5,3
		}
		//static void Swap(out int a, out int b) // out 은 호출한 사람이 값을 줬던 안줬던 메서드 안에서 초기값을 주고 시작함 
		//									   // 초기값을 할당해 주어야 가능한 ref와 다르게 할당 안되도 넘길수있다
		//									   // 출력전용에 의한 전달
		//{
		//	a = 3;
		//	b = 7;
		//	int temp = b; // 임시변수를 하나 둬야 둘이 바꿀수있음
		//	b = a;
		//	a = temp;

		//	Console.WriteLine($"x={a}, y={b}"); // 5,3
		//}
		static void Swap(ref int a, ref int b) // call by ref : 변수의 값이 아니라 주소값을 주는것 (반드시 초기값을 설정해줘야 쓸수있다)
											   //				  메소드 호출 시 직접 원본 변수의 값을 바꾸는 방법
											   //               매개변수 앞에 ref를 붙여주고 호출할때도 ref를 붙여준다
											   // 둘이 시그니쳐가 달라 ref를 붙이면 오버라이드가 가능 하지만 out은 ref랑 같아 중복이 불가능하다
		{
			int temp = b;					   //주는 값이 주소값이면 값이 나올때 까지 따라가서 그값을 바꿔줌
			b = a;
			a = temp;

			Console.WriteLine($"x={a}, y={b}"); // 5,3
		}
		#endregion
		static void Main()
		{
			int x = 3;
			int y = 5;

			//Console.WriteLine($"x={x}, y={y}"); // 3,5

			//Swap(); //첫번째 방법 (전역변수)
			//Swap(x,y); // call by value
			//Swap(out x, out y); // out은 ref와 오버라이드 불가
			Swap(ref x, ref y); // call by ref : 호출할때도 앞에 ref를 붙여주면 call by ref완성

			Console.WriteLine($"x={x}, y={y}"); // 3,5 
												//call by value 로 인해 메서드 안에 매개변수는 메서드가 끝나면 사라지기 때문에 
												//call by value는 이코드의  x,y는 값이 바뀌지 않음
		}
	}
}
