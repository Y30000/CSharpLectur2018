using System;

class MainClass {

  class Book{
    
    public string title;    //없으면 private
    public int price;
    public string author;

    public static int count = 0;    //직접접근

    public Book(string _title, int _price, string _author){ //생성자
//    this.title = ~~
      title = _title;
      price = _price;
      author = _author;
      count++;
    }

    public float GetSalePrice(float sale){
      return price - price * sale;
    }
  }

  public static void Main (string[] args) {
    Book lor = new Book("The Load of the Rings", 30000, "J.R.R. Tolkien");
    Book hobbit = new Book("The Hobbit", 40000, "J.R.R. Tolkien");

    Console.WriteLine(Book.count == 2);
//  Console.WriteLine(hobbit.count == 2);   안됨

    Book[] books = new Book[2];
    books[0] = lor;
    books[1] = hobbit;
  
    foreach(var b in books){
      Console.WriteLine(b.title + ", " + b.price + ", sale : " + b.GetSalePrice(0.1f));
    }
  }
}