using System;   //TDD

class Stack{
  public int Count{get; private set;}
  private int[] data;
  private int size;

  public Stack(int size){
    data = new int[size];
    Count = 0;
    this.size = size;
  }

  public void Push(int value){
    if(Count < size )
      data[Count++] = value;
  }

  public int Pop(){
    if(Count == 0)
      return -1;
    return data[--Count];
  }

}

class MainClass {
  public static void Main (string[] args) {
    Stack s = new Stack(3);

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
  }
}