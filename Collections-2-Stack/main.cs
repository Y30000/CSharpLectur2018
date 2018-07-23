using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Stack stack = new Stack();
    stack.Push(100);
    stack.Push(200);
    stack.Push(300);
    stack.Push(400);
    stack.Push(500);
    Console.WriteLine(stack.Count == 5);   //Array.Length 외에는 Count
    Console.WriteLine((int)stack.Peek() == 500);  //Pop 와 달리 마지막꺼 출력만
    Console.WriteLine(stack.Count == 5);

    while(stack.Count>0)
      Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Count == 0);
    Console.WriteLine(stack.Pop());       //콘솔에 에러코드 나옴
  }
}