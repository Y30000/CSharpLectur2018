using System;

delegate int Callback(int a, int b);        //delegate 변수타입 

class MainClass {                           //콜백문 특징 리턴값이 있음
  static int Sum(int i, int j){
    Console.WriteLine("Sum");
    return i + j;
  }
  static int Multiply(int i, int j){
    Console.WriteLine("Multiply");
    return i * j;
  }
  static int Power(int i, int j){
    Console.WriteLine("Power");
    return (int)Math.Pow((double)i,(double)j);
  }

  public static void Main (string[] args) {
    Callback[] cb = new Callback[6];

    cb[0] = Sum;
    cb[1] = Multiply;
    cb[2] = delegate (int i, int j){return i + j;}; //익명함수

    Console.WriteLine(cb[0](1,2) == 3);
    Console.WriteLine(cb[1](2,2) == 4);
    Console.WriteLine(cb[2](2,3) == 5);
    
    cb[3] = (int i, int j) => {return i+j ;}; //람다식도 중괄호사용시 리턴해야함 {문형식}
    Console.WriteLine(cb[3](3,4) == 7);

    
    cb[4] = (i, j) => i+j ; //람다식
    Console.WriteLine(cb[4](4,5) == 9);        //람다식

    Console.WriteLine("\tChain");
    // Console.WriteLine(((i, j) => i+j)(4,5) == 9);
    cb[5] = Sum;
    cb[5] += Multiply;
    cb[5] += Power;
    Console.WriteLine(cb[5](3,2) == 9);    //몹이 죽었을때 관련된애들 연속 호출 가능
    cb[5] -= Power;
    Console.WriteLine(cb[5](3,2) == 6); 
    cb[5] += Power;
    cb[5] -= Multiply;
    Console.WriteLine(cb[5](3,2) == 9); 

    Console.WriteLine(new Callback((i,j) => i+j)(10,20) == 30);   //원래는 문법상 오류지만 선언시에는 사용가능 
  }
}