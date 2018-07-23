using System;		//설명할때 큰 범주부터 줄여가면서... 축구 = 운동 -> 구기 -> 발
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
		Console.WriteLine("Therad Id: " + Thread.CurrentThread.ManagedThreadId);
  }
}