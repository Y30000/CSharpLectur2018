using System;

delegate int Callback(int a, int b);        //delegate 변수타입 

class MainClass {                           //콜백문 특징 리턴값이 있음
  static int Sum(int i, int j){
    return i + j;
  }
  static int Mul(int i, int j){
    return i * j;
  }
  public static void Main (string[] args) {
    Callback[] cb = new Callback[5];

    cb[0] = Sum;
    cb[1] = Mul;
    cb[2] = delegate (int i, int j){return i + j;}; //익명함수

    Console.WriteLine(cb[0](1,2) == 3);
    Console.WriteLine(cb[1](2,2) == 4);
    Console.WriteLine(cb[2](2,3) == 5);
    
    cb[3] = (int i, int j) => {return i+j ;}; //람다식도 중괄호사용시 리턴해야함
    Console.WriteLine(cb[3](3,4) == 7);

    
    cb[4] = (i, j) => i+j ; //람다식
    Console.WriteLine(cb[4](4,5) == 9);

    // Console.WriteLine(((i, j) => i+j)(4,5) == 9);
  }
}