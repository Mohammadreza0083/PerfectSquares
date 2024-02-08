namespace PerfectSquares
{
    public static class PerfectSquares
    {
        public static int NumSquares(int input)
        {
            if (input == 0 || input<0 )
            {
                return 0;
            }

            int[] dp = new int[input + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= input; i++)
            {
                dp[i]=int.MaxValue;
                for (int j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }

            return Math.Max(dp[input], 0);
        }
    }
}
