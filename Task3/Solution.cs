public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 1) return s.Length;

        int maxLength = 0, left = 0;
        Span<int> charBuffer = stackalloc int[128];

        for(var right = 0; right < s.Length; right++) {
            int ch = s[right];
            
            left = charBuffer[ch] > left ? charBuffer[ch] : left;

            var length = right - left + 1;
            maxLength = length > maxLength 
                ? length 
                : maxLength;

            charBuffer[ch] = right + 1;
        }

        return maxLength;
    }
}
