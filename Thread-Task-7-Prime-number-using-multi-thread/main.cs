using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

class CheckPrinerNumber{
	List<Task<List<int>>> tasks = new List<Task<List<int>>>();

	Func<object, List<int>> FindPrimeFunc;

public CheckPrinerNumber(){
	FindPrimeFunc = (objRange) => {
		int[] range = (int[])objRange;
		List<int> found = new List<int>();

		for(int i = range[0]; i <= range[1]; ++i)
			if(IsPrime(i))
				found.Add(i);
		return found;
	};
}

	public static bool IsPrime(int number){
		if(number <2)
			return false;
		if(number % 2 == 0 && number != 2)
			return false;
		for(int i = 2; i < number; ++i){
			if(number % i == 0)
				return false;
		}
		return true;
	}

	public void AddTask(int from, int to){
		tasks.Add(new Task<List<int>>(FindPrimeFunc, new int[]{from,to}));	//(람다,람다 파라메터)
	}

	List<int> Total = new List<int>();
	public void Start(){
		foreach(var task in tasks)
			task.Start();

		foreach(var task in tasks){
			task.Wait();
			Total.AddRange(task.Result.ToArray());
		}
	}

	public int GetNumberOfPrime(){return Total.Count;}
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine (false == CheckPrinerNumber.IsPrime(0));
    Console.WriteLine (true == CheckPrinerNumber.IsPrime(2));
    Console.WriteLine (true == CheckPrinerNumber.IsPrime(7));

		Stopwatch sw = new Stopwatch();
		sw.Start();
		CheckPrinerNumber p = new CheckPrinerNumber();
		p.AddTask(0,11);
		p.AddTask(12,20);
		p.AddTask(21,1000);
		p.Start();
		int n = p.GetNumberOfPrime();		//여기서 block
		sw.Stop();

		Console.WriteLine("#PrimeNumber = " + n);
		Console.WriteLine(168 == n);
		Console.WriteLine(sw.ElapsedMilliseconds.ToString() + "ms");

		Stopwatch sw2 = new Stopwatch();
		sw2.Start();
		CheckPrinerNumber p2 = new CheckPrinerNumber();
		p2.AddTask(0,1000);
		p2.Start();
		n = p2.GetNumberOfPrime();		//여기서 block
		sw2.Stop();

		Console.WriteLine("#PrimeNumber = " + n);
		Console.WriteLine(168 == n);
		Console.WriteLine(sw2.ElapsedMilliseconds.ToString() + "ms");
  }
}