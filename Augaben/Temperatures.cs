using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal class Temperatures
    {
        internal static List<int> TempList(List<int> temperatures, int schwellenwert)
        {
            List<int> ergebnisListe = new List<int>();
            for (int i = 0; i < temperatures.Count; i++)
            {
                if (temperatures[i] > schwellenwert)
                {
                    ergebnisListe.Add(i);
                }
            }
            return ergebnisListe;
        }
        internal static double Average(List<int> temperatures)
        {
            // temp = temperatures[i]
            double sum = 0;
            foreach (int temp in temperatures)
            {
                sum = sum + temp;
            }
            // Der foreach-loop macht das gleiche wie der folgende for-loop
            // for (int i = 0; i < temperatures.Count; i++)
            // {
            //      sum = sum + temperatures[i];
            // }
            double avg = sum / temperatures.Count;
            return avg;
        }
    }
}
