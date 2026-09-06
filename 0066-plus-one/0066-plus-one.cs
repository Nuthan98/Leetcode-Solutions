public class Solution {
    public int[] PlusOne(int[] digits) {
        int length = digits.Length;
        for(int i = length - 1; i >= 0; i--)
        {
            if(digits[i]<9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newRes = new int[length+1];
        newRes[0] = 1;
        return newRes;
    }
}