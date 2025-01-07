using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static int? SumArrayList(ArrayList arrayList)
        {
            int? Sum = 0;    
            if (arrayList is not null)
            {
                for(int i = 0; i<arrayList.Count; i++)
                {
                    Sum += (int?)arrayList[i];
                }
            }
            return Sum;
        }
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
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int Index = Helper.SearchArray(Numbers, 5);
            //Console.WriteLine(Index);

            //Point[] points = new Point[]
            //{
            //    new Point(10,20),
            //    new Point(30,40),
            //    new Point(50,60),
            //    new Point(70,80),
            //    new Point(90,100),
            //};
            //Point point3 = new Point(50, 60);
            //Index = Helper.SearchArray(points, point3);
            //Console.WriteLine(Index);

            //Employee[] employees = new Employee[]
            //{
            //    new Employee{ID = 1, Name = "Ahmed", Salary = 1000},
            //    new Employee{ID = 2, Name = "Ali", Salary = 2000},
            //    new Employee{ID = 3, Name = "Omar", Salary = 3000},
            //    new Employee{ID = 4, Name = "Sara", Salary = 4000},
            //};
            //Employee employee3 = new Employee { ID = 5, Name = "Nora", Salary = 5000 };
            // Index = Helper.SearchArray(employees, employee3);
            //Console.WriteLine(Index);
            //Employee employee = new Employee() { ID = 1, Name = "Mostafa", Salary = 1000 };
            //Employee employee2 = new Employee() { ID = 1, Name = "Mostafa", Salary = 1000 };
            //if (employee.Equals(employee2))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}
            #endregion

            #region Video 3
            //Employee emp1 = new Employee { ID = 1000, Name = "Ahmed", Salary = 1};
            //Employee emp2 = new Employee { ID = 1, Name = "Ahmed", Salary = 1000 };
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            ////if (emp1.Equals(emp2))
            ////    Console.WriteLine("Equals");
            ////else
            ////    Console.WriteLine("Not Equals");
            #endregion

            #region Video 4
            ////int[] Numbers = { 5, 4, 3, 2, 1 };
            ////Helper.BubbleSort(Numbers);
            ////foreach (int number in Numbers)
            ////{
            ////    Console.WriteLine(number);
            ////}
            //Point[] points = new Point[]
            //{
            //    new Point(20,30),
            //    new Point(10,20),
            //    new Point(1,2),
            //    new Point(2,3)
            //};
            //Helper<Point>.BubbleSort(points);
            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point);
            //}

            ////Employee employee = new Employee() {ID = 1 , Name = "Mostafa"  , Salary = 10000};
            ////Employee employee2 = new Employee() { ID = 2, Name = "Mohamed" , Salary=2000};
            ////Employee employee3 = new Employee() { ID = 3, Name = "Ahmed", Salary = 1000 };
            ////Employee[] employees = new Employee[] { employee, employee2, employee3 };
            ////Helper<Employee>.BubbleSort(employees);
            ////foreach (Employee emp in employees)
            ////{
            ////    Console.WriteLine(emp);
            ////}
            #endregion

            #region Video 6
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Count ==> {arrayList.Count}");
            Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            arrayList.Add(1);
            Console.WriteLine($"Count ==> {arrayList.Count}");
            Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            arrayList.AddRange(new int[] {2,3,4});
            Console.WriteLine($"Count ==> {arrayList.Count}");
            Console.WriteLine($"Capacity ==> {arrayList.Capacity}");

            ArrayList arrayList1 = new ArrayList(5);
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.AddRange(new int[] {1,2,3,4,5});
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.Add(6);
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.TrimToSize();
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.Add("Mostafa");

            int? Sum = SumArrayList(arrayList1);
            Console.WriteLine(Sum);
            #endregion
        }
    }
}
