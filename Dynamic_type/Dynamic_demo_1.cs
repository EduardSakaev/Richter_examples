using System;

public static class DynamicDemo {
	public static void Main() {
		for (Int32 demo = 0 ; demo < 2 ; demo++ ) {
			dynamic arg = (demo == 0) ? (dynamic)5 : (dynamic)'A';
			dynamic result = Plus (arg);
			M (result);
		}
	}
		private static dynamic Plus ( dynamic arg ) { return arg + arg; }
		private static void M(Int32 n) { Console.WriteLine ( " M ( i nt32 ) : " + n ); }
		private static void M(String s) { Console.WriteLine ( " M ( St r i ng ) : " + s );}
}

