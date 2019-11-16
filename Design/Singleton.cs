namespace DesignPattern.Design
{

    public class Singleton
    {

        private static readonly object  _lock= new object();
        
        private static Singleton _instance ;
        private Singleton()
        {
           
        }
        /// <summary>
        /// 锁机制
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            //如果为空
            if(_instance==null)
            {
                //锁住
                lock(_lock)
                {
                    //判定是够为空
                    if(_instance==null)
                    {
                        _instance=new Singleton();

                    }

                }
            }
            return _instance;

        }
    }
}