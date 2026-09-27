public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict_comp = new Dictionary<int, int>();

        for(int i =0 ; i < nums.Length; i ++){
            if(dict_comp.TryGetValue(nums[i], out var index)){
                return new int[] {index, i};
            }else{
                dict_comp[target-nums[i]] = i;
            }
        }

        return new int[] {};
    }
}