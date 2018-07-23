using System;

class MainClass {
  public static void Main (string[] args) {
    double a = 1, b = 2, c = 1 ;

    double D = b * b - 4 * a * c;
    if(D > 0){
      D = Math.Sqrt(D);
      Console.WriteLine(a * D * D + b * D + c == 0);
    }
    else if(D == 0){
      D = Math.Sqrt(D);
      Console.WriteLine(a * D * D + b * D + c == 0);
    }
    else{
      Console.WriteLine("근X");
    }
  }
}