using System;

class MainClass {
  public static void Main (string[] args) {
    int [,] list = {
      {10,20},
      {20,30},
      {50,60}
    };
    Console.WriteLine(list[1,0] == 20);
  }
}