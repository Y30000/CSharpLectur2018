using System;

class MainClass {

  enum Animal { MOUSE, CAT, BIRD, DOG = 10, LION};  //특별한 int

  public static void Main (string[] args) {
    Animal a = (Animal)1;
    Console.WriteLine (a);
    Console.WriteLine ((int)a == 1);
    Console.WriteLine ((int)Animal.MOUSE == 0);
    Console.WriteLine ((int)Animal.LION == 11);
  }
}