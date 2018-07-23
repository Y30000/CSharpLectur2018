using System;
using System.Collections.Generic;

public static class ExClass{
	
	public static string Stringify<T>(this IEnumerable<T> list){			
		string s = string.Empty;
		foreach(var v in list){
			s += v.ToString() + " ";
		}
		if (s.Length > 0)						
			s = s.Substring(0,s.Length -1);	
		return s;
	}
}

class MainClass {
  public static void Main (string[] args) {
		
		int[] arrayA = new int[] {1,3,5,7,9};
		int[] arrayB = new int[] {2,4,6,8};

		Console.WriteLine(MergeArrays(arrayA,arrayB).Stringify() == "1 2 3 4 5 6 7 8 9");

		int[] arrayC = new int[] {1,2,5,7,9};
		int[] arrayD = new int[] {2,4,6,8,10,11,12};
		Console.WriteLine(MergeArrays(arrayC,arrayD).Stringify() == "1 2 2 4 5 6 7 8 9 10 11 12");

		Console.WriteLine(MergeArrays(new int[]{},new int[]{}).Stringify() == "");
		Console.WriteLine(MergeArrays(new int[]{},new int[]{1, 5, 10}).Stringify() == "1 5 10");
		Console.WriteLine(MergeArrays(new int[]{1,1,1},new int[]{2,2,2,2}).Stringify() == "1 1 1 2 2 2 2");
  }

	public static int[] MergeArrays(int[] ArrayA,int[] ArrayB){
		int[] ArrayC = new int[ArrayA.Length + ArrayB.Length];
		int A = 0, B = 0, C = 0;
		

		/*
		while(C < ArrayC.Length){
			if(ArrayA.Length == A || ArrayB.Length == B)
				return ArrayC;
		
		*/
		while(ArrayA.Length != A && ArrayB.Length != B){
			if(C == ArrayC.Length)
				return ArrayC;

			if(ArrayA[A] > ArrayB[B])
				ArrayC[C++] = ArrayB[B++];
			else
				ArrayC[C++] = ArrayA[A++];
		}

		while(ArrayA.Length != A)
			ArrayC[C++] = ArrayA[A++];
		while(ArrayB.Length != B)
			ArrayC[C++] = ArrayB[B++];
		return ArrayC;
	}
}