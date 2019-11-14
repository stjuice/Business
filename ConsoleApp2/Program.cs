using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<Number>();
            

            var set = new HashSet<Number>(new NumbersComperer());
            set.Add(new Number(5, "XXXX"));
            set.Add(new Number(2, "BBBB"));
            set.Add(new Number(4, "CCCC"));
            set.Add(new Number(1, "AAAA"));
            set.Add(new Number(6, "FFFF"));
            set.Add(new Number(2, "AAAA"));

            foreach (var item in set)
            {
                Console.WriteLine($"hash: {item.GetHashCode()}\tnum: {item.num}");

                foreach(var text in item.text)
                {
                    Console.WriteLine($"\ttext: {text}\n");
                }
                    
            }

            Console.WriteLine("\n\n****************--------------******************\n\n");

            SortedSet<Number> sortedNumbers = new SortedSet<Number>(set);
            foreach (var item in sortedNumbers)
            {
                Console.WriteLine($"hash: {item.GetHashCode()}\tnum: {item.num}");

                foreach (var text in item.text)
                {
                    Console.WriteLine($"\ttext: {text}\n");
                }
            }

        }
        class GradeScool
        {
            public int Grade { get; set; }
            public List<string> Name { get; set; }

            public GradeScool(int grade, string name)
            {
                this.Grade = grade;
                this.Name = new List<string>();
                this.Name.Add(name);
            }

            public override int GetHashCode()
            {
                return Grade;
            }

            public IEnumerable<string> GetElementByHash(int k)
            {
                return null;

            }
        }

        class GradeSchoolComperer : IEqualityComparer<GradeScool>
        {
            public bool Equals([AllowNull] GradeScool x, [AllowNull] GradeScool y)
            {
                if (x.GetHashCode() == y.GetHashCode())
                {
                    x.Name.Add(y.Name[0]);
                    x.Name.Sort();
                }
                return x.GetHashCode() == y.GetHashCode();
            }

            public int GetHashCode([DisallowNull] GradeScool obj)
            {
                return obj.Grade.GetHashCode();
            }
        }

        class Number : IComparable<Number>
        {
            public int num { get; set; }
            public List<string> text { get; set; }
            public Number(int num, string text)
            {
                this.num = num;
                this.text = new List<string>();
                this.text.Add(text);
            }

            public override int GetHashCode()
            {

                return num;
            }

            public int CompareTo([AllowNull] Number other)
            {
                return num.CompareTo(other.num);
            }
        }
        class NumbersComperer : IEqualityComparer<Number>
        {
            public bool Equals([AllowNull] Number x, [AllowNull] Number y)
            {
                if(x.GetHashCode() == y.GetHashCode())
                {
                    x.text.Add(y.text[0]);
                    x.text.Sort();
                }

                return x.GetHashCode() == y.GetHashCode();
            }

            public int GetHashCode([DisallowNull] Number obj)
            {

                return obj.num.GetHashCode();
                //return new DateTime().Millisecond;
            }
        }
    }
}
