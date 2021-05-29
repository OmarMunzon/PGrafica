using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Window ventana = new Window(1000, 500, "Silla"))
            {
                ventana.Run();
            };
        }
    }
}
