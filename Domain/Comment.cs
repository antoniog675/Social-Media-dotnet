using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Comment
{
    #region Ctor
    public Comment() { }
    
    public Comment(string content)
    {
        Content = content;
    }

    public Comment(int id, int postId, int userId, string content)
    {
        Id = id;
        PostId = postId;
        UserId = userId;
        Content = content;
    }
    #endregion
    
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}