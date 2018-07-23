using System;
using System.Collections.Generic;

public static class ExClass{
	public static string Stringify<T>(this IEnumerable<T> list){
		string s = string.Empty;
		foreach(var v in list){
			s += v.ToString() + " ";
		}
		if (s.Length > 0)						
			s = s.Substring(0,s.Length -1);
		return s;
	}
}

public class data{
	public int raw{get;set;}
	public int col{get;set;}
	public data(int r, int c){
		raw = r;
		col = c;
	}
}

class MainClass {
  public static void Main (string[] args) {
		int[][] image = new int[][]{
			new int[] {0,0,0,0,0,0,0},
			new int[] {0,0,1,1,1,0,0},
			new int[] {0,0,1,0,1,0,0},
			new int[] {0,0,1,0,1,0,0},
			new int[] {0,0,1,0,1,0,0},
			new int[] {0,0,1,1,1,0,0},
			new int[] {0,0,0,0,0,0,0}
		};

		Console.WriteLine(image[0].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[1].Stringify() == "0 0 1 1 1 0 0");
		Console.WriteLine(image[2].Stringify() == "0 0 1 0 1 0 0");
		Console.WriteLine(image[3].Stringify() == "0 0 1 0 1 0 0");
		Console.WriteLine(image[4].Stringify() == "0 0 1 0 1 0 0");
		Console.WriteLine(image[5].Stringify() == "0 0 1 1 1 0 0");
		Console.WriteLine(image[6].Stringify() == "0 0 0 0 0 0 0");
		
		FloodFill(ref image, 1/*행*/, 2/*열*/, 7/*수*/);
		
		Console.WriteLine(image[0].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[1].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[2].Stringify() == "0 0 7 0 7 0 0");
		Console.WriteLine(image[3].Stringify() == "0 0 7 0 7 0 0");
		Console.WriteLine(image[4].Stringify() == "0 0 7 0 7 0 0");
		Console.WriteLine(image[5].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[6].Stringify() == "0 0 0 0 0 0 0");

		FloodFill(ref image, 2/*행*/, 3/*열*/, 7/*수*/);

		Console.WriteLine(image[0].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[1].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[2].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[3].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[4].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[5].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[6].Stringify() == "0 0 0 0 0 0 0");

		FloodFill(ref image, 2/*행*/, 3/*열*/, 8/*수*/);

		Console.WriteLine(image[0].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[1].Stringify() == "0 0 8 8 8 0 0");
		Console.WriteLine(image[2].Stringify() == "0 0 8 8 8 0 0");
		Console.WriteLine(image[3].Stringify() == "0 0 8 8 8 0 0");
		Console.WriteLine(image[4].Stringify() == "0 0 8 8 8 0 0");
		Console.WriteLine(image[5].Stringify() == "0 0 8 8 8 0 0");
		Console.WriteLine(image[6].Stringify() == "0 0 0 0 0 0 0");
		
		FloodFill(ref image, 2/*행*/, 3/*열*/, 7/*수*/);

		Console.WriteLine(image[0].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[1].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[2].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[3].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[4].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[5].Stringify() == "0 0 7 7 7 0 0");
		Console.WriteLine(image[6].Stringify() == "0 0 0 0 0 0 0");

		FloodFill(ref image, 0/*행*/, 0/*열*/, 7/*수*/);
		
		Console.WriteLine(image[0].Stringify() == "7 7 7 7 7 7 7");
		Console.WriteLine(image[1].Stringify() == "7 7 7 7 7 7 7");
		Console.WriteLine(image[2].Stringify() == "7 7 7 7 7 7 7");
		Console.WriteLine(image[3].Stringify() == "7 7 7 7 7 7 7");
		Console.WriteLine(image[4].Stringify() == "7 7 7 7 7 7 7");
		Console.WriteLine(image[5].Stringify() == "7 7 7 7 7 7 7");
		Console.WriteLine(image[6].Stringify() == "7 7 7 7 7 7 7");

		FloodFill(ref image, 0/*행*/, 0/*열*/, 0/*수*/);

		Console.WriteLine(image[0].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[1].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[2].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[3].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[4].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[5].Stringify() == "0 0 0 0 0 0 0");
		Console.WriteLine(image[6].Stringify() == "0 0 0 0 0 0 0");
  }


	public static void FloodFill(ref int[][] image, int raw, int col, int ChangeTo){
		int stdnumber = image[raw][col];
		Queue<int> qRaw = new Queue<int>();
		Queue<int> qCol = new Queue<int>();

		int[,] val = new int[image.Length,image[0].Length];
	
		// Console.WriteLine("before while");
		
		qRaw.Enqueue(raw);
		qCol.Enqueue(col);

		while(qRaw.Count > 0){
			
			raw = qRaw.Dequeue();
			col = qCol.Dequeue();

			image[raw][col] = ChangeTo;
//			 Console.WriteLine(" {0} , {1}",raw,col);

			if(raw > 0){
				if(stdnumber == image[raw-1][col] && val[raw-1,col] == 0){
					qRaw.Enqueue(raw-1);
					qCol.Enqueue(col);
					val[raw-1,col] = 1;
					// Console.WriteLine("in  {0} , {1}",raw-1,col);
				}
			}

			if(col > 0){
				if(stdnumber == image[raw][col-1] && val[raw,col-1] == 0){
					qRaw.Enqueue(raw);
					qCol.Enqueue(col-1);
					val[raw,col-1] = 1;
					// Console.WriteLine("in  {0} , {1}",raw,col-1);
				}
			}

			if(raw < 6){
				if(stdnumber == image[raw+1][col] && val[raw+1,col] == 0){
					qRaw.Enqueue(raw+1);
					qCol.Enqueue(col);
					val[raw+1,col] = 1;
					// Console.WriteLine("in  {0} , {1}",raw+1,col);
				}
			}

			if(col < 6){
				if(stdnumber == image[raw][col+1] && val[raw,col+1] == 0){
					qRaw.Enqueue(raw);
					qCol.Enqueue(col+1);
					val[raw,col+1] = 1;
					// Console.WriteLine("in  {0} , {1}",raw,col+1);
				}
			}

		}
	}

/*
	public static void FloodFill(ref int[][] image, int raw, int col, int ChangeTo){
		int stdnumber = image[raw][col];
		Queue<data> q = new Queue<data>();
		int[,] val = new int[image.Length,image[0].Length];
		data d = new data(raw,col);
		q.Enqueue(d);
		Console.WriteLine("before while");
		// Console.WriteLine(" {0} , {1}",raw,col);
		while(q.Count > 0){

			d = q.Dequeue();
			raw = d.raw;
			col = d.col;
			image[d.raw][d.col] = ChangeTo;
			Console.WriteLine(" {0} , {1}",raw,col);

			if(raw > 0){
				if(stdnumber == image[raw-1][col] && val[raw-1,col] == 0){
					q.Enqueue(new data(raw-1,col));
					val[raw-1,col] = 1;
					Console.WriteLine("in  {0} , {1}",raw-1,col);
				}
			}

			if(col > 0){
				if(stdnumber == image[raw][col-1] && val[raw,col-1] == 0){
					q.Enqueue(new data(raw,col-1));
					val[raw,col-1] = 1;
					Console.WriteLine("in  {0} , {1}",raw,col-1);
				}
			}
//			if(raw < image.GetUpperBound(0) -1)
			if(raw < 5){
				if(stdnumber == image[raw+1][col] && val[raw+1,col] == 0){
					q.Enqueue(new data(raw+1,col));
					val[raw+1,col] = 1;
					Console.WriteLine("in  {0} , {1}",raw+1,col);
				}
			}
//			if(col < image.GetUpperBound(0) -1)
			if(col < 5){
				if(stdnumber == image[raw][col+1] && val[raw,col+1] == 0){
					q.Enqueue(new data(raw,col+1));
					val[raw,col+1] = 1;
					Console.WriteLine("in  {0} , {1}",raw,col+1);
				}
			}
			
//			Console.WriteLine("out {0} , {1}",raw,col);
		}
	}*/
}