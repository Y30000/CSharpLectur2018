// using System;
// using System.Threading;

// class MainClass {
// 	public static void Todo(){
// 		Thread.Sleep(500);
// 		Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
// 	}

//   public static void Main (string[] args) {
// 		Thread t = new Thread(Todo);
// 		Console.WriteLine("before running: " + t.ThreadState);
// 		t.Start();
// 		Console.WriteLine("after running: " + t.ThreadState);
// 		t.Join();
// 		Console.WriteLine("after join: " + t.ThreadState);

// 		// public delegate void ThreadStart() 			원형
// 		Thread t2 = new Thread(new ThreadStart(Todo));		//ThreadStart = delegate 리턴과 인자가 없음(Action)과 비슷
// 		t2.Start();
//   }
// }

//위에 꺼랑 내용은 같음
using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
	public static void Todo(){
		Thread.Sleep(500);
		Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
	}

  public static void Main (string[] args) {
		Task task = Task.Run(Todo);		//callback	run바로 실행
		task.Wait();
		
		Task task2 = Task.Run(		()=>{		//람다식 리턴 없어도 됨
			Thread.Sleep(500);
			Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
		}	);
		task2.Wait();
  }
}