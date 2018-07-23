using System;

interface IEquatable{   //관례
  bool Equals(Car obj);
}

interface ISringifable{
  string Stringify();
}

interface ICloneable{
  Car Clone();
}

class Car : IEquatable, ISringifable, ICloneable{
  public string Make{get; set;}
  public string Model{get; set;}
  public string Year{get; set;}

  public bool Equals(Car car){
    if(Make == car.Make && Model == car.Model && Year == car.Year)
      return true;
    else
      return false;
  }

  public string Stringify(){
    return Make + ", " + Model + ", " + Year;
  }

  public Car Clone(){
    Car car = new Car();
    car.Make = Make;
    car.Model = Model;
    car.Year = Year;
    return car;
  }

}


class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";

    Car car2 = new Car();
    car2.Make = "BMW";
    car2.Model = "Mini";
    car2.Year = "2018";
    Console.WriteLine (car.Equals(car2));
    Console.WriteLine (car.Stringify() == "BMW, Mini, 2018");
    
    Car clone = car.Clone();
    Console.WriteLine (car.Equals(clone));

    clone.Make = "Tesla";
    Console.WriteLine (car.Make == "BMW");
    Console.WriteLine (clone.Make == "Tesla");
  }
}