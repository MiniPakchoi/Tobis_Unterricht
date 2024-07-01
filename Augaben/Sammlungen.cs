using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal class Sammlungen
    {
        /// <summary>
        /// Eine Funktion welche eine Smmlung und ein gesuchtes Element übergeben bekommt,
        /// und den entsprechenden Index des Elements im Array zurückgibt.
        /// </summary>
        internal static int FindIndex(List<int> numbers, int query)
        {
            //iterieren (durchzählen) durch numbers
            //wenn: numbers[i] == query
            //return i;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == query)
                {
                    return i;
                }
            }
            //wenn query nicht gefunden, dann return -1
            return -1;
        }

        internal static int TempList(List<int> temperaturen, int schwellenwert)
        {

            for (int i = 0; i < temperaturen.Count; i++)
            {
                if (temperaturen[i] < schwellenwert)
                {
                    return i.ToArray(ergebnisliste);
                    
                }
            }

            return -1;
        }


    }
}
