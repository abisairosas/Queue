using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            procedimiento INICIAR = new procedimiento();
            INICIAR.proceso();

            Console.ReadKey();
        }
    }
}
