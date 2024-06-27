using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    internal class Collections
    {
        internal void Collection()
        {
            // Chararrays
            var my_array = "Feierabend!";
            var my_letter = my_array[0];

            // Collections-Basics
            // Array
            string[] namen = new string[5];
            string[] alternative_namen = ["Tobi", "Popstar", "Lehrer"]; // max 3 items
            string[] alternative_namen1 = { "Ab", "Bc", "Cd" };
            namen[0] = "Tobi";
            namen[1] = "Melanie";
            namen[2] = "Torben";
            namen[99999999999999998] = "Buxtehude!";
            Console.WriteLine(namen[0][0]);


            // Array ist eine Liste an Werten
            // Eine kontinuirliche Speicherregion, für mehrere Daten eines gewissen Types
            int[] nums = new int[5];
        }
    }
}
