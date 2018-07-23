using System;
// Func 리턴타입이 존재 Action 리턴타입 없음 모든 타입 이미 정의되있음
class MainClass {

  static double divide(double x, double y){
    return x/y;
  }

  public static void Main (string[] args) {
    Action act1 = () => Console.WriteLine("Atcion");  //람다 void 함수
    act1();

    Action<int> act2 = (x) => Console.WriteLine(2 * x);
    act2(2);

    Action<double, double> act3 = (x,y) => Console.WriteLine(x/y);
    act3(10,20);

    //Func <in, in, in, in, out> 마지막껀 리턴타입
    Func<int> fn1 = () => 10;
    Console.WriteLine(fn1() == 10);
    Func<double, double, double> fn3 = (x, y) => x/y; // or     divide;
    Console.WriteLine(fn3(10,20) == 0.5);
    Func<int,int,int,int,int,int,int,int,int,int,int,int,int> fn13;
    fn13 = (a,b,c,d,e,f,g,h,i,j,k,l) => a+b+c+d+e+f+g+h+i+j+k+l;
    Console.WriteLine(fn13(1,1,1,1,1,1,1,1,1,1,1,1) == 12);
  }
}