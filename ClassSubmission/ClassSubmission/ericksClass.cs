using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class ericksClass
    {
        public void methodOne(int param1)
        {
            int answer = param1 / 2;
            Console.WriteLine($"methodOne says: {param1} / 2 = {answer}");
        }
        public void outMethod(out string a)
        {
            a = "Hello, World!";
        }
        public void methodOne(int param1, int param2)
        {
            Console.WriteLine($"This is methodOne again, overloaded with two parameters, {param1} and {param2}");
        }


    }
    public static class wellAlrightyThen    //declaring static class
    {

    }
}
