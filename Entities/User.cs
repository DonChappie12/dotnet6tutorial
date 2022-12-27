using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    // Not yet fully implemented
    // public Role Role { get; set; }
    [JsonIgnore]
    public string PasswordHash { get; set; }
}