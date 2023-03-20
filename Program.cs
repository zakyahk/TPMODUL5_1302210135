using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL5_1302210135
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine("Halo user " + input);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("praktikan");
        }
    }
}
