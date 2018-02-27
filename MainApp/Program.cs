using Data.Model.Mercedes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MercedesFactory mercedesFactory = new MercedesFactory();
            FactoryController controller = new FactoryController(mercedesFactory);
            controller.LastikTak();

            Console.ReadKey();
        }
    }
}
