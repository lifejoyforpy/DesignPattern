namespace DesignPattern.Design
{
    public class TemplateMethod
    {
        
    }

    public abstract class  Mobile
    {
        public abstract void start();
        public abstract  void show();
       public void  Display()
        {
            start();
            show();
        }

    }
    public class IphoneMobile : Mobile
    {
        public override void show()
        {
            System.Console.WriteLine( "apple show");
        }

        public override void start()
        {
             System.Console.WriteLine( "apple start");
        }
    }

    public class AndriodMobile : Mobile
    {
        public override void show()
        {
            System.Console.WriteLine( "andriod show");
        }

        public override void start()
        {
             System.Console.WriteLine( "andriod start");
        }
    }
}