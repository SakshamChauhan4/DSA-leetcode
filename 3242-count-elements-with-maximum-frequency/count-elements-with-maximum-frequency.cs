public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int maxFreq = 0;

        foreach (int num in nums) {
            if (map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;

            if (map[num] > maxFreq)
                maxFreq = map[num];
        }

        int total = 0;
        foreach (var pair in map) {
            if (pair.Value == maxFreq)
                total += pair.Value;
        }

        return total;
    }
}