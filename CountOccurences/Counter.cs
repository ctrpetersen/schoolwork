using System;

namespace CountOccurences
{
    public static class Counter
    {
        public static int CountChars(char CharToCount, string StringToCount)
        {
            int occurences = 0;
            StringToCount = StringToCount.ToLower();
            CharToCount = char.ToLower(CharToCount);

            for (int i = 0; i < StringToCount.Length; i++)
            {
                if (CharToCount == StringToCount[i])
                    occurences++;
            }
            return occurences;
        }
    }
}
