using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poi.GeneraciónDeIDs
{
    public class IDGenerator
    {
        static private List<int> numbers = new List<int>();

        static public int getRandomValue(int MaxValue)
        {
            Random r = new Random();
            int newint = 0;
            newint = r.Next(MaxValue);
            while (numbers.Contains(newint))
            {
                newint = r.Next(MaxValue);
            }
            return newint;
        }

        
    }
}
