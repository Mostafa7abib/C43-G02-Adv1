namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1
            int A = 10 , B = 20;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine();
            Helper<int>.Swap(ref A, ref B);
            Console.WriteLine(A);
            Console.WriteLine(B);

            Console.WriteLine();
            
            double x = 10.5, y = 20.5;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();
            Helper<double>.Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine();

            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();
            Helper<Point>.Swap(ref p1, ref p2);
            Console.WriteLine(p1); 
            Console.WriteLine(p2);
            #endregion
        }
    }
}
