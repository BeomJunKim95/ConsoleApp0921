using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	class Point  //Ref타입
	{
		public int x = 0;
		public int y = 0;
	}
	class swap3
	{
		static void Swap(Point p1)  
		{
			int temp = p1.y;
			p1.y = p1.x;
			p1.x = temp;
		}
		static void Main()
		{
			Point p1 = new Point();
			p1.x = 3;
			p1.y = 5;

			Console.WriteLine($"x={p1.x}, y={p1.y}"); //3,5
			//Swap(p1);
			//Console.WriteLine($"x={p1.x}, y={p1.y}"); //5,3  : Ref타입은 call by value를 하더라도 넘긴값이 주소값이기 때문에 원본변수의 값이 바뀜

			//그럼 원본변수를 Ref타입이여도 call by value로 안바뀌게 하는 방법은??
			//그럼 인스턴스하나를 새로만들어 같은 곳을 가리키게 하지 않고 복사해서 새로운 인스턴스로 넘기면 된다 => 이걸 Deep Copy 라고 한다 
			Point p2 = new Point();
			p2.x = p1.x;
			p2.y = p1.y;
			Swap(p2);
			Console.WriteLine($"x={p1.x}, y={p1.y}"); //3,5
			Console.WriteLine($"x={p2.x}, y={p2.y}"); //5,3

		}
	}
}
