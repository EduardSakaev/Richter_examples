using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal struct Point
{
    public Int32 m_x, m_y;

    public Point(Int32 x, Int32 y)  //ok!
    {
        m_x = x;
        m_y = y;
    } 

   /* public Point()  //not ok (Structs cannot contain explicit paramaterless constructors 
   { //нельзя создавать конструкторы по умолчанию для значимых типов
       m_x = m_y = 5;
   }*/
}

internal sealed class Rectangle
{
    public Point m_topleft, m_topright;

    public Rectangle()
    {
        m_topleft = new Point(1, 1);
        m_topright = new Point(2, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
    }
}
