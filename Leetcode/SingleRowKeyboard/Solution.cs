using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SingleRowKeyboard
{
    public class Solution
    {
        public static int CalculateTime(string keyboard, string word)
        {
            Dictionary<char, int> keyboardIndex = new Dictionary<char, int>();
            for (int i = 0; i < keyboard.Length; i++)
            {
                if (!keyboardIndex.ContainsKey(keyboard[i]))
                {
                    keyboardIndex.Add(keyboard[i], i);
                }
            }
            int result = 0 ;
            int lastCharIndex = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var charIndex = keyboardIndex[word[i]];
                var res = lastCharIndex - charIndex;
                result += Math.Abs(res);
                lastCharIndex = charIndex;
            }

            return result;

        }
    }
}
