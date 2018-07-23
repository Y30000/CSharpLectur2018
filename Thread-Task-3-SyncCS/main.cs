using System;
using System.Threading;

// lock에 사용되면 안되는 object
// 1. this
// 2. string
// 3. GetType(): Type형

class Counter{
	public int Count{get; set;}
	readonly object thisLock = new object();
	public void Increase(){
		lock(thisLock){					//this , string 말고 아무 자료형이나 사용 가능
			++Count;	//critical section 여러 테스크가 공유하는곳이라 한순간에 한테스크만 접근가능하게 (싱크 맞춰줌)
		}
	}
}

class MainClass {
  public static void Main (string[] args) {
		Counter c = new Counter();
		Thread t1 = new Thread(c.Increase);
		Thread t2 = new Thread(c.Increase);
		Thread t3 = new Thread(c.Increase);
    Console.WriteLine (c.Count);
		t1.Start();
    Console.WriteLine (c.Count);
		t2.Start();
    Console.WriteLine (c.Count);
		t3.Start();
    Console.WriteLine (c.Count);
		Console.ReadLine();
    Console.WriteLine (c.Count);
  }
}