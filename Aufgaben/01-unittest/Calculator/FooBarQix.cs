using System;

namespace Calculator
{
    public class FooBarQix
    {
        public string determiner(int a)
        {
            string c = "";
            if (a % 3 == 0)
                c += "Foo";

            if (a % 5 == 0)
                c += "Bar";

            if (a % 7 == 0)
                c += "Qix";


            if (!(a % 7 == 0 || a % 5 == 0 || a % 3 == 0))
            {
                string b = a + "";
                return b;
            }

            return c;
        }

    }
}
