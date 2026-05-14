public static class StringExtensions
{
    public static string ToFirstUpper(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        // Return the first char (uppercase) + the rest of the string
        return char.ToUpper(input[0]) + input.Substring(1);
    }
}