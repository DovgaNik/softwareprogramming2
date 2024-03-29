namespace shapes
{
    public class Program
    {
        public static void Main() { 
        
        
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Rectangle r1 = new Rectangle(p1, p2);
            Rectangle r2 = new Rectangle(r1);
            Circle c1 = new Circle(p1, 5);
            Circle c2 = new Circle(c1);
            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
            System.Console.WriteLine(r1);
            System.Console.WriteLine(r2);
            System.Console.WriteLine(c1);
            System.Console.WriteLine(c2);

        
        
        }

    }
}