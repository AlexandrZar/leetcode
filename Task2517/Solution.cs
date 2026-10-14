public class Solution {
    public int MaximumTastiness(int[] price, int k) {
        Array.Sort(price);
        int left = 0, right = price[^1] - price[0];

        while (left < right){
            var mid = left + (right - left + 1) / 2;
            if(CanFit(price, mid, k)){
                left = mid;
            } else {
                right = mid - 1;
            }
        }

        return left;
    }

    private bool CanFit(int[] price, int minGap, int k) {
        int prev = price[0], count = 1;

        for(int i = 1; i < price.Length; i++) {
            if(price[i] - prev >= minGap) {
                count++;
                prev = price[i];
                if(count == k) return true;
            }
        }

        return count >= k;
    }
}
