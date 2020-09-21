using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	class swap2
	{
		static void ChangeWord(string arg)  
		{
			arg = "World";
		}
		static void ChangeWord(ref string arg)
		{
			arg = "World";
		}
		static void Main()
		{
			string str = "Hello";

			ChangeWord(str);
			Console.WriteLine(str);  //Hello

			ChangeWord(ref str);
			Console.WriteLine(str); //World 
			//string은 불변타입의 레퍼런스 타입이라 자동으로 인스턴스 하나가 생성되서 밸류로 넘어간다해도 원본변수가 변하지 않는것
		}
	}
}
