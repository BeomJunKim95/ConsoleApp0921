using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	abstract class Person
	{
		public abstract void Speak(); //추상메서드를 정의하려면 클래스도 추상클래스로 정의해애함
									  //추상메서드가 하나라도 없으면 추상클래스를 정의할수 없음
		//{
		//	Console.WriteLine("말을 합니다.");
		//}
		public void Work()
		{
			Console.WriteLine("일을 합니다.");
		}
		public void Study()
		{
			Console.WriteLine("공부를 합니다.");
		}
	}

	class Employee : Person //추상클래스가 부모면 자식클래스에서 추상메서드를 반드시 정의 해줘야함
	{
		public override void Speak() //반드시 오버라이드 해야함
		{
			Console.WriteLine("Employee가 일을 합니다.");
		}
	}

	class Abstract_Practice
	{
		static void Main()
		{
			Employee p1 = new Employee();
			p1.Speak();
		}
	}
}
