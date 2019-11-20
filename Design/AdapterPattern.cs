namespace DesignPattern.Design
{
    public class AdapterPattern
    {
        
    }

    public abstract class Mobiles {
        public abstract void Charge();
    }

    public class AppleAdapter : Mobiles
    {
        private Apples _apple;
        public AppleAdapter(Apples apple){
            _apple=apple;
        }
        public override void Charge()
        {
            _apple.show();
        }

    }

    public class AndriodAdapter : Mobiles
    {
        private Andriods _andriod;
        public AndriodAdapter(Andriods andriod){
            _andriod=andriod;
        }
        public override void Charge()
        {
            _andriod.show();
        }
    }

    public class Andriods{
        public void show(){

             System.Console.WriteLine( "andriod charge");
        }
    }

    public class Apples{
         public void show(){

             System.Console.WriteLine( "apple charge");
        }
    }
}