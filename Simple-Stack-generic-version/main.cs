using System;   //TDD

class Stack<T>{     // 임으의 <T> 타입을 사용한다.
  public int Count{get; private set;}
  private T[] data;
  private int size;

  public Stack(int size){
    data = new T[size];
    Count = 0;
    this.size = size;
  }

  public void Push(T value){
    if(Count < size )
      data[Count++] = value;
  }

  public T Pop(){
    if(Count == 0)
      return (T)Convert.ChangeType(-1,typeof(T)); //default(T);    //default(int) == 0 의도가 바뀜
    return data[--Count];
  }

}

class MainClass {
  public static void Main (string[] args) {
    Stack<int> s = new Stack<int>(3);

    //코딩할때 테스트 케이스 먼저 만들고 짜면

    Console.WriteLine (s.Count == 0);
    s.Push(10);
    Console.WriteLine (s.Count == 1);
    s.Push(20);
    Console.WriteLine (s.Count == 2);
    s.Push(30);
    Console.WriteLine (s.Count == 3);
    s.Push(40);
    Console.WriteLine (s.Count == 3);
    Console.WriteLine (s.Pop() == 30);
    Console.WriteLine (s.Pop() == 20);
    Console.WriteLine (s.Pop() == 10);
    Console.WriteLine (s.Count == 0);
    Console.WriteLine (s.Pop() == -1);  //empty
    // s.Count = 10 //error

    Stack<string> s2 = new Stack<string>(3);

    //코딩할때 테스트 케이스 먼저 만들고 짜면
    Console.WriteLine();
    Console.WriteLine (s2.Count == 0);
    s2.Push("one");
    Console.WriteLine (s2.Count == 1);
    s2.Push("two");
    Console.WriteLine (s2.Count == 2);
    s2.Push("three");
    Console.WriteLine (s2.Count == 3);
    s2.Push("four");
    Console.WriteLine (s2.Count == 3);
    Console.WriteLine (s2.Pop() == "three");
    Console.WriteLine (s2.Pop() == "two");
    Console.WriteLine (s2.Pop() == "one");
    Console.WriteLine (s2.Count == 0);
    Console.WriteLine (s2.Pop() == "-1");  //empty
    
  }
}