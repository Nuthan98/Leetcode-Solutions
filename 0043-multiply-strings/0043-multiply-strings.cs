public class Solution {
    public string Multiply(string num1, string num2) {
        if(num1 == "0" || num2 == "0") return "0";

        int[] res = new int[num1.Length + num2.Length];

        for(int i = num1.Length-1; i >=0; i--)
        {
            for(int j= num2.Length-1; j >=0; j--)
            {
                int dig = (num1[i] - '0') * (num2[j] - '0');
                int sum = dig + res[i+j+1];
                res[i+j+1] = (sum%10);
                res[i+j]+= (sum/10);
            }
        }
        var result = new System.Text.StringBuilder();
        foreach(int num in res)
        {
            if(!(result.Length == 0 && num == 0))
                result.Append(num);
        }
         return result.ToString();
    }
}