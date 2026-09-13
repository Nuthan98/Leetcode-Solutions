public class Solution
{
    public int LengthOfLongestSubstringTwoDistinct(string s)
    {
        int maxLength = 0;
        int l = 0;

        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int r = 0; r < s.Length; r++)
        {
            map.TryGetValue(s[r], out int count);
            map[s[r]] = count + 1;

            while (map.Count > 2)
            {
                map[s[l]]--;

                if (map[s[l]] == 0)
                    map.Remove(s[l]);

                l++;
            }

            maxLength = Math.Max(maxLength, r - l + 1);
        }

        return maxLength;
    }
}