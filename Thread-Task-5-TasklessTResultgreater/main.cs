using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Task<string> task = new Task<string>( ()=>{
				Thread.Sleep(100);
				Console.WriteLine("in Task");
				return "Task result";
			}
		);
		task.Start();
//	Console.WriteLine("Task result" == task.Result);
		Console.WriteLine("in Main");
		Console.WriteLine("Task result" == task.Result);	//결과값이 생길때까지 정지됨
  }
}