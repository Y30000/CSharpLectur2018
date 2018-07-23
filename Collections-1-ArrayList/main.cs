using System;
using System.Collections;

//public class ArrayList : IList, ICollection, IEnumerable (foreach 사용가능하다), ICloneable


class MainClass {
  public static void Main (string[] args) {
    ArrayList list = new ArrayList();
    list.Add(100);
    Console.WriteLine ((int)list[0] == 100);  //UnBoxing == 형변환

    list.Add(200);
    Console.WriteLine ((int)list[1] == 200);

    list.Insert(2,300);
    Console.WriteLine ((int)list[2] == 300);

    list.Remove(100);
    Console.WriteLine(list.Count == 2);
    Console.WriteLine ((int)list[0] == 200);
    Console.WriteLine ((int)list[1] == 300);

    foreach(var v in list){
      Console.WriteLine(v);
    }

    Console.WriteLine(list.Contains(200) == true);
    Console.WriteLine(list.Contains(700) == false);

    list.Insert(10,1000);
    Console.WriteLine ((int)list[10] == 300); //예외시 Exception 날림 ArgumentOutOfRangeException	함수 호출됨
  }
}