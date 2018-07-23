using System;

class Node{
  public string data;
  public Node next;
  public Node previous;
}

class LinkedList{
  public int Count{get; private set;}

  Node head, tail;
  public LinkedList(){
    head = tail = null;
    Count = 0;
  }

  public void AddLast(string obj){
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    newNode.previous = null;
    if(null == head){
      head = tail = newNode;
    }else{
      tail.next = newNode;
      newNode.previous = tail;
      tail = newNode;
    }
    ++Count;
  }

  public void AddFirst(string obj){
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    newNode.previous = null;
    if(null == head){
      head = tail = newNode;
    }
    else{
      head.previous = newNode;
      newNode.next = head;
      head = newNode;
    }
    ++Count;
  }

  public string RemoveFirst(){
    if(null == head)
      return string.Empty;

    string s = head.data;
    head = head.next;
    if(--Count != 0)
      head.previous = null;
    return s;
  }
  
  public string RemoveLast(){
    if(null == head)
      return string.Empty;

    string s = tail.data;
    tail = tail.previous;
    if(--Count != 0)
      tail.next = null;
    return s;
  }
  
  public string Stringfy(){
    Node current = head;
    string s = string.Empty;

    while(null != current){
      s += current.data;
      current = current.next;
    }

    return s;
  }

  public string ReverseStringfy(){
    Node current = tail;
    string s = string.Empty;

    while(null != current){
      s += current.data;
      current = current.previous;
    }

    return s;
  }

  public bool SearchData(string s){
    Node current = head;
    
    while(null != current){
      if(current.data == s)
        return true;
      current = current.next;
    }
    return false;
  }

  public string RemoveData(string s){
    Node current = head;
    int currentcounter = 1;
    
    while(null != current){
      if(current.data == s){
        if(currentcounter == 1){
          RemoveFirst();
        }
        else if(currentcounter == Count){
          RemoveLast();
        }
        else{
          current.previous.next = current.next;
          current.next.previous = current.previous;
          --Count;
        }
        return s;
      }
      current = current.next;
      ++currentcounter;
    }
    s = "Not found string";
    return s;
  }
}

class MainClass {
  public static void Main (string[] args) {
    LinkedList list = new LinkedList();

    list.AddLast("one");
    Console.WriteLine (list.Stringfy() == "one");

    list.AddLast("two");
    Console.WriteLine (list.Stringfy() == "onetwo");

    list.AddLast("three");
    Console.WriteLine (list.Stringfy() == "onetwothree");
    Console.WriteLine (list.Count == 3);

    Console.WriteLine(list.RemoveFirst() == "one");
    Console.WriteLine (list.Stringfy() == "twothree");

    Console.WriteLine(list.RemoveFirst() == "two");   
     Console.WriteLine (list.Count == 1);

    Console.WriteLine(list.RemoveFirst() == "three");
    Console.WriteLine (list.Stringfy() == string.Empty);
    Console.WriteLine (list.Count == 0);

    Console.WriteLine("\tAddFirst");
    list.AddFirst("one");
    list.AddFirst("two");
    list.AddFirst("three");
    Console.WriteLine(list.Stringfy() == "threetwoone");
    Console.WriteLine(list.ReverseStringfy() == "onetwothree");
    Console.WriteLine(list.RemoveFirst() == "three");
    Console.WriteLine(list.RemoveLast() == "one");
    Console.WriteLine(list.Stringfy() == "two");
    Console.WriteLine(list.ReverseStringfy() == "two");

    Console.WriteLine("\tAddFirstLast");
    list.AddFirst("one");
    list.AddLast("three");
    Console.WriteLine(list.Stringfy() == "onetwothree");
    
    Console.WriteLine("\tRemoveData");
    Console.WriteLine(list.RemoveData("two") == "two");
    Console.WriteLine(list.Stringfy() == "onethree");
    Console.WriteLine(list.RemoveData("two") == "Not found string");
    Console.WriteLine(list.RemoveData("three") == "three");
    Console.WriteLine(list.RemoveData("one") == "one");
    Console.WriteLine(list.Stringfy() == string.Empty);
    Console.WriteLine(list.Count == 0);
    Console.WriteLine("\tSearchData");
    list.AddLast("two");
    list.AddLast("three");
    list.AddFirst("one");
    Console.WriteLine(list.ReverseStringfy() == "threetwoone");
    Console.WriteLine(list.SearchData("one") == true);
    Console.WriteLine(list.SearchData("two") == true);
    Console.WriteLine(list.SearchData("three") == true);
    Console.WriteLine(list.SearchData("four") == false);
    Console.WriteLine(list.SearchData("asdf") == false);
  }
}

/*
Double Linked list
AddLast(), AddFirst(), RemoveFirst(), RemoveLast(), ReverseStringify(), 

SearchData(), RemoveData() 
*/