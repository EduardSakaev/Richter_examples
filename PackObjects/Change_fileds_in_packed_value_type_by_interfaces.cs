using System;

// И н терфейс . оnредел я ющ ий метод Cha nge
internal interface IChangeBoxedPoint {
	void Change (Int32 х , Int32 у) ;
}

//Poi nt значимый тиn
internal struct Point : IChangeBoxedPoint
{
	private Int32 m_x, m_y;

	public Point (Int32 x, Int32 y) {
		m_x = x ;
		m_y = y ;
	}

	public void Change (Int32 х, Int32 у) {
		m_x = х ;
		m_y = у ;
	}

	public override String ToString () {
		return String.Format ("({0},{1})", m_x, m_y);
	}
}

public sealed class Program {
	public static void Main () {
	Point p = new Point (1 , 1);
		Console.WriteLine ( p);  // p пакуется
		p.Change (2, 2);        //
		Console.WriteLine (p);   // не пакуется
		Object o = p;            // пакуется р упаковывается в третий разо ссылается н а упакованный объект типа Poi nt.
		Console.WriteLine (o); 
		/* Далее р упаковывается в третий раз
		о ссылается н а упакованный объект
		типа Poi nt. При третьем обращении к W r i tel i ne снова выводится ( 2, 2 ) , что
		опять вполне ожидаемо. И наконец, я обращаюсь к методу Cha nge для изме­
		нения полей в упакованном объекте типа Poi nt. Между тем Object (тип пере­
		менной о) ничего не •знает• о методе Cha nge, так что сначала нужно привести
		о к Poi nt. При таком приведении типа о распаковывается, и поля упакованного
		объекта типа Poi nt копируются во временный объект типа Poi nt в стеке потока.
		Поля m_х и m_у этого временного объекта устанавливаются равными 3, но это
		обращение к Cha nge не влияет на упакованный объект Poi nt. При обращении
		к Wri tel i ne снова выводится ( 2, 2 ) . Для многих разработчиков это оказывается
		иео�даииоапью.*/

		((Point)o).Change(3, 3); //will still print 2,2 :(
		Console.WriteLine (o);

		// р упаковывается . у п а к о в а н н ы й объ ект и з м ен я ется и освобождается
		((IChangeBoxedPoint) p ).Change ( 4, 4 );
		Console.WriteLine(p);

		// Упа кованный объ ект и з м е н я ется и выводится
		((IChangeBoxedPoint)o).Change ( 5 , 5 ) ;
		Console.WriteLine(o);
	}
}

/*There is the way to fix the problem:
 * Можно пофиксить проблему, применив интерфейс IChangeBoxedPoint */




