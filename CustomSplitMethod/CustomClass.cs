using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSplitMethod
{
    internal static class CustomClass
    {
        public static string[] CustomSplit(this string text, char letter)
        {
            int count = 0;
            string[] NewText = new string[0];
            char[] letters = text.ToCharArray();
            Array.Resize(ref letters, letters.Length + 1);
            for (int i = 0; i <letters.Length; i++)
            {
                if (letters[i] == letter || letters[i]==default(char))
                {
                    Array.Resize(ref NewText, NewText.Length + 1);
                    NewText[NewText.Length - 1] = new string(letters).Substring(0, count);

                    letters = new string(letters).Substring(count + 1).ToCharArray();
                    count = 0;
                    i = -1;

                }
                // "Elcan Bakidan Gelir"
                else
                {
                    count++;


                }
            }
            return NewText;

        }

        public static string[] CustomSplit(this string text)
        {
            int count = 0;
            string[] NewText = new string[0];
            char[] letters = text.ToCharArray();
            Array.Resize(ref letters, letters.Length + 1);
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] ==' ' || letters[i] == default(char))
                {
                    Array.Resize(ref NewText, NewText.Length + 1);
                    NewText[NewText.Length - 1] = new string(letters).Substring(0, count);

                    letters = new string(letters).Substring(count + 1).ToCharArray();
                    count = 0;
                    i = -1;

                }
                // "Elcan Bakidan Gelir"
                else
                {
                    count++;


                }
            }
            return NewText;

        }


    }
}

