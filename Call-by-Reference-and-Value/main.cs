using System;

class MainClass {
	public static void Swap(ref int a,ref int b){
		int temp = a;
		a = b;
		b = temp;
	}

	public static void refSum(int a, int b, ref int sum){
		sum = a + b;
	}

	public static void outSum(int a, int b, out int sum){
		sum = a + b;
	}

  public static void Main (string[] args) {
		int a = 10, b = 20;
		Swap(ref a,ref b); 
    Console.WriteLine(a == 20 && b == 10);

		int s = 0;
		refSum(10,20, ref s);					//ref 초기화가 필요함	(사용하기 위한 용도)
		Console.WriteLine(s==30);			//넘어가는게 의미가 있음

		int sum;											//in 도 있음 내부에서 값 못바꿈
		outSum(10,20, out sum);				//out	(output) 초기화 불필요	(결과를 받는 용도)
		Console.WriteLine(sum==30);		//넘어가는게 의미가 없음
  }
}