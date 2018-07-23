using System;

class Kitty{
  public enum CAttribute { TOPAZ, JAGUAR, CRAZY, ROYALPURPLE};

  public string name;
  public string owner;
  public int id;
  public CAttribute[] cattributes;
  public Kitty[] children;
  public Kitty[] parent;
}

class MainClass {
  public static void Main (string[] args) {
    Kitty kt = new Kitty();
    kt.name = "Founder #3";
    kt.owner = "0x456adf123";
    kt.id = 3;

    kt.cattributes = new Kitty.CAttribute[10];
    kt.cattributes[0] =  Kitty.CAttribute.TOPAZ;
    kt.cattributes[1] =  Kitty.CAttribute.JAGUAR;

    kt.children = new Kitty[10];
    kt.children[0] = new Kitty();
    kt.children[0].name = "Genensis";

    Console.WriteLine(kt.name == "Founder #3");
    Console.WriteLine(kt.cattributes[0] == Kitty.CAttribute.TOPAZ);
    Console.WriteLine(kt.children[0].name == "Genensis");
  }
}