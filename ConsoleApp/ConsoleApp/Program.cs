using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public  delegate void sample (int a, int b);

        public static  void add(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main(string[] args)
        {

            sample obj = add;
            obj(10, 20);

            double d = 6 + 12 * 3 - 5 / 2;
                     int i = 10 * 20;
            Console.WriteLine(d);
            Console.WriteLine(i*10   );
            Console.ReadLine();
        }

        private static void MainMethods()
        {
            //int totalCountToEval = int.Parse(Console.ReadLine());
            //FizzBuzzProblem(totalCountToEval);

            //IncrementNumber(1);
            //MultiplesOfNumber(50);
            //CalculatePower(10, 20);

            //FindMaxSumOfRowColumnsInMatrix(3, 4, new int[]{ 1, 2, 3, 4, 5, 6, 1, 2, 4, 3,7,18 });
            //MaximumOrderVol_HR();

            //IndexerInMatrix();

            ////extension methods
            //string abc = "10.56";
            //double d = Double.Parse(abc);
            //double a = abc.ToDouble();
            //Console.WriteLine(a.GetType());

            //A objB = new B();
            //A objC = new C();

            //objB.Sample();
            //objC.Sample();

            //SecondHighestInArray();
            //FizzBuzzProblem(15);
            //SortingOfStrings();

            //string str = "cars are very cool so are arcs";
            //PrintAnagrams(str);
            //SumOfDigits(11195461);
        }
        private static void SortingOfStrings()
        {
            //var arr1 = "one".ToCharArray();
            //var arr2 = "two".ToCharArray();
            //var arr3 = "three".ToCharArray();
            List<string> stringList = new List<string>() { "one", "two", "three" };
            stringList.Sort();
            var result = new StringBuilder();
            foreach (var item in stringList)
            {
                result.Append(item);
            }

            Console.WriteLine(result);
        }

        //Mode of any number to check if given number is divisible or not
        private static void FizzBuzzProblem(int totalNumbers)
        {
            for (int i = 1; i <= totalNumbers; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void CalculatePower(double num, int pow)
        {
            //Console.WriteLine(Math.Pow(num, pow));

            double result = 1;

            if (pow > 0)
            {
                for (int i = 0; i < pow; ++i)
                {
                    result *= num;
                }
            }
            else if (pow < 0)
            {
                for (int i = 0; i > pow; --i)
                {
                    result /= num;
                }
            }

            Console.WriteLine(result);
        }

        private static void PrintAnagrams(string str)
        {
            //split and sorting
            var strArr = str.Split(' ').Select(item => String.Concat(item.OrderBy(c => c)));

            //duplicate checks
            var res = strArr.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        private static void SumOfDigits(int num)
        {
            int sum = 0, ori = num;
            while (num > 0)
            {
                int m = num % 10;
                sum += m;
                num = num / 10;
            }
            Console.WriteLine($"Sum of digits of {ori} is {sum}");
        }

        private static void SecondHighestInArray()
        {
            //int[] arr = {3,2,1,5,4 };
            //int[] arr = { 30, 12, 51, 5, 4 };
            int[] arr = { 12, 12, 51, 5, 30 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(arr[arr.Length - 2]);
        }

        private static void IndexerInMatrix()
        {
            Matrix obj = new Matrix();
            for (int p = 0; p < 5; p++)
            {
                for (int q = 0; q < 5; q++)
                {
                    obj[p, q] = 2 * p + 3 * q;
                }
            }

            Console.WriteLine("Sum of all values:" + obj.Sum());

            obj[1] = 98;
            obj[2] = 63;
            obj.PrintAge();

            obj["Maharastra"] = "Mumbai";
            obj["MP"] = "Bhopal";
            obj["Goa"] = "Panaji";

            var states = new string[] { "MP", "UP", "Goa" };
            foreach (var state in states)
            {
                Console.WriteLine(obj[state]);
            }

            Console.ReadLine();
        }

        class Matrix
        {
            private int[,] max = new int[5, 5];
            public int this[int i, int j]
            {
                set
                {
                    max[i, j] = value;
                }
            }

            public int Sum()
            {
                int sum = 0;

                for (int p = 0; p < 5; p++)
                {
                    for (int q = 0; q < 5; q++)
                    {
                        Console.Write(max[p, q] + " ");
                        sum += max[p, q];
                    }
                    Console.WriteLine();
                }
                return sum;
            }

            internal void PrintAge()
            {
                Console.WriteLine(age);
            }

            private int age;
            public int this[int num]
            {
                set
                {
                    if (num > 0 && num < 100)
                        age = value;
                    else
                        Console.WriteLine("Age should be in the range of 1 to 100.");
                }
                get
                {
                    return age;
                }
            }

            private Dictionary<string, string> workedCities = new Dictionary<string, string>();


            public string this[string key]
            {
                set
                {
                    workedCities[key] = value;
                }
                get
                {
                    if (workedCities.ContainsKey(key))
                        return workedCities[key];
                    return null;
                }
            }
        }

        private static void MaximumOrderVol_HR()
        {
            var arr = new List<int> { 10, 5, 15, 18, 30 };
            var dur = new List<int> { 30, 12, 20, 35, 35 };
            var vol = new List<int> { 50, 51, 20, 25, 10 };
            //var arr = new List<int> { 1, 2, 4 };
            //var dur = new List<int> { 2, 2, 1 };
            //var vol = new List<int> { 1, 2, 3 };

            //var arr = new List<int> { 35, 10, 25 };
            //var dur = new List<int> { 30, 10, 20 };
            //var vol = new List<int> { 20, 10, 30 };
            var res = new int[vol.Count];
            var listRes = new List<int>();
            int sum = 0;
            int index = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sum = vol[i];
                index = i;
                for (int j = 0; j < arr.Count; j++)
                {

                    if (arr[i] > arr[j] + dur[j])
                    {
                        sum += vol[j];
                        //index = j;

                    }
                }
                listRes.Add(sum);
                res[i] = sum;
            }
            foreach (var item in listRes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nMax: " + listRes.Max());
            Console.ReadLine();
        }

        private static void FindMaxSumOfRowColumnsInMatrix(int input1, int input2, int[] input3)
        {
            int index = 0;
            int[,] twoDArray = new int[input1, input2];

            //print & creation two dimension array
            for (int x = 0; x < input1; x++)
            {
                for (int y = 0; y < input2; y++)
                {
                    twoDArray[x, y] = input3[index];
                    Console.Write(twoDArray[x, y] + " ");
                    index++;
                }
                Console.Write("\n");
            }

            int[] sumRows = new int[input1];
            int[] sumColums = new int[input2];
            int i, j, sum = 0, count = 0;

            // finding the row sum
            for (i = 0; i < input1; ++i)
            {
                for (j = 0; j < input2; ++j)
                {
                    // Add the element
                    sum += twoDArray[i, j];
                }
                sumRows[count] = sum;
                count++;

                // Reset the sum
                sum = 0;
            }

            count = 0;
            int sumcol = 0;
            // finding the column sum
            for (i = 0; i < input2; ++i)
            {
                for (j = 0; j < input1; ++j)
                {

                    // Add the element
                    sumcol = sumcol + twoDArray[j, i];
                }
                sumColums[count] = sumcol;
                count++;
                // Reset the sum
                sumcol = 0;
            }

            int max = sumColums.Max() + sumRows.Max();
            Console.WriteLine("Max sum in this matrix is: " + max);
        }

        private static void MultiplesOfNumber(int pow)
        {
            while (pow > 1)
            {
                for (int i = 2; i <= pow; i++)
                {
                    if (pow % i == 0)
                    {
                        Console.Write(i + "  ");
                        pow = pow / i;
                        break;
                    }
                }
            }
        }

        private static void IncrementNumber(int i)
        {
            Console.WriteLine($"initial val:{i}");
            int x = i++;
            Console.WriteLine($"initial val:{i} and i++:{x}");
            int y = ++i;
            Console.WriteLine($"initial val:{i} and ++i:{y}");
        }

    }

    interface I1
    {

    }

    abstract class AbstractClass
    {

    }

    class A : AbstractClass, I1
    {
        public int x = 10;
        public virtual void Sample()
        {
            Console.WriteLine("A");
        }

        static A()
        {
            Console.WriteLine("A - Static");
        }
    }

    class B : A
    {
        public override void Sample()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
        public override void Sample()
        {
            Console.WriteLine("C");
        }
    }

    static class Utility
    {
        public static double ToDouble(this string str)
        {
            return Double.Parse(str);
        }
    }
}
