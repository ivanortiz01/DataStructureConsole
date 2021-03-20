using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
           LinqSkipAndTake();

            DataStructure();
        }

        public static void DataStructure()
        {
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }

        public static void LinqSkipAndTake()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var example1 = numbers.Skip(3); // return {4, 5, 6, 7, 8, 9, 10}
            Console.WriteLine("example1");
            foreach (var item in example1)
            {
                Console.Write(" - " + item);
            }
            Console.WriteLine();

            var example2 = numbers.Take(3); // return {1, 2, 3}

            var example3 = numbers.Skip(3).Take(4); // return {4, 5, 6, 7}

            var example4 = numbers.Take(4).Skip(3); // return {4}
            Console.WriteLine("example4");
            foreach (var item in example4)
            {
                Console.Write(" - " + item);
            }
            Console.WriteLine();

            //Pagination example
            int numberOfObjectsPerPage = 10;
            int pageNumber = 1;
            var example5 = numbers.Skip(numberOfObjectsPerPage * (pageNumber - 1)).Take(numberOfObjectsPerPage);
            Console.WriteLine($"example5, page {pageNumber}");
            foreach (var item in example5)
            {
                Console.Write(" - " + item);
            }
            Console.WriteLine();

            pageNumber = 2;
            example5 = numbers.Skip(numberOfObjectsPerPage * (pageNumber - 1)).Take(numberOfObjectsPerPage);
            Console.WriteLine($"example5, page {pageNumber}");
            foreach (var item in example5)
            {
                Console.Write(" - " + item);
            }
            Console.WriteLine();

            pageNumber = 3;
            example5 = numbers.Skip(numberOfObjectsPerPage * (pageNumber - 1)).Take(numberOfObjectsPerPage);
            Console.WriteLine($"example5, page {pageNumber}");
            foreach (var item in example5)
            {
                Console.Write(" - " + item);
            }
            Console.WriteLine();
        }        
    }
}
