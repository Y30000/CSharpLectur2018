using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Dictionary<string, string> dic = new Dictionary<string, string>();
    dic.Add("txt", "notepad.exe");
    dic.Add("bmp", "paint.exe");
    dic.Add("dib", "paint.exe");
    dic["rtf"] = "wordpad.exe";
  //dic.Add("rtf","wordpad.exe");
    
    // or foreach(KeyValuePair<string, string> kvp in dic)
    foreach(var kvp in dic)
      Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);

    Console.WriteLine (dic.Count == 4);

    try{    //Exception 이 발생하면 
      dic.Add("txt","winword.exe");
    }catch(Exception e){
      Console.WriteLine("alReady exists " + e.Message);
    }finally{
      Console.WriteLine("finally"); //try문에서 사용된 메모리 해제를 주로함
    }
    dic.Remove("bmp");
    Console.WriteLine(dic.ContainsKey("bmp") == false);
  }
}