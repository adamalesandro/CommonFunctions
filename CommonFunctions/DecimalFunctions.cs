namespace CommonFunctions;
public static class DecimalFunctions
{
    public static decimal GetMultiplier(int numberOfZeros) => decimal.Parse($"0.{new string('0', numberOfZeros - 1)}1");
}
