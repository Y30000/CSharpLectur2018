using System;

class A{
  public virtual string bye(){
    Console.WriteLine("A");
    return "A";
  }
}

class B : A{
  public override string bye(){
    base.bye();
    Console.WriteLine("B");
    base.bye();
    return "B";
  }
}

class C : B{
  public override string bye(){
    base.bye();
    Console.WriteLine("C");
    base.bye();
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
    Console.WriteLine(ab.bye() == "B");
    B bc = new C();
    Console.WriteLine(bc.bye() == "C");
//    C ca = new A();
//    Console.WriteLine(ca.bye() == "A");
  }
}