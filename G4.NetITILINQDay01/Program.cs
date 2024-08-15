using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace G4.NetITILINQDay01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Named Obj
            //Student std1 = new Student() { Id = 1, Name = "Mohamed" };
            //// Named Obj => Object has ref Name
            //Console.WriteLine(std1); // namespace.classname
            //std1.Name = "ahmed";

            //var arr = new int[] { 1, 2, 3 };
            #endregion

            #region Collections
            ///Base for all collections
            ///1- IEnumerable
            ///2- ICollection
            //List<int> list = new List<int>();

            //IEnumerable<int> nums = new List<int>();
            //Dictionary<int,string> dic = new Dictionary<int,string>();
            //IEnumerable<KeyValuePair<int,string>> nums3 = new Dictionary<int,string>();
            ////IEnumerable<int> nums2 = new IEnumerable<int>(); XXXXXX Interface
            #endregion

            #region Anonymous Obj
            //// obj without name
            //List<Student> students = new List<Student>()
            //{ 
            //    new Student{Id=1, Name="ay hage"} 
            //};
            #endregion

            #region Anonymous Function
            //(int x, int y) => { return x + y; };

            // Delegate
            // 3 

            // 1-Predcite => Return bool and take 1 input param
            //Predicate<Student> prd1 = std => std != null;

            //// 2- Action => take from 0 to 16 Inputs param and return void
            //Action action = () =>
            //{
            //    int y = 5;
            //    Console.WriteLine("Hello Action");
            //};

            //// 3- Func => Take from 0 to 16 and return Genaric
            //Func<int> func1 = () => { return 5; };
            //Func<int, int,bool> func2 = (c,y) => { return true; };
            #endregion

            #region Anonymous Type
            //var s1 = new { Id = 1, Name = "Ali", Age = 25 };
            //Console.WriteLine(s1.GetType());
            //// obj on the fly 

            //var s2 = new { Id = 1, Name = "Ali", Age = 25 };
            //// Read Only
            ////s2.Name = "Mohamed";
            #endregion

            #region Before LINQ
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> ints2 = new List<int>();
            #endregion

            #region LINQ
            // Features Added on Collections
            // 40 Additional Methods (Extention Methods)
            // "LINQ stands for Language Integrated Query, a Microsoft .NET Framework
            //that provides a standardized way to query data from various data sources using
            //a common syntax within programming languages like C#"	
            //
            //Extention Method	
            #endregion

            #region Extention Method
            //string str = "Hello World From Ismailia";
            //int count = Helper.GetWordsCount(str);
            //Console.WriteLine(count);

            //int count2 = str.GetWordsCountEx();
            //int count3 = ExtentionMethod.GetWordsCountEx(str);
            //Console.WriteLine(count2);
            #endregion

            #region LINQ
            //// 1- Query Syntax
            //// 2- Method Syntax [Fluent Syntax]
            //// 

            //// 1- Query Syntax
            //// Step 1 Data Source
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// Step 2 Query
            //// Data Source
            //// Condition
            //// Select
            //// from where select
            //var QuerySyntax = from item in ints // Data Source
            //                  where item > 5
            //                  select item;

            //foreach (var item in QuerySyntax)
            //{
            //    Console.WriteLine(item);
            //}

            //// 2- Method Syntax [Fluent Syntax]

            //var MethodSyntax = ints.Where(i => i > 5);
            #endregion


            #region Repository
            var Employees = Repository.GetEmployees();
            var Departments = Repository.GetDepartments();
            //foreach (var item in Employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Try => Enumerable => Class that has linq Methods
            //var emp1 = Employees.Min(emp => emp.Id);
            //var emp2 = Enumerable.Min(Employees,emp=>emp.Id); 
            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);
            #endregion

            #region LINQ Query Expression
            //// Select all Employees 
            //// select * from employees => SQL
            //var q1 = from item in Employees
            //         select item;

            //var q2 = from item in Employees
            //         where item.DeptId == 1
            //         select item;

            //// from select where
            //var q3 = from item in Employees
            //         where item.Age > 35
            //         select item;

            //var q4 = from item in Employees
            //         where item.Age > 35 && item.DeptId == 1
            //         select item;

            //var q5 = from item in Employees
            //         where item.Salary == Employees.Max(w => w.Salary)
            //         select item;

            ////Console.WriteLine(q5); XXXXXXXXXX where always return list 
            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Method Syntax [fluent syntax] Linq , Lambda Exp => function chaining
            //// Select all empoyees
            //var q6 = Employees.ToList();

            //var q7 = Employees.Where(emp => emp.DeptId == 1);

            //var q8 = Employees.Where(emp => emp.Age > 40);

            ////var q4 = from item in Employees
            ////         where item.Age > 35 && item.DeptId == 1
            ////         select item;

            //var q9 = Employees.Where(emp => emp.Age > 35 && emp.DeptId == 1);
            //var q9_2 = Employees.Where(emp => emp.Age > 35).Where(emp => emp.DeptId == 1);

            //var q10 = Employees //10
            //    .Where(emp => emp.Age > 35) // => 6
            //    .Where(emp => emp.DeptId == 1) // =>4 
            //    .OrderByDescending(emp => emp.Age); //=>4
            //// function chaining


            //var q11 = Employees
            //    .Where(emp => emp.Age > 35)
            //    .OrderBy(emp => emp.DeptId);


            //var q11_1 = Employees
            //    .Where(emp => emp.Age > 35)
            //    .OrderBy(emp => emp.DeptId)
            //    .ThenBy(emp=>emp.Name);


            //foreach (var item in q11)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in q11_1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Single Obj => These operators return a single element from a sequence. Examples First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, and ElementAt.
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt

            var q12 = Employees.First(emp => emp.Id == 1);
            var q13 = Employees.FirstOrDefault(emp => emp.Id == 1);

            var q14 = Employees.First();

            //Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
            //var q15 = Employees.First(e => e.DeptId == 99);

            //null empty
            var q16 = Employees.FirstOrDefault(e => e.DeptId == 99);
            //if (q16 != null)
            //{
            //    Console.WriteLine(q16);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            var q17 = Employees.Last();
            //var q18 = Employees.Last(e => e.Id == 50);
            var q19 = Employees.LastOrDefault(e => e.Id == 50);


            //if list contain more than one element => Unhandled exception. System.InvalidOperationException: Sequence contains more than one element
            //var q20 = Employees.Single();

            // if list does not contain elements => Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
            //var q21 = Employees.Single(e=>e.DeptId==99);

            //if list contain more than one element => Unhandled exception. System.InvalidOperationException: Sequence contains more than one element
            //var q22 = Employees.SingleOrDefault();


            // if list does not contain return null
            //var q23 = Employees.SingleOrDefault(e=>e.DeptId==99);

            // if found element no error else Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative
            // and less than the size of the collection. (Parameter 'index')
            //var q24 = Employees.ElementAt(3);
            //var q25 = Employees.ElementAt(20);

            // if found element no error else return dedault
            var q26 = Employees.ElementAtOrDefault(3);
            var q27 = Employees.ElementAtOrDefault(20);
            Console.WriteLine(q27);
            #endregion
        }
    }
}
