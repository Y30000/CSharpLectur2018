using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    int[] scores = new int[] {
      1, 1, 1, 2, 1, 4, 3, 4, 4, 1, 1, 1, 1, 3, 4, 4, 1, 1, 4, 4
    };

    for(int i = 0;i < scores.Length; ++i){
      Console.Write(scores[i] + " ");
    }
		
    Console.WriteLine("\n" + ValueOfMaxFreq(scores));
  }

  public static int FrequencyOf(int[] arr, int num){
    int counter = 0;
    for( int i = 0; i < arr.Length; ++i)
      if(arr[i] == num)
        ++counter;
    return counter;
  }

  public static int ValueOfMaxFreq(int[] arr){
		Dictionary<int, int> dic = new Dictionary<int, int>();	
		int MaxFreq = 0;
		int Value = 0;
		
		foreach(var a in arr){
			if(dic.ContainsKey(a))
				dic[a] += 1;
			else
				dic.Add(a,1);
			//dic[a] = 1;
		}

		foreach(var d in dic){
			if(d.Value > Value){
				MaxFreq = d.Key;
				Value = d.Value;
			}
		}

    return MaxFreq;
  }
}