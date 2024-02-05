using System;

namespace HW2
{
    public class Square
    {
        public float Edge { get; set; }

        public void GetEdge()
        {
            Console.WriteLine("Edge = " + Edge);
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter: " + Edge*4);
        }

        public void Area()
        {
            Console.WriteLine("Area: " + Edge * Edge);
        }

        public void ShowAllInfor()
        {
            GetEdge();
            Perimeter();
            Area();
        }
    }
    internal class Ex1
    {
        public static void Main(string[] args)
        {
            Square HinhVuong = new Square();
            Console.WriteLine("Enter value of edge: ");
            HinhVuong.Edge = Convert.ToSingle(Console.ReadLine());
            HinhVuong.ShowAllInfor();
        }
    }
}
