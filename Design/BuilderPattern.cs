using System;
using System.Collections.Generic;

namespace DesignPattern.Design
{
    public class BuilderPattern
    {
        
    }
  
  // 产品
    public class Computer
    {
        public string _brand {get;set;}

         /// <summary>
        /// 电脑组件列表
        /// </summary>
        private List<string> assemblyParts = new List<string>();
        public Computer(string brand)
        {

            _brand=brand;
        }
        public void AddAssembly(string partName)
        {
            assemblyParts.Add(partName);

        }
        public void ShowSteps()
        {
            Console.WriteLine("开始组装『{0}』电脑:", _brand);
            foreach (var part in assemblyParts)
            {
                Console.WriteLine(string.Format("组装『{0}』;", part));
            }

            Console.WriteLine("组装『{0}』电脑完毕！", _brand);
        }

    }

    public abstract class Builder{

        /// <summary>
        /// 显示器
        /// </summary>
        public abstract void BuildScreen();
        /// <summary>
        /// 主机
        /// </summary>
        public abstract void BuildMainMachine();
        /// <summary>
        /// 键盘鼠标
        /// </summary>
        public abstract void BuildInput();
        /// <summary>
        /// 组装
        /// </summary>
        /// <returns></returns>
        public abstract Computer BuildeComputer();
    }
    
    public   class BuilderManager{

        public Computer Build(Builder builder){
           return  builder.BuildeComputer();
        }
    }

    public class MacBuilder : Builder
    {
        public Computer _mac=new Computer("苹果电脑");
        public override Computer BuildeComputer()
        {
            BuildInput();
            BuildMainMachine();
            BuildScreen();   
            return _mac;         
        }

        public override void BuildInput()
        {
            _mac.AddAssembly("键盘鼠标");
        }

        public override void BuildMainMachine()
        {
             _mac.AddAssembly("主机");
        }

        public override void BuildScreen()
        {
            _mac.AddAssembly("显示器");
        }

        
    }
}