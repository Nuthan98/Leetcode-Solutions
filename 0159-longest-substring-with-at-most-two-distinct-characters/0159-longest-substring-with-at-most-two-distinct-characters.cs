public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int maxLength = 0;
        int l = 0;
        int r = 0;
        Dictionary<char, int> res = new Dictionary<char, int>();
        char[] charS = s.ToCharArray();

        while(r<charS.Length)
        {
            if(res.ContainsKey(charS[r]))
            {
                int count = res[charS[r]];
                count++;
                res[charS[r]] = count;
            }
            else
            {
                res[charS[r]] = 1;
            }
            r++;

            while(res.Count > 2)
            {
                int count = res[charS[l]];
                count--;
                res[charS[l]] = count;

                if(res[charS[l]]==0)
                    res.Remove(charS[l]);

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