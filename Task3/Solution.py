class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if (len(s) <= 1): 
            return len(s)

        maxLength = left = 0
        last_seen: dict[str, int] = {}

        for right, ch in enumerate(s):
            left = last_seen[ch] + 1 if last_seen.get(ch, -1) >= left else left
            last_seen[ch] = right
            maxLength = max(maxLength, right - left + 1)

        return maxLength
