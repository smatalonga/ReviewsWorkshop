
namespace CoinChange.Tests
{
    internal class CentsPrograme
    {
        internal static int WaysToMakeChange(int amount)
        {
            
            int[] coins = { 1, 5, 10, 25 }; // available coin denominations
            int[] ways = new int[amount + 1]; // array to store number of ways to make change

            ways[0] = 1; // base case

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    ways[i] += ways[i - coin];
                }
            }

            return ways[amount];
            
        }
    }
}