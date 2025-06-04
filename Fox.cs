using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education
{
    public class Fox
    {
        public string Run(int distance)
        {
            switch (distance)
                {
                    case <= 0:
                        return "fox do not running";
                        break;
                    case <= 10:
                        return "fox running " + distance + " km";
                        break;
                    default:
                        return "fox do not running";
                        break;

                }
            return "";
        }
        public void Eat()
        {
            Console.WriteLine("fox eating");
        }
        public void Output(string red)
        {
            Console.WriteLine(red);
        }

    }
}
