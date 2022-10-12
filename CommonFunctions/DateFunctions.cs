namespace CommonFunctions;

public static class DateFunctions
{
    public static double ToUnixTimeInSeconds(DateTime date) => (double) Math.Round(SubtractEpochFromDate(date).TotalSeconds);

    public static double ToUnixTimeInMilliseconds(DateTime date) => (double) Math.Round(SubtractEpochFromDate(date).TotalMilliseconds);

    public static DateTime FromUnixTimeSeconds(long value) => DateTimeOffset.FromUnixTimeSeconds(value).DateTime;

    public static DateTime FromUnixTimeMilliseconds(long value) => DateTimeOffset.FromUnixTimeMilliseconds(value).DateTime;

    private static SubtractEpochFromDate(DateTime date) => date.ToUniversalTime().Subtract(new DateTime(1970, 1, 1));
}