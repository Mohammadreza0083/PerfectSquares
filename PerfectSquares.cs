namespace PerfectSquares
{
    public static class PerfectSquares
    {
        public static int NumSquares(int input)
        {
            if (input==0)
            {
                return 000;
            }
            int[] dp = new int[input+1];
            dp[0] = 0;
            for (int i = 1; i <= input; i++)
            {
                dp[i]=int.MaxValue;
                for (int j = 0; j*j <= i;j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }
            return dp[input];
        }
    }
}
