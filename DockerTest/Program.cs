using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DockerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer(CallBackMethod, null, 0, 2000);

            Console.Read();
        }

        private static void CallBackMethod(object state)
        {
            Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}
