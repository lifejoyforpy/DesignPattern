using System;
using DesignPattern.Design;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var _singleton1= Singleton.Instance();
            var _singleton2= Singleton.Instance();
             Console.WriteLine("单例模式:{0},{1}",_singleton1.GetHashCode(),_singleton2.GetHashCode());
        }
    }
}
