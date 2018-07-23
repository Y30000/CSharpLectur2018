using System;

delegate bool Condition(int index, User user);

class User{
  public string Name {get; set;}
  public int Age {get; set;}

  public User(string name, int age){
    Name = name; Age = age;
  }
}

class MainClass {
  public static void Main (string[] args) {
    User[] list = new User[4]{
      new User("Daniel",27),
      new User("Outsider",30),
      new User("Wolf",17),
      new User("Song",20)
    };

    Console.WriteLine(FindIndexOf(list, (index, user) => user.Name == "Wolf") == 2);
    Console.WriteLine(FindIndexOf(list, (index, user) => user.Name == "Kim") == -1);
    Console.WriteLine(CountOf(list, (index, user) => user.Age >= 20 ) == 3);
    Console.WriteLine(CountOf(list, (index, user) => user.Age >= 10 ) == 4);
    Console.WriteLine(CountOf(list, (index, user) => user.Age >= 100 ) == 0);
  }

  static int FindIndexOf(User[] list, Condition condition){
    for(int i = 0;i < list.Length;++i){
      if(condition(i,list[i])){
        return i;
      }
    }
    return -1;
  }

  static int CountOf(User[] list, Condition condition){
    int counter = 0;
    for(int i = 0;i < list.Length;++i){
      if(condition(i,list[i])){
        ++counter;
      }
    }
    return counter;
  }
}