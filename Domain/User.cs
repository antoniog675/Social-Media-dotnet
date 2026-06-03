using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User
{
    #region Ctor
    public User() { }
    public User(Guid id, string username, string password, string email, string bio, string profileImageUrl)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
        Bio = bio;
        ProfileImageUrl = profileImageUrl;
    }
    #endregion

    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public string ProfileImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }
}