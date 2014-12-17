using System ;
internal struct Point : IComparable
{
	private Int32 m_x, m_y ;
	// Конструктор . просто и н и ц и ал и з и рующий поля
	public Point ( Int32 x, Int32 у) {
		m_x = x ;
		m_y = у ;
	}
	// Переопредел я е м метод ToSt r i ng , у наследо в а н ный от System . Va l ueType
	public override String ToString ( ) 
	{
	//Воз в ращаем Poi nt к а к строку
		return String.Format ( " ({0}.{1})", m_x , m_y ) ;
	}
	// Без о n а с н а я в отноше н и и т и п о в реал и з а ц и я метода Compa reTo
	public Int32 CompareTo ( Point other ) 
	{
		// Исnол ь зуем теорему Пифа г ора для оп ределе н и я точ ки .
		// н а и более удаленной от н а ч ал а коорд и н а т С О . 0 )
		return Math.Sign( Math.Sqrt ( m_x * m_x + m_y * m_y )
			- Math . Sqrt ( other . m_x * other . m_x + other . m_y * other . m_y ) ) ;
	}

	// Реал и з а ц и я метода Compa reTo и н терфейса I Compa raЫ e
	public Int32 CompareTo ( Object o ) 
	{
		if (GetType () != o.GetType ()) {
			throw new ArgumentException (" o is not а Point ");
		}
			// Вызов безопасн о г о в отноше н и и т и п о в метода Compa reTo
		return CompareTo ((Point)o);
	}
}

public static class Program
{
	public static void Main ()
	{
		// Создаем в стеке д в а э кз е м п л я ра Poi nt
		Point p1 = new Point (10, 10);
		Point p2 = new Point (20, 20);
		// р 1 НЕ п а куется для вы з ова ToSt r i ng ( в иртуал ь н ы й метод )
		Console.WriteLine (p1.ToString ()); // " ( 1 0 . 1 0 )"
		// р ПАКУЕТСЯ для вы з ова Getтype ( н е в иртуал ь ный метод )
		Console.WriteLine (p1.GetType ()); // " Poi nt "
		// р1 НЕ п а куется для вы з ова Compa reTo
		// р2 НЕ п а куется . потому ч т о в ы з в а н Compa reTo ( Poi nt )
		Console.WriteLine (p1.CompareTo (p2)); // " - 1 "
		// р 1 Н Е па куетс я . а ссыл ка раз мещается в с
		IComparable c = p1;
		Console.WriteLine (c.GetType ()); // " Poi nt "

		// р1 НЕ п а куется для в ы з о в а Compa reTo
		// Пос кол ь ку в Compa reTo не передается пере м е н н а я Poi nt .
		// вызывается Compa reTo ( Object ) . которому нужна ссыл ка
		// на упакованный Poi nt
		// с НЕ п а куется . потому что уже ссылается на у п а к о в а н н ы й Poi nt
		Console.WriteLine (p1.CompareTo (c)); // " О "
		//с НЕ пакуется . потому ч т о уже ссылается на у п а к о в а н н ы й Poi nt
		// р2 ПАКУЕТСЯ . потому ч то в ы з ы вается Compa reTo ( Obj ect )
		Console.WriteLine (c.CompareTo (p2)); // " - 1 "
		//с п а куется . а п ол я копируются в р2
		p2 = (Point)c;
		//Убеждаемся . ч то поля скопиро в а н ы в р2
		Console.WriteLine (p2.ToString ()); // " ( 1 0 . 1 0 ) "

	}
}