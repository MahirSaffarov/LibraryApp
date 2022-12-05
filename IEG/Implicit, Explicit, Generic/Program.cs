using Implicit__Explicit__Generic.Models;
using System;

namespace Implicit__Explicit__Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manat manat = new Manat(100);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);

            //Dollar2 dollar2 = new Dollar2(100);
            //Manat2 manat2 = (Manat2)dollar2;
            //Console.WriteLine(manat2.Azn2);

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToString("MMMM dd"));

            //StringList list = new StringList();
            //list.Add("Salam");
            //list.Add("Sagol");
            //list.GetAll();

            //IntList list2 = new IntList();
            //list2.Add2(21);
            //list2.Add2(23);
            //list.GetAll();

            //BookList list3 = new BookList();
            //list3.Add3(new Book { Name = "C#" });
            //list3.GetAll();

            //DataList<int> list4 = new DataList<int>();
            //list4.Add3(12);
            //list4.Add3(23);
            //list4.GetAll();

            //DataList<string> list5 = new DataList<string>();
            //list5.Add3("Huhu");
            //list5.Add3("asd");
            //list5.GetAll();

            //DataList<bool> list6 = new DataList<bool>();
            //list6.Add3(true);
            //list6.Add3(false);
            //list6.GetAll();

            //DataList2<int> list7 = new DataList2<int>();
            //list7.Add4(12);
            //list7.Add4(20);

            //var result = list7.GetAll();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Repository<int> number1 = new Repository<int>();

            //Repository<double> number2 = new Repository<double>();

            //Repository<string> name = new Repository<string>();

            //Repository<Student> student = new Repository<Student>();

            //Repository<Employee> emp1 = new Repository<Employee>();

            //Repository<Student, Common> stu = new Repository<Student, Common>();    

            GetProductByDate();
        }
        public static void GetProductByDate()
        {
            DateTime end = DateTime.Now.AddMinutes(-10);

            DateTime start = DateTime.Now;
            
            if (start > end)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        #region Implicit,Explicit
        //public class Dollar
        //{
        //    public double Usd { get; set; }
        //    public Dollar(double usd)
        //    {
        //        Usd = usd;
        //    }
        //}
        //public class Manat
        //{
        //    public double Azn { get; set; }
        //    public Manat(double azn)
        //    {
        //        Azn = azn;
        //    }
        //    public static implicit operator Dollar(Manat manat)
        //    {
        //        return new Dollar(manat.Azn / 1.7);
        //    }
        //}

        //public class Manat2
        //{
        //    public double Azn2 { get; set; }
        //    public Manat2(double azn2)
        //    {
        //        Azn2 = azn2;
        //    }
        //}
        //public class Dollar2
        //{
        //    public double Usd2 { get; set; }
        //    public Dollar2(double usd2)
        //    {
        //        Usd2 = usd2;
        //    }
        //    public static explicit operator Manat2(Dollar2 dollar2)
        //    {
        //        return new Manat2(dollar2.Usd2 * 1.7);
        //    }
        //}
        #endregion

        #region Generics
        public class StringList
        {
            private string[] _arr;
            public StringList()
            {
                _arr = new string[0];
            }

            public void Add(string str)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = str;
            }

            public void GetAll()
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }


        public class IntList
        {
            private int[] _arr;
            public IntList()
            {
                _arr = new int[0];
            }
            public void Add2(int str)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = str;
            }
            public void GetAll()
            {
                foreach (int item in _arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public class BookList
        {
            private Book[] _arr;
            public BookList()
            {
                _arr = new Book[0];
            }

            public void Add3(Book book)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = book;
            }
            public void GetAll()
            {
                foreach (Book item in _arr)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
        public class DataList<T>
        {
            private T[] _datas;
            public DataList()
            {
                _datas = new T[0];
            }
            public void Add3(T data)
            {
                Array.Resize(ref _datas, _datas.Length + 1);
                _datas[_datas.Length - 1] = data;
            }
            public void GetAll()
            {
                foreach(T item in _datas)
                {
                    Console.WriteLine(item);
                }

            }
        }
        public class DataList2<T>
        {
            private T[] _data;
            public DataList2()
            {
                _data = new T[0];
            }
            public void Add4(T datas)
            {
                Array.Resize(ref _data, _data.Length + 1);
                _data[_data.Length - 1] = datas;
            }
            public T[] GetAll()
            {
                return _data;
            }
        }
        #endregion
    }
}
