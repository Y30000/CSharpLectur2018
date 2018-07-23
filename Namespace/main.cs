using System;

namespace Outer{    //이름 중복해 사용할 수 있게 함
  namespace A{
    class Car{
      public string name = "Car in namespace A";
    }
  }
  namespace B{
    class Car{
      public string name = "Car in namespace B";
    }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Outer.A.Car a = new Outer.A.Car();                    //Outer.A. namespace
    Console.WriteLine(a.name == "Car in namespace A");

    Outer.B.Car b = new Outer.B.Car();                    //Outer.B. namespace
    Console.WriteLine(b.name == "Car in namespace B");
  }
}