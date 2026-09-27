public class Solution {
    public bool IsAnagram(string s, string t) {

        int[] arr_s = new int['z'-'a'+1];
        int[] arr_t = new int['z'-'a'+1];
        foreach(var c in s){
            arr_s[c-'a']++;
        }
        foreach(var c in t){
            arr_t[c-'a']++;
        }

        for(int i = 0; i < arr_s.Length; i++){
            if(arr_s[i]!=arr_t[i]){
                return false;
            }
        }
        return true;
    }
}
