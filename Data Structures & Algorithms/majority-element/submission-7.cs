public class Solution {
    public int MajorityElement(int[] nums) {
        var dict_numsFreq = new Dictionary<int, int>();
        var toreturn = 0;
        var maxfreq = 0;
        bool isfirstTime = true;
        foreach(var i in nums){
            if(dict_numsFreq.TryGetValue(i, out var currfreq)){
                dict_numsFreq[i]=++currfreq;
                if (currfreq > nums.Length/2) return i;
                if(maxfreq < currfreq){
                    maxfreq = currfreq;
                    toreturn = i;
                }
            }else{
                dict_numsFreq[i] = 1;
                if(isfirstTime){
                    toreturn = i;
                    isfirstTime = false;
                }
            }
        }

        return toreturn;
    }
}