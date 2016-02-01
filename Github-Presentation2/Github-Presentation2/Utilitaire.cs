using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Presentation2
{
    class Utilitaire
    {
        static Random RandomGenerator = new Random();

        public static int GenerateInt(int min, int max)
        {
            return RandomGenerator.Next(min, max);
        }
    }
}
