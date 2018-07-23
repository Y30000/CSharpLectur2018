using System;
using System.Collections.Generic;

public class Student{
	public string Name{get; set;}
	public List<int> Scores{get; set;}
	public override string ToString(){
		string s = Name + " " + Scores.ToString() + "\n";
		return s;
	}
}

public static class ExClass{
	public static string Stringfy<T>(this IEnumerable<T> list){
		string s = string.Empty;
		foreach(var obj in list)
			s += obj.ToString();
		s = s.Substring(0,s.Length -1);
		return s;
	}
}

class MainClass {
  public static void Main (string[] args) {
		
    /*
    public class Student{
      public string Name{get; set;}
      public List<int> Scores{get; set;}
    }
    60점 미만의 낙제생 리스트
    낙제생이 아닌 사람들 리스트
    Test Case:
    List<Student> nonRepeaters;
    List<Student> repeaters;
    Console.WriteLine(nonRepeaters.Stringfy() == "ctkim Won");
    Console.WriteLine(repeaters.Stringfy() == "Steven Brown");
    */
		List<Student> list = new List<Student>() {
			new Student() { Name = "ctkim", Scores = new List<int>(){100, 70, 90, 77, 88}},
			new Student() { Name = "Steve", Scores = new List<int>(){ 77, 60, 90, 77, 55}},
			new Student() { Name = "Brown", Scores = new List<int>(){ 30, 61, 91,100, 57}},
			new Student() { Name = "Won", 	Scores = new List<int>(){100,100, 91,100,100}},
			new Student() { Name = "JJ", 		Scores = new List<int>(){ 10,100, 91,100,100}}
		};
		List<Student> nonRepeaters = new List<Student>();
		List<Student> repeaters = new List<Student>();
		
		// list.Add(new Student("ctkim",new List<int>(){80,100,90}));
		// list.Add(new Student("Won",new List<int>(){99,100,88}));
		// list.Add(new Student("Steven",new List<int>(){99,45,88}));
		// list.Add(new Student("Brown",new List<int>(){50,70,88}));
/*
		foreach(var st in list){
			int MinValue = 100;
			foreach(var s in st.Scores){
				if(MinValue > s)
					MinValue = s;
			}
			if(60 > MinValue)
				repeaters.Add(st);
			else
				nonRepeaters.Add(st);
		}
			Console.WriteLine("\tstudent");

		foreach(var st in list){
			Console.Write(st.Name);
			foreach(var scores in st.Scores)
				Console.Write(" " + scores);
			Console.WriteLine("");
		}
		
			Console.WriteLine("\trepeaters");

		foreach(var st in repeaters){
			Console.Write(st.Name);
			foreach(var scores in st.Scores)
				Console.Write(" " + scores);
			Console.WriteLine("");
		}
		
			Console.WriteLine("\tnonRepeaters");

		foreach(var st in nonRepeaters){
			Console.Write(st.Name);
			foreach(var scores in st.Scores)
				Console.Write(" " + scores);
			Console.WriteLine("");
		}
*/
		nonRepeaters = list.FindAll(stud => stud.Scores.TrueForAll(score => score >= 60));
		repeaters	= list.FindAll(stud => !stud.Scores.TrueForAll(score => score >= 60));

		Console.WriteLine(list.Stringfy());
		Console.WriteLine(repeaters.Stringfy());
		Console.WriteLine(nonRepeaters.Stringfy());
  }
}