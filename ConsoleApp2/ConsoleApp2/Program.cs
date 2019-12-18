using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            //int[] x = { 21, 2, 34, 95, 14 };
            //Array.Sort(x);

            //string[] word = { "Serxan","Memmed","Rafig","Afig"};
            //Array.Sort(word);
            //foreach (string item in word)
            //{
            //    Console.WriteLine(item);
            //}

            //Person[] people = new Person[] { new Person { Name="Memmed",Age=29},
            //    new Person { Name="Rafiq",Age=22},new Person{ Name="Serxan",Age=25} };

            //Array.Sort(people);

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //Test(5);
            //Test("Rafig");
            //Test('@');

            //IEatable p = new Woman();
            //p.Eat();

            //Person person = new Person();
            //Test(person);

            #endregion

            #region ArrayList
            //ArrayList arrList = new ArrayList();
            //arrList.Add("Rafig");
            //arrList.Add(122345);
            //arrList.Add(new Person());
            //arrList.Add(new int[] { 1, 23, 48 });

            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            //List<int> listInt = new List<int>();
            //listInt.Add(6);
            //listInt.Add(60);
            //listInt.Add(600);
            ////listInt.Clear();

            //if (listInt.Contains(6000))
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //{
            //    Console.WriteLine("Yox");
            //}

            //foreach (int item in listInt)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Queue
            //Queue<string> q = new Queue<string>();
            //q.Enqueue("Shems");
            //q.Enqueue("Sadiq");
            //q.Enqueue("Ferid");

            ////Console.WriteLine(q.Peek());
            //q.Dequeue();
            //Console.WriteLine(q.Peek());

            //Console.WriteLine("Novbedekiler");
            //foreach (string item in q)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack
            //Stack<string> s = new Stack<string>();
            //s.Push("Memmed");
            //s.Push("Rafig");
            //s.Push("Serxan");
            //s.Push("Ismayil");

            ////Console.WriteLine(s.Peek());
            //string x=s.Pop();

            //Console.WriteLine("Novbedekiler");
            //foreach (string item in s)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            Dictionary<string, string> phoneNumber = new Dictionary<string, string>();

            phoneNumber.Add("Memmed", "0558745054");
            phoneNumber.Add("Rafig", "0505451717");
            phoneNumber.Add("Kamran", "0512373434");
            phoneNumber["Sadiq"] = "0708990817";

            foreach (var item in phoneNumber)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
        }

        //public static void Test<T>(T x) where T:IRunable
        //{
        //    x.Run();
        //}
    }

    class Person { }

    #region Interface
    //class Person : IRunable,IEatable,IComparable
    //{
    //    public string Name { get; set; }

    //    public int Age { get; set; }
    //    public int MyProperty { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        Person person = (Person)obj;
    //        return Name.CompareTo(person.Name);
    //    }

    //    public void Eat()
    //    {
    //        Console.WriteLine("Eat as Human");
    //    }

    //    public void Run()
    //    {
    //        Console.WriteLine("Run as Human");
    //    }
    //}

    //class Woman:Person { }

    //interface IRunable
    //{
    //    void Run();
    //}

    //interface IEatable
    //{
    //    int MyProperty { get; set; }
    //    void Eat();
    //}
    #endregion
}
