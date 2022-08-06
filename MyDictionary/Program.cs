using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string>cars=new MyDictionary<int,string>();
            cars.Add(1, "Bmw");
            cars.Add(2, "Mercedes");
            cars.Add(3, "Volvo");
            cars.Add(4, "Citroen");

            Console.WriteLine(cars.Count);
            Console.WriteLine();
            cars.ShowList();
            








        }
    }
}
