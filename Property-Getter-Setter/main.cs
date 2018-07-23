using System;

class MainClass {

  class Book{
    public string Title{get; set;}  //getter setter 사용하는 변수는 대문자로 시작한다??
    /*  위에거 길게 쓰면 이렇게
    string title;
    public string Title{
      get {
        Console.WriteLine("get()"); return title;
      }
      set {
        Console.WriteLine("set()");
        title = value != "" ? value : "N/A";
      }
    }*/

    //1
    string title1;
    public string GetTitle() { return  title1;}
    public void SetTitle(string title){ this.title1 = title;}

    //2
    string title2;
    public string Title2{
      get {
        return title2;
      }
      set {
        title2 = value;
      }
    }

    //3
    public string Title3{ get; private set;}  //함수는 대문자로

    // 이경우 생성자에서만 Title = ~~ ; 설정함
  }

  public static void Main (string[] args) {

    // Book b = new Book();
    // b.Title = "TLOR";
    // Console.WriteLine (b.Title == "TLOR");
    // b.Title = "";
    // Console.WriteLine (b.Title == "N/A");

    Book b = new Book {Title3="TLOR"};
    Console.WriteLine(b.Title3);
  }
}