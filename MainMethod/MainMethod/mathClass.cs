using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class mathClass
    {
        //I had to get rid of static, I could not access the methods with it active. 
        //all methods are of data type int, regardless of incoming argument, due to returning data type is int, in this project.
        public int methodOne(int answer1) //method with int parameter
        {
            return answer1 * 10; //returning answer1
        }
        public int methodOne(decimal answer2) //method with decimal paramter
        {
            int answer3 = Convert.ToInt32(answer2); //casting decimal to int 
            return answer3 / 10; //returning answer3
        }

        public int methodOne(string answer3) //method with string parameter
        {
            int answer4 = Convert.ToInt32(answer3); //casting string to int
            return answer4 + 10; //returning answer4
        }
    }
}
