using System;

class Car : object{
  public string name;
}

class MainClass {
  public static void Main (string[] args) {
    object obj = 10;
    object obj2 = 10;
    Console.WriteLine(obj != obj2);

    Console.WriteLine ((int)obj == (int)obj2);

    Car car = new Car();
    car.name = "Mini";
    object obj3 = car;      //주소값이 들어감, 박싱 언박싱 아님
    Car car2 = (Car)obj3;
    car2.name = "BMW";
    Console.WriteLine(car.name == "BMW");
  }
}