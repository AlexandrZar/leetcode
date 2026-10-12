function lengthOfLongestSubstring(s: string): number {
    let left = 0, maxLength = 0;
    const lastSeen = new Int32Array(128);

    for(let right = 0; right < s.length; right ++) {
        const ch = s.charCodeAt(right);

        left = lastSeen[ch] > left ? lastSeen[ch] : left;
        lastSeen[ch] = right + 1;

        const length = right - left + 1;
        maxLength = length > maxLength ? length : maxLength;
    }

    return maxLength;
};
