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
            var wk = new WarmKiller();
            //这样杀手功能就能大家都能看到，不是我们想要的，我们要隐藏杀手功能，
            //当给杀手任务时候才访问这个功能
            wk.Kill();
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
        public void Kill()
        {
            Console.WriteLine("I will love you for ever...");
        }
    }

}
