public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int counteri = 0;
        for(int i =0; i< nums.Length; i ++){
            // if nums value equals the given value
            if(i < nums.Length && nums[i] == val){
                while(i < nums.Length && nums[i] == val){
                    i++;
                }
                i--;
            }else {
                nums[counteri] = nums[i];
                counteri++;
            }
        }     

        return counteri;   
    }
}