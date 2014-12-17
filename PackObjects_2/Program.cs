using System;
using System.Collections;

struct Point
{
	public Int32 x, y;
}

class MainClass
{
	public static void Main (string[] args)
	{
		ArrayList a = new ArrayList() ;
		Point p ;
		// Выдел яется п а м я т ь для Poi nt ( не в куч е )
		for ( Int32 i = 0 ; i < 10 ; i ++ ) 
		{
			p.x = p.y = i; // И н и ц и ал и з а ц и я членов в нашем з н а ч и мом типе
			a.Add(p); // Упа ков ка з н а ч и м о г о т и п а и доба вление
			// ссыл к и в Arrayl i st
		}

	}
}
