using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IspExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //需要安装程序包DependencyInjection;
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped(typeof(IVehicle), typeof(Car));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            //============华丽的分割线==============
            var driver = sp.GetService<Driver>();
            driver.Drive();
        }
    }

    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }
    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
    interface IWeapon
    {
        void Fire();
    }
    interface ITank : IWeapon, IVehicle
    {

    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }
        public void Run()
        {
            Console.WriteLine("ka ka ka ...");
        }
    }
    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }
        public void Run()
        {
            Console.WriteLine("ka!! ka!! ka!! ...");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }
        public void Run()
        {
            Console.WriteLine("ka!!! ka!!! ka!!! ...");
        }
    }
}
