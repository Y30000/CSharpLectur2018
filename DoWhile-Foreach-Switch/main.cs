using System;

class MainClass {
  public static void Main (string[] args) {
    int sum = 0, i = 0;

    do{
      sum += ++i;
    } while(i<0)
    
    Console.WriteLine ("sum = " + sum);

    string[] names = {"ctkim", "chang", "kim"}
//  foreach(string name in names)
    foreach(var name in names)      //var 컴파일 시점에 타입이 바뀜, array 순서대로 모두 출력?
      Console.WriteLine(name);
      
    int s = 1;
    switch(s){
      case 1:
        Console.WriteLine(1);
        break;
      case 2:
        Console.WriteLine(2);
        break;
      default:
        break;
    }
  }
}