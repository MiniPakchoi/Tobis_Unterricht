using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal class StringAufgaben
    {
        /// <summary>
        /// Drucke den gegeben Text rückwärts, wobei jedes Zeichen mit einem Leerzeichen getrennt sein soll.
        /// Input: "Lagerregal"
        /// Output: "l a g e r r e g a L"
        /// Input: "Hamster"
        /// Output: "r e t s m a H"
        /// </summary>
        /// <param name="text"></param>
        internal static void Printbackwards(string zeichenkette)
        {
            int j = zeichenkette.Length - 1;
            while (j >= 0)
            {
                Console.Write(zeichenkette[j]);
                Console.Write(' ');
                j--;
            }

        }
        /// <summary>
        /// Eine Funktion, welche die Anzahl von Worten in einer beliebigen Zeichenkette zählt.
        /// Ein Wort besteht aus mehreren zusammenhängenden Buchstaben und werden mit Leerzeichen voneinander getrennt.
        /// Input: "Hier könnte Ihre Werbung stehen!"
        /// Output: 5
        /// Input: "lorem ipsum dolor est"
        /// Ouput: 4
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static int CountWords(string satz)
        {
            int wordCount = 1;
            for (int i = 0; i < satz.Length; i++)
            {
                if (satz[i] == ' ')
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
        /// <summary>
        /// Eine Funktion, welche die Anzahl an Buchstaben des letzten Wortes des Textes zurückgibt.
        /// <param name="text">Eine beliebig lange Sequenz an Text</param>
        /// <list type="bullet">
        /// <item>
        /// Input: "Mein Hamster hat meine Hausis gefressen"
        /// Output: 9
        /// </item>
        /// <item>
        /// Input: "Döner mit Scharf"
        /// Output: 6
        /// </item>
        /// </list>
        /// <returns>Die Anzahl an Buchstaben im letzten Wort als Int</returns>
        /// </summary>
        /// 
        internal static int CountCharsOfLastWordInText(string lastWords)
        {
            string lastWord = "Das wird Legendär!";
            int cC = 0;
            for (int i = lastWord.Length - 1; i >= 0; i--)
            {
                if (lastWord[i] == ' ')
                {
                    break;
                }
                cC++;
            }
            return cC;
        }
        /// <summary>
        /// Eine Funktion, welche einen beliebigen Text als Input bekommt und in der Konsole die Anzahl an Vokalen und Konsonanten anzeigt.
        /// Input: "Buxtehude"
        /// Output: Anzahl Vokale: 4
        ///         Anzahl Konsonanten: 5
        /// Input: "lorem ipsum dolor est"
        /// Output: Anzahl Vokale: 7
        ///         Anzahl Konsonanten: 11
        /// 
        /// HINT: Sind Leerzeichen Vokale oder Konsonanten?
        /// </summary>
        /// <param name="text"></param>
        internal static void PrintConsonantAndVowels(string text)
        {
            int vowelCount = 0;
            int consonantCount = 0;
            string textLower = text.ToLower();
            for (int i = 0; i < textLower.Length; i++)
            {
                char x = textLower[i];
                switch (x)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        consonantCount++;
                        break;
                }
                Console.WriteLine($"Anzahl der Vokale: {vowelCount}");
                Console.WriteLine($"Anzahl der Konsonanten: {consonantCount}");

            }
        }
    }
}
