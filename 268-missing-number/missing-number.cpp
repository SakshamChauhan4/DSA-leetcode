class Solution {
public:
    int missingNumber(vector<int>& nums) {
        long long n = nums.size();
        long long actualSum = ((n)*(n + 1))/2;
        long long arraySum = 0;
        for(int i = 0; i<n; i++){
            arraySum = arraySum + nums[i];
        }
        return actualSum - arraySum;
    }
};