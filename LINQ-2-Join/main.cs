using System;
using System.Collections.Generic;

public class Student{
	public string Name{get;set;}
	public int Height{get;set;}

	public override string ToString(){return Name;}
}

public class Score{
	public string Name{get;set;}
	public string Subject{get;set;}
	public int Point{get;set;}
}

public static class ExClass{
	public static string Stringify<T>(this IEnumerable<T> list){	//IEnumerable 인터페이스 ; static 에 의해서 <T> 쓸 수 있음
		string s = string.Empty;
		foreach(var v in list){
			s += v.ToString() + " ";
		}
		if (s.Length > 0)					        //여기서 생성한 s만 이용
			s = s.Substring(0,s.Length -1); //스페이스 한칸 제거
		return s;
	}
}

class MainClass {
  public static void Main (string[] args) {
		List<Student> list = new List<Student>{
			new Student() { Name="ctkim", Height=175},
			new Student() { Name="Steve", Height=167},
			new Student() { Name="Brown", Height=180},
			new Student() { Name="Won", Height=171},
			new Student() { Name="JJ", Height=165} 
		};
		
		List<Score> scores = new List<Score>{
			new Score() { Name="ctkim", Subject="Math", Point=70},
			new Score() { Name="Steve", Subject="Math", Point=60},
			new Score() { Name="Brown", Subject="Math", Point=90},
			new Score() { Name="Won", 	Subject="Math", Point=10},
			new Score() { Name="JJ", 		Subject="Math", Point=30},
			new Score() { Name="ctkim", Subject="English", Point=70},
			new Score() { Name="Steve", Subject="English", Point=60},
			new Score() { Name="Brown", Subject="English", Point=90},
			new Score() { Name="Won", 	Subject="English", Point=10},
			new Score() { Name="JJ", 		Subject="English", Point=30}
		};
/*
		List<int> nums = new List<int>();
		nums.Add(10);
		nums.Add(20);
		nums.Add(30);
		nums.Add(40);
*/
    Console.WriteLine (list.Stringify() == "ctkim Steve Brown Won JJ");

		var ss1 = from student in list
							join score in scores on student.Name equals score.Name
							select new{ Name = student.Name, Subject = score.Subject, Point = score.Point};//임시 변수
						
		Console.WriteLine(nums.ToString());
  }
}