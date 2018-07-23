using System;

class MainClass {
  class Novel{
    public string title;
    public string genre;

    public string writer;
    public void printNov(){
      Console.WriteLine("Title :" + title);
      Console.WriteLine("genre :" + genre);
      Console.WriteLine("writer :" + writer);
    }
  }

  class Magazine{
    public string title;
    public string genre;

    public int releaseDay;
    public void printMag(){
      Console.WriteLine("Title : " + title);
      Console.WriteLine("Genre : " + genre);
      Console.WriteLine("ReleaseDay : " + releaseDay);
    }
  }

  public static void Main (string[] args) {
    Novel nov = new Novel();
    nov.title = "The Hobbit"; nov.genre = "Fantasy"; 
    nov.writer = "JRR T";
    nov.printNov();
    Console.WriteLine();
    Magazine mag = new Magazine();
    mag.title = "Computer"; mag.genre = "Computer"; 
    mag.releaseDay = 1;
    mag.printMag();
  }
}