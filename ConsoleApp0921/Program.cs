using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
	class Time
	{
		int hours;
		int minutes;

		public Time(int minutes) : this(0,minutes){} // 분만 입력하려할때 간단하게 한줄로 하는법 this사용 
		public Time(int hours, int minutes)
		{
			this.hours = hours;
			this.minutes = minutes;
			#region 내방법
			//if (hours <= 24)
			//	this.hours = hours;
			//else
			//	Console.WriteLine("24아래의 숫자만 입력해주세요");
			//if (minutes <= 60)
			//	this.minutes = minutes;
			//else
			//	Console.WriteLine("60아래의 숫자만 입력해주세요.");
			#endregion
			Examine();
		}
		//유효성체크를 위한 메서드를 중복코드방지를 위해 메서드로 뽑아서 따로만듬
		private void Examine() //이미 넘겨받은 값을 쓰기 때문에 private 이여도 상관없음
		{
			if (hours < 0 || minutes < 0)
			{
				Console.WriteLine("올바르지 않은 입력값입니다.");
				return;
			}

			hours = hours + (minutes / 60);
			minutes = minutes % 60;
			
		}

		public override string ToString()
		{
			return this.hours + " : " + this.minutes;
		}

		public override bool Equals(object obj) 
		{
			return obj is Time time &&  //obj가 Time타입이면 time에 형변환해서 담아주고 아니면 false
				   hours == time.hours && //시간과 분이 같으면 true반환
				   minutes == time.minutes;
		}
		//public static bool operator ==(Time left, Time right)
		//{
		//	return EqualityComparer<Time>.Default.Equals(left, right);
		//}

		//public static bool operator !=(Time left, Time right)
		//{
		//	return !(left == right);
		//}

		//연산자 오버로드 (메서드 중복정의)
		private int TotalMinutes() // 시간과 분을 같이 연산할수 없어 만든 함수 시간을 분으로 바꿔서 더해줌
		{
			return hours * 60 + minutes;
		}
		public static Time operator + (Time t1, Time t2)
		{
			return new Time(t1.TotalMinutes() + t2.TotalMinutes());
		}
		public static Time operator ++ (Time t1)
		{
			return new Time(t1.TotalMinutes() + 1);
		}
		public static bool operator > (Time t1, Time t2) // 비교연산자는 true false로 반환받아야 하니 반환타입을 bool형으로
		{
			return t1.TotalMinutes() > t2.TotalMinutes();
		}
		public static bool operator <(Time t1, Time t2) // 작다를 하면 크다도 짝으로 만들어줘야함 
		{
			return t1.TotalMinutes() < t2.TotalMinutes();
		}


		#region 프로퍼티를 쓰는 방법
		//public int Hours 
		//{
		//	get { return hours; }
		//	set 
		//	{
		//		if (hours <= 24)
		//			hours = value;
		//		else
		//			Console.WriteLine("24아래의 숫자만 입력해주세요");
		//	} 
		//}
		//public int Minutes {
		//	get { return minutes; }
		//	set
		//	{
		//		if (minutes <= 60)
		//			minutes = value;
		//		else
		//			Console.WriteLine("60아래의 숫자만 입력해주세요.");
		//	}
		//}
		#endregion

	}


	class Program
	{
		static void Main(string[] args)
		{
			//Time 클래스를 정의한다.
			//int hour와 int minutes를 멤버로 갖는다
			//생성자(hour,minutes)

			Time t1 = new Time(11, 10);
			Console.WriteLine(t1.ToString());

			Time t2 = new Time(10, 70);
			Console.WriteLine(t2.Equals(t1));

			Time t3 = t1 + t2;
			Console.WriteLine(t3.ToString());

			Time t4 = ++t1; // 먼저 ++을하고 담아야 보이기때문에 전위연산자로 사용

			Console.WriteLine($"t4 = {t4}");

			Console.WriteLine(t1 > t2);
		}

	}
}
