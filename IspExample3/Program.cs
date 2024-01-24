using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            //当给这个杀手任务，也就是杀手类时候，才能访问这个功能，这就是显式接口实现
            IKiller killer = new WarmKiller();
            killer.Kill();
            //这里要进行类型转换才能访问Love方法
            //var wk = killer as IGentleman; //方法1
            var wk = (IGentleman)killer;  //方法2
            wk.Love();
        } 
    }
    interface IGentleman
    {
        void Love();
    }
    interface IKiller
    {
        void Kill();
    }
    class WarmKiller:IGentleman,IKiller
    {
        public void Love()
        {
            Console.WriteLine("Let me kill the enemy...");
        }
         void IKiller.Kill()
        {
            Console.WriteLine("I will love you for ever...");
        }
    }

}
