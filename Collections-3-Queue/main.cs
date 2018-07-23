using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Queue q = new Queue();
    q.Enqueue("James");
    q.Enqueue("Brown");
    q.Enqueue("Fox");
    Console.WriteLine(q.Count == 3);

    while(q.Count > 0)
      Console.WriteLine(q.Dequeue());
    Console.WriteLine (q.Count == 0);
  }
}