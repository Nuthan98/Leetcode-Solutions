public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
            return string.Empty;
        
        int[] window = new int[128];
        int left = 0, right = 0, minLength = int.MaxValue, startIndex = 0;
        int count = t.Length;

        foreach(char c in t)
        {
            window[c]++;
        }

        char[] chS = s.ToCharArray();

        while(right < chS.Length)
        {
            if(window[chS[right++]]-- > 0)
            {
                count--;
            }
            while(count==0)
            {
                if(right-left < minLength)
                {
                    startIndex = left;
                    minLength = right-left;
                }

                if(window[chS[left++]]++ == 0)
                {
                    count++;
                }
            }
        }

        return minLength == int.MaxValue ? string.Empty : new string(chS, startIndex, minLength); 
    }
}