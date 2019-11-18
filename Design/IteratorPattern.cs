using System.Collections;
using System.Linq;

namespace DesignPattern.Design
{
    public class IteratorPattern
    {
        
    }

    public class Book{
        private string _name;

        public Book(string name)
        {
            _name=name;
        }
        public void GetName(){

            System.Console.WriteLine(_name);
        }
    }

    public class BookShelf : IEnumerable
    {
        private Book[] _books;
        public int _position=0;

        public BookShelf(Book[] books){
            _books=books;
        }
       
        public Book GetElementAt(int index)
        {
            return _books[index]; 
        }
        public int GetLenght()
        {
            return _books.Length;
        }

        // public IEnumerator GetEnumerator()
        // {
        //    return new BookShelfIterator(this);
        // }
        public IEnumerator GetEnumerator()
        {

            for(int i=0;i<_books.Length;i++)
            {
                yield return _books[i];
            }
        }
    }
    // public class BookShelfIterator : IEnumerator
    // {
    //     private  BookShelf _bs;
    //     private int _position=-1;
    //     public BookShelfIterator( BookShelf bs)
    //     {   
    //         _bs=bs;
    //     }

    //    public  object Current { get{ return _bs.GetElementAt(_position);}}     

    //     public  bool MoveNext()
    //     {
    //         _position++;
    //         if(_position<_bs.GetLenght())
    //            return true;
    //          return false;           
    //     }

    //     public void Reset()
    //     {
    //         _position=-1;
    //     }
    // }

}