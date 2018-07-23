using System;

class MainClass {
  public static void Main (string[] args) {

    int[] scores = new int[] {
      1, 1, 1, 2, 1, 4, 3, 4, 4, 4, 4, 1, 1, 3, 4, 4, 1, 1, 4, 4
    };

    Console.WriteLine(FrequencyOf(scores, 1) == 8); // (array에서, number 몇개)
    Console.WriteLine(FrequencyOf(scores, 4) == 4);
    Console.WriteLine(FrequencyOf(scores, 10) == 0);  //테스트, 테스트, 테스트

    for(int i = 0;i < scores.Length; ++i){
      Console.Write(scores[i] + " ");
    }

    Console.WriteLine("\n" + ValueOfMaxFreq(scores));

    for(int i = 0;i < scores.Length; ++i){
      Console.Write(scores[i] + " ");
    }
  }

  public static int FrequencyOf(int[] arr, int num){
    int counter = 0;
    for( int i = 0; i < arr.Length; ++i)
      if(arr[i] == num)
        ++counter;
    return counter;
  }

/*
  public static int ValueOfMaxFreq(int[] arr){
    int MaxFreq = 0, MaxValue = 0, iTemp;
    
    for(int i = 0; i<arr.Length;++i){ //가정 
      iTemp = FrequencyOf(arr,arr[i]);
      if(MaxValue < iTemp){
        MaxValue = iTemp;
        MaxFreq = arr[i];
      }
    }
    return MaxFreq;
  }
*/

  public static int ValueOfMaxFreq(int[] arr){
    int MaxFreq = 0, BeforeCounter = 0, Counter = 0;

    bubble(ref arr);

    for(int i = 0; i<arr.Length-1;++i){

      ++Counter;

      if(arr[i] != arr[i+1]){

        if(BeforeCounter < Counter){
          MaxFreq = arr[i];
          BeforeCounter = Counter;
        }
        Counter = 0;

      }

    }

    if(Counter++ != 0){
      if(arr[arr.Length-1] == arr[arr.Length-2]){
        if(BeforeCounter < Counter){
          MaxFreq = arr[arr.Length-1];
          BeforeCounter = Counter;
        }
      }
    }

    return MaxFreq;
  }

  public static void bubble(ref int[] arr){
    int check = 0;
    for(int i = 0; i < arr.Length; ++i){
      for(int j = 1; j < arr.Length-i; ++j){
        if(arr[j-1] > arr[j]){
          swap(ref arr[j-1] ,ref arr[j]);
          check = 1;
        }
      }
      if(check == 0)
        break;
    }
  }

  public static void swap(ref int a,ref int b){
    int c = a;
    a = b;
    b = c;
  }

}