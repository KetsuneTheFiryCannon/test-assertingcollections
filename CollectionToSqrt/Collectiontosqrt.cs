using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CollectionToSqrt
{
    public class Collectiontosqrt
    {
        public static List <string> arraylist = new List<string>()
        {
            "a", "b", "c", "d", "e", "f", "g"
            
        };
        
        public static List<string> fwee()
        {
            List<string> array = new List<string>();
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Add("d");
            array.Add("e");
            array.Add("f");
            array.Add("g");
            return array;
        }

        public static double MySqrt(double a, double d)
        {
            
            return a/100 * d;
          
        }

        public static double TestCount()
        {
            int a = 15;
            int b = 7;
            double answer = 15 / 7;
            return answer;
        }
    }
}