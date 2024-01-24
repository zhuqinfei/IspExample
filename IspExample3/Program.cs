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
            //wk.Kill(); 这个时候就访问不了这个杀手功能了
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
