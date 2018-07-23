using System;

class MainClass {
  public static void Main (string[] args) {
    int[] scores = new int[10];

    for(int i = 0; i < scores.Length; ++i)
      scores[i] = i+1;
    
    int sum = 0;
    for(int i = 0;i < scores.Length; ++i)
      sum += scores[i];

      float avg = (float)sum / scores.Length;
      Console.WriteLine(sum == 55);
      Console.WriteLine(avg == 5.5);
  }
}