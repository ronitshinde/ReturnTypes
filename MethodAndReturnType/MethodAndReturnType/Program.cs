using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndReturnType
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReturnTypes types = new ReturnTypes();
            types.MethodTypes(15);
            Console.WriteLine(types.IntMethodType(4,5));
            Console.WriteLine(types.DoubleMethodType(10,5));
            Console.WriteLine(types.StringMethodType());
            Console.WriteLine(types.BoolMethodType(5));
            Console.ReadLine();
        }
    }
}
