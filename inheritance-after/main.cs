using System;

class MainClass {

  class Book{
    public string title;
    public string genre;

    public Book(){
      Console.WriteLine("Book ctor");
    }

    public void printBook(){
      Console.WriteLine("Title :" + title);
      Console.WriteLine("Genre :" + genre);
    }
  }

  class Novel : Book {
    public string writer;

    public Novel() : base() { //base 는 부모 뜻함. 파라매타 없는 부모 호출
      Console.WriteLine("Novel ctor");
    }

    public void printNov(){
      printBook();
      Console.WriteLine("Griter :" + writer);
    }
  }

  class Magazine : Novel {
    public int releaseDay;

    public Magazine(){
      Console.WriteLine("Magazine ctor");
    }

    public void printMag(){
      printBook();
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