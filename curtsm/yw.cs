using System;

namespace curtsm
{
    public class yw: Iyw
    {
        public void Home(string a, string b)
        {
            Console.WriteLine($"home:{a},,{b}");
        }

        public void two()
        {
            Console.WriteLine("第二个方法");
        }
    }
}