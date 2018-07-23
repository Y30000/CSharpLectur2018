using System;

class User{
  public string Name {get; set;}
  public int Age {get; set;}
  public User(string name, int age){
    Name = name; Age = age;
  }
}

class MainClass {
  public static string Stringify(int[] list){
    string s = String.Empty;
    s = string.Empty; //둘다 작동함
    for(int i = 0; i < list.Length; ++i){
      s += i != list.Length -1 ? list[i] + " " : list[i].ToString();
    }
    return s;
  }

  public static void Main (string[] args) {
    int[] scores = new int[] {2, 4, 5, 3, 6, 8, 1, 7};

    Console.WriteLine(scores.GetType().ToString());
    Console.WriteLine(scores.GetType().BaseType.ToString());

    Console.WriteLine(Stringify(scores) == "2 4 5 3 6 8 1 7");
    Console.WriteLine(Stringify(new int[] {2}) == "2");
    Console.WriteLine(Stringify(new int[] {}) == "");
    Console.WriteLine(Stringify(new int[] {}) == String.Empty);

    Array.Sort(scores); //원본 변경은 조심해서 쓸것
    Console.WriteLine(Stringify(scores) == "1 2 3 4 5 6 7 8");

    Array.Sort(scores, (x,y) => y.CompareTo(x)); //람다
    Console.WriteLine(Stringify(scores) == "8 7 6 5 4 3 2 1");

    // x < y : -, x == 0, x > y: +              앞이 작으면 - 
    Console.WriteLine(1.CompareTo(2) < 0);    //CompareTo 뭐가 앞이어야 하는지
    Console.WriteLine(1.CompareTo(1) == 0);
    Console.WriteLine(2.CompareTo(1) > 0);

    Array.Sort(scores, (x,y) => y - x);       //람다
    Console.WriteLine(Stringify(scores) == "8 7 6 5 4 3 2 1");
    Array.Sort(scores, (x,y) => x - y);       //람다
    Console.WriteLine(Stringify(scores) == "1 2 3 4 5 6 7 8");

    User[] users = new User[3]{
      new User("Betty",23),
      new User("Susan",20),
      new User("Lisa", 25)
    };
    Array.Sort(users,(user1,user2) => user1.Age.CompareTo(user2.Age));
    foreach(var user in users)
      Console.WriteLine(user.Name + " " + user.Age + " ");
      
    Array.Sort(users,(user2,user1) => user1.Age.CompareTo(user2.Age));
    foreach(var user in users)
      Console.WriteLine(user.Name + " " + user.Age + " ");
  }
}