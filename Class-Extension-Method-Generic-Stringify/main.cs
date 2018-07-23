using System;
using System.Collections.Generic;

public static class ExClass{
	/*
	public static string Stringify<T>(this List<T> list){	//자기가 확장되어야 할 클래스가(또는 타입) 뭔지 알려줌; 뒤에 컴마 들어가면 거기가 첫번째 인자.
		string s = string.Empty;
		for(int i = 0; i < list.Count; ++i)
			s += i != list.Count-1 ? list[i] + " " : list[i].ToString();
		return s;
	}

	public static string Stringify(this int[] list){
		string s = string.Empty;
		for(int i = 0; i < list.Length; ++i)
			s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
		return s;
	}
*/
	public static string Stringify<T>(this IEnumerable<T> list){			//IEnumerable 인터페이스 ; static 에 의해서 <T> 쓸 수 있음
		string s = string.Empty;
		foreach(var v in list){
			s += v.ToString() + " ";
		}
		if (s.Length > 0)						//여기서 생성한 s만 이용
			s = s.Substring(0,s.Length -1);		//스페이스 한칸 제거
		return s;
	}
}

public static class HW0711{
	public static int First(this int[] array){
		return array[0];
	}

	public static int Last(this int[] array){
		return array[array.Length -1];
	}

	public static int Min(this int[] array){
		int result = Int32.MaxValue;
		foreach(var a in array)
			if(result > a)
				result = a;
		return result;
	}

	public static int Max(this int[] array){
		int result = Int32.MinValue;
		foreach(var a in array)
			if(result < a)
				result = a;
		return result;
	}
	
	public static int Sum(this int[] array){
		int result = 0;
		foreach(var a in array)
			result += a;
		return result;
	}

	public static int Average(this int[] array){
		int result = 0;
		foreach(var a in array)
			result += a;
		return result / array.Length;
	}
}

class MainClass {
	public static void Main (string[] args) {
		List<int> list = new List<int>(){8,3,2};
		Console.WriteLine(list.Stringify() == "8 3 2");

		int[] array = list.ToArray();
		Console.WriteLine(array.Stringify() == "8 3 2");
		Console.WriteLine("lecture".Stringify() == "l e c t u r e");
		Console.WriteLine((new char[] {'l','e','c','t','u','r','e'}).Stringify() == "l e c t u r e");
		Console.WriteLine((new int[] {1}).Stringify() == "1");

		Console.WriteLine("\tHW");

		array = new int[]{30,40,70,100,20,10};
		Console.WriteLine(array.First() == 30);
		Console.WriteLine(array.Last() == 10);
		Console.WriteLine(array.Min() == 10);
		Console.WriteLine(array.Max() == 100);
		Console.WriteLine(array.Sum() == 30+40+70+100+20+10);
		Console.WriteLine(array.Average() == array.Sum()/6);		//숙제
  	}
}