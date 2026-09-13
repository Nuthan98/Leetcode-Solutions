public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int maxLength = 0;
        int l = 0;
        int r = 0;
        Dictionary<char, int> res = new Dictionary<char, int>();

        while(r<s.Length)
        {
            if(res.ContainsKey(s[r]))
            {
                int count = res[s[r]];
                count++;
                res[s[r]] = count;
            }
            else
            {
                res[s[r]] = 1;
            }
            r++;

            if(res.Count > 2)
            {
                int count = res[s[l]];
                count--;
                res[s[l]] = count;

                if(res[s[l]]==0)
                    res.Remove(s[l]);

                l++;
            }

            if(maxLength< r-l)
            {
                maxLength = r-l;
            }
        }
        return maxLength;
    }
}