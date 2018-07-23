//http://www.csharp-examples.net/list/

using System;
using System.Collections;
using System.Collections.Generic;

public static class PrintClass{
	public static string Stringify<T>(this IEnumerable<T> list){	//IEnumerable 인터페이스 ; static 에 의해서 <T> 쓸 수 있음
		string s = string.Empty;
		foreach(var v in list){
			s += v.ToString() + " ";
		}
		if (s.Length > 0)						//여기서 생성한 s만 이용
			s = s.Substring(0,s.Length -1);		//스페이스 한칸 제거
		return s;
	}
}

public class Customer{
}

public class MyComparer : IComparer<int>
{
    public int Compare(int x, int y) { return x.CompareTo(y); }
}


class MainClass {
  public static void Main (string[] args) {
		{
			Console.WriteLine("\n\tList<T>\n");
			var list1 = new List<object>();
			var list2 = new List<Customer>();
			var list3 = new List<int>();
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList Constructor\n");
			var list = new List<int>();
			Console.WriteLine("list  : "+list.Stringify());
		}
		{
			var list = new List<int>() { 8, 3, 2 };
			Console.WriteLine("list  : "+list.Stringify());
		}
		{
			var listA = new List<int>() { 8, 3, 2 };
			var listB = new List<int>(listA);
			Console.WriteLine("listA : "+listA.Stringify());
			Console.WriteLine("listB : "+listB.Stringify());
		}
		{
			var list = new List<int>(16);
			Console.WriteLine("list.Count : " + list.Count);
			Console.WriteLine("list.Capacity : " + list.Capacity);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList[index]\n");
			var list = new List<int>() { 8, 3, 2 };
			int item = list[1];
			Console.WriteLine("item  : " + item);
			Console.WriteLine("list  : "+list.Stringify());
			list[1] = 4;
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Add\n");
			var list = new List<int>() { 8, 3, 2 };
			Console.WriteLine("list  : "+list.Stringify());
			list.Add(5);
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.AddRange\n");
			var listA = new List<int>() { 8, 3, 2 };
			var listB = new List<int>() { 5, 7 };
			listA.AddRange(listB);
			Console.WriteLine("listA : "+listA.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.BinarySearch\n");
			var list = new List<int>() { 1, 3, 4, 6, 7, 9 };
			int index = list.BinarySearch(6);
			Console.WriteLine("index : "+index);

			index = list.BinarySearch( item: 6, comparer: new MyComparer() );
			Console.WriteLine("index : "+index);

			index = list.BinarySearch( index: 1, count: 3, item: 6, comparer: new MyComparer() );
			Console.WriteLine("index : "+index);

			index = list.BinarySearch( index: 1, count: 2, item: 6, comparer: new MyComparer() );
			Console.WriteLine("index : "+index);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Clear\n");
			var list = new List<int>() { 8, 3, 2 };

			Console.WriteLine("list  : "+list.Stringify());
			list.Clear();
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Contains\n");
			var list = new List<int>() { 8, 3, 2 };
			bool result = list.Contains(3);
			Console.WriteLine("result: "+result);
			result = list.Contains(6);
			Console.WriteLine("result: "+result);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.ConvertAll\n");
			var listA = new List<int>() { 8, 3, 2 };
			var conv = new Converter<int, decimal>(x => (decimal)(x+1));
			var listB = listA.ConvertAll<decimal>(conv);
			Console.WriteLine("listA : "+listA.Stringify());
			Console.WriteLine("listB : "+listB.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.CopyTo\n");
			var list = new List<int>() { 8, 3, 2 };
			var array = new int[] {0,0,0,0,0};
			Console.WriteLine("Array : "+array.Stringify());

			list.CopyTo(array);
			Console.WriteLine("list  : "+list.Stringify());
			Console.WriteLine("Array : "+array.Stringify());
			
			array = new int[] {0,0,0,0,0};
			list.CopyTo(array, arrayIndex: 2);
			Console.WriteLine("Array : "+array.Stringify());

			array = new int[] {0,0,0,0,0};
			list.CopyTo(index: 1, array: array, arrayIndex: 3, count: 1);
			Console.WriteLine("Array : "+array.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Exists\n");

			var list = new List<int>() { 8, 3, 2 };
			bool result = list.Exists(x => x == 3);
			Console.WriteLine("result: "+result);

			result = list.Exists(x => x > 10);
			Console.WriteLine("result: "+result);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Equals\n");

			var listA = new List<int>() { 8, 3, 2 };
			var listB = listA;
			bool result = listA.Equals(listB);
			Console.WriteLine("result: "+result);

			listA = new List<int>() { 8, 3, 2 };
			listB = new List<int>() { 8, 3, 2 };
			result = listA.Equals(listB);
			Console.WriteLine("result: "+result);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Find\n");

			var list = new List<int>() { 8, 3, 2 };
			int item = list.Find(x => x > 2);
			Console.WriteLine("item  : "+item);					//*주의* site에서는 3이라 적혀있음 *주의*

			item = list.Find(x => x > 10);
			Console.WriteLine("item  : "+item);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.FindAll\n");
			var listA = new List<int>() { 8, 3, 2 };
			var listB = listA.FindAll(x => x > 2);
			Console.WriteLine("listB : "+listB.Stringify());
			listB.Clear();

			listB = listA.FindAll(x => x > 10);
			Console.WriteLine("listB : "+listB.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.FindIndex\n");
			var list = new List<int>() { 8, 3, 6, 4, 2 };
			int index = list.FindIndex(x => x < 5);
			Console.WriteLine("index : "+index);

			index = list.FindIndex( startIndex: 2, match: x => x < 5);
			Console.WriteLine("index : "+index);

			index = list.FindIndex( startIndex: 2, count: 2, match: x => x < 5);
			Console.WriteLine("index : "+index);

			index = list.FindIndex( startIndex: 2, count: 2, match: x => x < 3);
			Console.WriteLine("index : "+index);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.FindLast\n");
			var list = new List<int>() { 8, 3, 2 };
			int item = list.FindLast(x => x < 5);
			Console.WriteLine("item  : "+item);

			item = list.FindLast(x => x > 10);
			Console.WriteLine("item  : "+item);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.FindLastIndex\n");
			var list = new List<int>() { 2, 4, 6, 3, 8 };
			int index = list.FindLastIndex(x => x < 5);
			Console.WriteLine("index : "+index);

			index = list.FindLastIndex( startIndex: 2, match: x => x < 5);
			Console.WriteLine("index : "+index);

			index = list.FindLastIndex( startIndex: 2, count: 2, match: x => x < 5);
			Console.WriteLine("index : "+index);

			index = list.FindLastIndex( startIndex: 2, count: 2, match: x => x < 3);
			Console.WriteLine("index : "+index);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.ForEach\n");
			var list = new List<int>() { 8, 3, 2 };
			Console.Write("list  : ");
			list.ForEach(x => { Console.Write("{0} ",x); });
			Console.WriteLine("");
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.GetRange\n");
			var listA = new List<int>() { 8, 3, 6, 4, 2 };
			var listB = listA.GetRange( index: 1, count: 3);
			Console.WriteLine("listB : "+listB.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.IndexOf\n");
			var list = new List<int>() { 8, 3, 2, 6, 8 };
			int index = list.IndexOf(8);
			Console.WriteLine("index : "+index);

			index = list.IndexOf(item: 8, index: 1);
			Console.WriteLine("index : "+index);

			index = list.IndexOf(item: 3, index: 1, count: 2);
			Console.WriteLine("index : "+index);

			index = list.IndexOf(item: 8, index: 1, count: 2);
			Console.WriteLine("index : "+index);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Insert\n");
			var list = new List<int>() { 8, 3, 2 };
			list.Insert(index: 1, item: 5);
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.InsertRange\n");
			var listA = new List<int>() { 8, 3, 2 };
			var listB = new List<int>() { 5, 7 };
			Console.WriteLine("listA : "+listA.Stringify());
			Console.WriteLine("listB : "+listB.Stringify());
			listA.InsertRange(index: 1, collection: listB);
			Console.WriteLine("listA : "+listA.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.LastIndexOf\n");
			var list = new List<int>() { 8, 3, 2, 6, 8 };
			int index = list.LastIndexOf(8);
			Console.WriteLine("index : "+index);

			index = list.LastIndexOf( item: 8, index: 3);
			Console.WriteLine("index : "+index);

			index = list.LastIndexOf( item: 6, index: 3, count: 2);
			Console.WriteLine("index : "+index);

			index = list.LastIndexOf( item: 8, index: 3, count: 2);
			Console.WriteLine("index : "+index);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Remove\n");
			var list = new List<int>() { 8, 4, 2, 4 };
			Console.WriteLine("list  : "+list.Stringify());
			list.Remove(item: 4);
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.RemoveAll\n");
			var list = new List<int>() { 8, 3, 6, 2 };
			Console.WriteLine("list  : "+list.Stringify());

			list.RemoveAll(x => x < 4);
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.RemoveAt\n");
			var list = new List<int>() { 8, 3, 6, 2 };
			Console.WriteLine("list  : "+list.Stringify());

			list.RemoveAt(index: 2);
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.RemoveRange\n");
			var list = new List<int>() { 8, 3, 6, 2, 4, 5 };
			Console.WriteLine("list  : "+list.Stringify());

			list.RemoveRange(index: 2, count: 3);
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Reverse\n");
			var list = new List<int>() { 8, 3, 2 };
			Console.WriteLine("list  : "+list.Stringify());

			list.Reverse();
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.Sort\n");
			var list = new List<int>() { 8, 3, 6, 2 };
			Console.WriteLine("list  : "+list.Stringify());

			list.Sort();
			Console.WriteLine("list  : "+list.Stringify());

			list = new List<int>() { 8, 3, 6, 2 };
			list.Sort((x, y) => x.CompareTo(y));
			Console.WriteLine("list  : "+list.Stringify());

			list.Sort((x, y) => y.CompareTo(x));
			Console.WriteLine("list  : "+list.Stringify());

			list.Sort(new MyComparer());
			Console.WriteLine("list  : "+list.Stringify());

			list = new List<int>() { 8, 3, 6, 2, 4, 5 };
			Console.WriteLine("list  : "+list.Stringify());
			list.Sort(index: 2, count: 3, comparer: new MyComparer());
			Console.WriteLine("list  : "+list.Stringify());
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.ToArray\n");
			var list = new List<int>() { 8, 3, 2 };
			int[] array = list.ToArray();
			Console.WriteLine("array : "+array.Stringify());

			list.Clear();
			array = list.ToArray();
			Console.WriteLine("array : "+array.Stringify());

		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.TrimExcess\n");
			var list = new List<int>(8) { 1, 2, 3, 4 ,5 };
			Console.WriteLine("list  : "+list.Stringify());
			Console.WriteLine("list.Count : "+list.Count);
			Console.WriteLine("list.Capacity : "+list.Capacity);
			list.TrimExcess();
			
			Console.WriteLine("list  : "+list.Stringify());
			Console.WriteLine("list.Count : "+list.Count);
			Console.WriteLine("list.Capacity : "+list.Capacity);

			Console.WriteLine("");
			list = new List<int>(8) { 1, 2, 3, 4, 5, 6, 7  };
			Console.WriteLine("list  : "+list.Stringify());
			Console.WriteLine("list.Count : "+list.Count);
			Console.WriteLine("list.Capacity : "+list.Capacity);
			list.TrimExcess();
			
			Console.WriteLine("list  : "+list.Stringify());
			Console.WriteLine("list.Count : "+list.Count);
			Console.WriteLine("list.Capacity : "+list.Capacity);
		}
		////////////////////////////////////////////////////////////////
		{
			Console.WriteLine("\n\tList.TrueForAll\n");
			var list = new List<int>(8) { 8, 3, 2 };
			Console.WriteLine("list  : "+list.Stringify());

			bool result = list.TrueForAll(x => x < 10);
			Console.WriteLine("x => x < 10  result : "+result);

			result = list.TrueForAll(x => x < 5);
			Console.WriteLine("x => x < 5   result : "+result);
		}
  }
}