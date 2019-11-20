using System;
using DesignPattern.Design;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // var _singleton1= Singleton.Instance();
            // var _singleton2= Singleton.Instance();
            //  Console.WriteLine("单例模式:{0},{1}",_singleton1.GetHashCode(),_singleton2.GetHashCode());
            // Mobile _apple=new IphoneMobile();
            // Mobile _andriod=new AndriodMobile();
            // _apple.Display();
            // _andriod.Display();
            //  Book[] books= new Book[]{
            //     new Book("计算机"),
            //     new Book("英语"),
            //     new Book("数学"),
            //  };
            //  var _bookshelf= new BookShelf(books);
            //  foreach(Book item in _bookshelf)
            //  {
            //      item.GetName();
            //  }

            Mobiles a =new AppleAdapter(new Apples());
            a.Charge();
        }
    }
}
