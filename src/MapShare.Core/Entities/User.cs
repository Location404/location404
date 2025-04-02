using MapShare.Core.Common;
using MapShare.Core.ValueObject;

namespace MapShare.Core.Entities;

public class User(string name, string emailAddress, string password, DateTime createAt) : BaseEntity
{
    public string Name { get; private set; } = name;
    public string EmailAddress { get; private set; } = new EmailAddress(emailAddress).Value;
    public string Password { get; private set; } = password;
    public DateTime CreateAt { get; private set; } = createAt;
}