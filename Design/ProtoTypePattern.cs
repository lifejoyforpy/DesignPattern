using System;
using System.Collections.Generic;

namespace DesignPattern.Design
{
    public class ProtoTypePattern
    {
        
    }

    public class Person:ICloneable
    {        
           public object Clone(){;
             return  this.MemberwiseClone();
        }
    }

   



}