﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal class Sammlungen
    {
        //FindIndex Optimized
        internal static int FindIndexOpimized(List<int>numbers, int query)
        {
            var low = 0;
            var high = numbers.Count -1; //Der höchste Index
            int mid = (high + low) / 2;
            while (high != low)
            {
                mid = (high + low) / 2;
                if (numbers[mid] == query) return mid;
                else if (numbers[mid] < query)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1; 
                }
            }
            return -1;    
        }
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
        internal static int FindIndexAlt(List<int> numbers, int query)
        {
            // iterieren (durchzählen) durch numbers
            // wenn: numbers[i] == query
            //   return i;
            for (int i = numbers.Count - 1; i > 0; i--)
            {
                if (numbers[i] == query) return i;
            }
            // wenn query nicht gefunden, return -1
            return -1;
        }
        internal static List<int> GenerateNumbers(int amount)
        {
            List<int> numbers = new();
            for (int i = 0; i < amount; i++)
                numbers.Add(i);
            return numbers;
        }
    }
   
}
