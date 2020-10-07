using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            string output = "";
            foreach(double num in numbers)
            { output += Math.Round(num, 2) + "";
            }
            Console.Write(output.Substring(0, output.Length - 1));
    }

}
}
