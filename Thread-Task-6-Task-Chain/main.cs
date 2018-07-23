using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {		//async await	
  public static void Main (string[] args) {
		Task<string> taskChain = Task<int>.Run( ()=>{		//int 를 리턴하기에 func 형태의 delegate
			Console.WriteLine("1 task chain");
			Thread.Sleep(100);
			return 100;								//100이 완료된 후에 
		}).ContinueWith( task => {	//200을 실행
			Console.WriteLine();
			Console.WriteLine(task.Result);	//100이 리턴될 때 가지 기다림 결국 wait
			Console.WriteLine("2 task chain");
			Thread.Sleep(100);
			return 200;								//200 이 완료된 후에
		}).ContinueWith( task => {	//300을 실행
			Console.WriteLine();
			Console.WriteLine(task.Result);	//100이 리턴될 때 가지 기다림 결국 wait
			Console.WriteLine("3 task chain");
			Thread.Sleep(100);
			return 300.ToString();		//마지막꺼는 최초선언된 return 형식 사용
		});
		Console.WriteLine("in Main");
    Console.WriteLine("300" == taskChain.Result);
  }
}