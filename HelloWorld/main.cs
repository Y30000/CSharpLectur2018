using System; //include <System>  //namespace

class MainClass {
  public static void Main (string[] args) {   //static 생성후 유지
    Console.WriteLine ("Hello World");
    System.Console.WriteLine("Hello World");
    Console.Write("Hello World\n");

    for(int i = 0; i < 10; ++i){
      for(int j = i; j >= 0; --j)
        Console.Write("*");
      Console.WriteLine("");
    }

    char k = '5';
//    char k = "5";   string
    Console.WriteLine(k);

    Console.WriteLine(120 << 2 == 480);
    Console.WriteLine(-120 << 2 == -480);
    Console.WriteLine(-120 >> 2 == -30);
    
    uint ui = 0;
    Console.WriteLine(~ui); //비트 뒤집기

    int in1 = -0;
    Console.WriteLine(in1);

    int e = 0xFF00 | 0xFF;
    Console.WriteLine(e);
  }
}