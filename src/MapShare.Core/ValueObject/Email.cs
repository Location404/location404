namespace MapShare.Core.ValueObject;

public class EmailAddress
{
    private static string? s_emailAddress;
    public string Value { get { return s_emailAddress!; } }

    public EmailAddress(string emailAddress)
    {
        ArgumentException.ThrowIfNullOrEmpty(emailAddress, nameof(emailAddress));
        if (!IsValidEmail(emailAddress))
        {
            throw new ArgumentException("Invalid email address format.", nameof(emailAddress));
        }

        s_emailAddress = emailAddress;
    }

    private static bool IsValidEmail(string email)
    {
        var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
    }
}