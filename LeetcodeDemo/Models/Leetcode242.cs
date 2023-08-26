using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeDemo.Models
{
    public class Leetcode242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // 统计字符串 s 中各个字符的出现次数
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // 减去字符串 t 中各个字符的出现次数
            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c) || charCount[c] <= 0)
                {
                    return false; // 如果字符在 t 中不存在，或者出现次数已经为0，则说明不是 anagram
                }
                charCount[c]--;
            }

            return true; // 如果所有字符的出现次数都相同，则是 anagram
        }
    }
}
