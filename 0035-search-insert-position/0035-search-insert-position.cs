public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            if(i != nums.Length - 1)
            { 
                if (nums[i] == target)
                    return i;
                if (nums[i] < target && nums[i + 1] > target || nums[i + 1] == target)
                    return i + 1;

            }
            else
            {
                if (nums[i] == target)
                    return i;
                if (nums[i] < target)
                    return i + 1;
            }
            if(nums[i] > target)
                return i;

        }
        return -1;
    }
}