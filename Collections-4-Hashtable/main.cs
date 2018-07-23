using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Hashtable ht = new Hashtable();
    ht.Add("txt", "notepad.exe");
    ht.Add("bmp", "paint.exe");
    ht.Add("dib", "paint.exe");
    ht["rtf"] = "wordpad.exe";
  //ht.Add("rtf","wordpad.exe");
    

    Console.WriteLine (ht.Count == 4);

    try{    //Exception 이 발생하면 
      ht.Add("txt","winword.exe");
    }catch(Exception e){
      Console.WriteLine("alReady exists " + e.Message);
    }finally{
      Console.WriteLine("finally"); //try문에서 사용된 메모리 해제를 주로함
    }
    ht.Remove("bmp");
    Console.WriteLine(ht.ContainsKey("bmp") == false);
  }
}