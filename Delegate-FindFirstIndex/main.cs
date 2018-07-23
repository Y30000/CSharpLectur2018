using System;

class MainClass {
    
  delegate bool Condition(int index, int value);

  static bool exist(int i, int v){
    return v == 7;
}

  public static void Main (string[] args) {
    int[] scores = new int[]{1,2,3,5,10,7,8};
    Console.WriteLine (FindFirstIndex(scores,(i,v) => v == 7) == 5);
    Console.WriteLine (FindFirstIndex(scores,(i,v) => v == 100) == -1);
    Console.WriteLine (FindFirstIndex(scores,(i,v) => v > 3) == 3);
    Console.WriteLine (FindFirstIndex(scores,(i,v) => i > 5 && v > 3) == 6);
    Console.WriteLine (FindFirstIndex(scores,exist) == 5);
  }

  static int FindFirstIndex(int[] list,Condition condition){
    for(int i = 0;i < list.Length;++i){
      if(condition(i,list[i]))   //index 값과 value값을 => 조건문에 대입하면서 조건에 따른 값을 리턴받음
        return i;
    }
    return -1;
  }
}