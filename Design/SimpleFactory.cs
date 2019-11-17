using System;
using System.Collections.Generic;
using System.Reflection;
namespace DesignPattern.Design
{
    public class SimpleFactory
    {
        private Dictionary<string, Type> _dic ;

        public  Animal  CreateInstance(string className)
        {
            if(className.Equals("tiger"))
               return new Tiger();
            if(className.Equals("dog"))
              return new Dog();
            return  null;          
        } 
    }
     public  class Animal{


     }

     public  class Dog:Animal 
     {


     }

     public class Tiger:Animal
     {

     }

     // 工厂模式
     public interface IAnimalFactory
     {
         Animal CreateAnimal();
     }
    public class DogFactory : IAnimalFactory
    {
        
       public  Animal CreateAnimal()
        {

            return new Dog();
        }
    }

    public class TigerFactory:IAnimalFactory
    {
       public  Animal CreateAnimal()
        {

            return new Tiger();
        }

    }

}