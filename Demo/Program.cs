namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1
            //int A = 10 , B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine();
            //Helper<int>.Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Console.WriteLine();

            //double x = 10.5, y = 20.5;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine();
            //Helper<double>.Swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Console.WriteLine();

            //Point p1 = new Point(10, 20);
            //Point p2 = new Point(30, 40);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine();
            //Helper<Point>.Swap(ref p1, ref p2);
            //Console.WriteLine(p1); 
            //Console.WriteLine(p2);
            #endregion

            #region Video 2
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int Index = Helper.SearchArray(Numbers, 5);
            Console.WriteLine(Index);

            Point[] points = new Point[]
            {
                new Point(10,20),
                new Point(30,40),
                new Point(50,60),
                new Point(70,80),
                new Point(90,100),
            };
            Point point3 = new Point(50, 60);
            Index = Helper.SearchArray(points, point3);
            Console.WriteLine(Index);

            Employee[] employees = new Employee[]
            {
                new Employee{ID = 1, Name = "Ahmed", Salary = 1000},
                new Employee{ID = 2, Name = "Ali", Salary = 2000},
                new Employee{ID = 3, Name = "Omar", Salary = 3000},
                new Employee{ID = 4, Name = "Sara", Salary = 4000},
            };
            Employee employee3 = new Employee { ID = 5, Name = "Nora", Salary = 5000 };
             Index = Helper.SearchArray(employees, employee3);
            Console.WriteLine(Index);
            Employee employee = new Employee() { ID = 1, Name = "Mostafa", Salary = 1000 };
            Employee employee2 = new Employee() { ID = 1, Name = "Mostafa", Salary = 1000 };
            if (employee.Equals(employee2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            #endregion
        }
    }
}
