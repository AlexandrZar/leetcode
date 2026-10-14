public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxVolume = 0;

        while (left < right) {
            var minHeight = height[left] < height[right] ? height[left] : height[right];
            var area =  minHeight * (right - left);
            maxVolume = maxVolume > area ? maxVolume : area;

            if (height[left] >= height[right]) {
                right--;
            } else {
                left++;
            }
        }

        return maxVolume;
    }
}
