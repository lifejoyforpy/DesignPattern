using System;
namespace DesignPattern.Design
{
    public class ProtoTypePattern
    {
        
    }
    public class Person:ICloneable
    {
        
        public object Clone(){;
              Person person=null;
              person.Clone();
              return person;
        }
    }

}