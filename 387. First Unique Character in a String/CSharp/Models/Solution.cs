using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    
public class Solution
{
    public int FirstUniqChar(string s) {

    // creates dictionary of the characters in the string
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    // counts occurrences of each character
    foreach (char c in s) {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }

    // finds index of the first non-repeating character
    for (int i = 0; i < s.Length; i++) {
        if (charCount[s[i]] == 1)
            return i;
    }

    // if no non-repeating character found
    return -1;
}
}


}