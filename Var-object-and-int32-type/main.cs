using System;

class Car{
  // public var name;   //error
}

class MainClass {
  public static void Main (string[] args) {
    var price = 10000;     //컴파일 후 int price = 10000;   define 과 비슷

    Console.WriteLine(price == 10000);
    Console.WriteLine(price.GetType().ToString() == "System.Int32");

    // int i32 = 10000;  같음
    Int32 i32 = 10000;
    Console.WriteLine(i32.GetType().ToString() == "System.Int32");

    object obj = 70;    //Boxing
    Console.WriteLine(obj.GetType().ToString() == "System.Int32");
  }
}