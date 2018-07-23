using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
		int[] numbers = {1,2,3,4,5,6,7,8,9,10};

    Console.WriteLine(numbers.Sum() == 55);
    Console.WriteLine(numbers.Average() == 5.5);
    Console.WriteLine(numbers.Average( x => 10 * x) == 55);	//Average(Func, long)	=>	(Callback , return)
    Console.WriteLine(numbers.Max() == 10);
    Console.WriteLine(numbers.Min() == 1);
    Console.WriteLine(numbers.Count() == 10);
    Console.WriteLine(numbers.First() == 1);
    Console.WriteLine(numbers.Last() == 10);

																																						//Aggregate 집합
		Console.WriteLine(numbers.Aggregate(0, (memo, n) => memo + n) == 55);		//sum	 0 = memo의 초기값
		Console.WriteLine(numbers.Aggregate((메모, n) => 메모 + n) == 55);					//sum		0생략됨
		Console.WriteLine(numbers.Aggregate((memo, n) => memo + 1) == 10);			//count
		Console.WriteLine(numbers.Aggregate((memo, n) => (n%2 != 0) ?  1+memo:  memo));			//홀수count
		Console.WriteLine(numbers.Aggregate((memo, n) => (n%2 == 0) ?  1+memo:  memo));			//짝수count	문제??
		Console.WriteLine(numbers.Aggregate((memo, n) => n > memo ? n : memo) == 10);											//max
		Console.WriteLine(numbers.Aggregate(int.MaxValue,(memo, n) => n < memo ? n : memo) == 1);					//Min

		var str = new[]{"a","b","c","d"};
		Console.WriteLine(str.Aggregate((memo,b) => memo + ", " + b) == "a, b, c, d");
	}
}