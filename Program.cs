//*****************************************************************************
//** 2210. Count Hills and Valleys in an Array                      leetcode **
//*****************************************************************************

int countHillValley(int* nums, int numsSize) {
    int i = 1;
    int ans = 0;
    while (i < numsSize) {
        int a = i - 1;
        while (i + 1 < numsSize && nums[i] == nums[i + 1]) i++;
        if (i == numsSize - 1) break;
        int b = i + 1;
        if ((nums[b] < nums[i] && nums[i] > nums[a]) || 
            (nums[b] > nums[i] && nums[i] < nums[a])) {
                ans++;
            }
        i = b;
        }
    return ans;    
}