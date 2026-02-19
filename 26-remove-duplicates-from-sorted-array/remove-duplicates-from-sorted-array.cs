public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums) {
            set.Add(num);
        }

        int index = 0;
        foreach (int number in set) {
            nums[index] = number;
            index++;
        }

        return set.Count;
    }
}