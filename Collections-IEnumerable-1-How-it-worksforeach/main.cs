using System;
using System.Collections.Generic;

class MainClass {
	public static void Main (string[] args) {
		var names = new List<string>(){"John", "Tom", "Peter"};

		string s = String.Empty;
		foreach(var name in names)
			s += name + " ";
    	Console.WriteLine (s == "John Tom Peter ");

		s = string.Empty;
		var e = names.GetEnumerator();		//Enumerator e
		while(e.MoveNext()){				//Next가 있으면 true 없으면 false 
			s += e.Current + " ";
		}
    	Console.WriteLine (s == "John Tom Peter ");
  	}
}