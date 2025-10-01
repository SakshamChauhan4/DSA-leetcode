class Solution {
public:
    bool check(vector<int>& nums) {
        int n = nums.size();
        int t = 0;
        for(int i = 0; i < n; i++){
            if(nums[i] > nums[(i+1)%n]) t++;
            if(t > 1) return false;
        }
        return true;
    }
};