using System;

abstract class Animal{            //Animal 만들어서 Dog 등등 추가함
  public string name;
  public abstract void Cry();     //아래에서 선언을 하지 않으면 컴파일 에러
  public void Move(){
    Console.WriteLine("Move()");
  }
}

class Dog : Animal{
  public override void Cry(){
    Console.WriteLine("Bark")
  }
}

class MainClass {
  public static void Main (string[] args) {
    // Animal = ani new Animal(); // 문법 error
    Dog dog = new Dog();
    dog.Cry();
  }
}