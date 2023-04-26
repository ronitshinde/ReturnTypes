using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndReturnType
{
    public class ReturnTypes
    {
        //Void,Int,String,Bool,Double
        //Void does not have return type.
        public void MethodTypes()
        {
            Console.WriteLine("Its a void method");
        }
        public void MethodTypes(int one)
        {
            Console.WriteLine(one);
        }
        public int IntMethodType()
        {
            return 4 + 3;
        }
        public int IntMethodType(int one, int two)
        {
            int three = one + two;
            return three;
            // return 4 + 3;
        }
        public double DoubleMethodType(double four, double five)
        {
            double six = four - five;
            return six;
        }
        public string StringMethodType()
        {
            return "BridgeLabz";
        }
        public bool BoolMethodType(int ten)
        {
            if (ten == 10)
                return true;
            else
                return false;
        }
    }
}
