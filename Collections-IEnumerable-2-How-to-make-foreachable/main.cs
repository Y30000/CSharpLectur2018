using System;
using System.Collections;
using System.Collections.Generic;

public class Person{
	public string Name{get;set;}
	public override string ToString(){return Name;}
}

public class People : IEnumerable<Person>{		//Generic 과 nonGeneric 둘다 해줘야함
	public List<Person> list{get;set;}

	public IEnumerator<Person> GetEnumerator(){return list.GetEnumerator();}		//Generic
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}				//nonGeneric
}

class MainClass {
  	public static void Main (string[] args) {
		People p = new People();
		p.list = new List<Person>(){
			new Person() {Name = "ctkim"},
			new Person() {Name = "WonLee"},
			new Person() {Name = "JJ"}
		};

		foreach(var person in p)
			Console.WriteLine(person.Name);
  	}
}