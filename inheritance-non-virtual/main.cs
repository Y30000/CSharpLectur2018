using System;

class A{
  public string bye(){
    return "A";
  }
}

class B : A{
  public string bye(){
    return "B";
  }
}

class C : B{
  public string bye(){
    return "C";
  }
}
//호출될것을 컴파일에서 결정 선언된 녀석껄로
class MainClass {
  public static void Main (string[] args) {
    A a = new A();
    Console.WriteLine (a.bye() == "A");
    B b = new B();
    Console.WriteLine (b.bye() == "B");
    C c = new C();
    Console.WriteLine (c.bye() == "C");

    A ab = new B();
    Console.WriteLine(ab.bye() == "A");
    B bc = new C();
    Console.WriteLine(bc.bye() == "B");
//    C ca = new A();
//    Console.WriteLine(ca.bye() == "A");
  }
}