namespace Domain;

public class Post
{
    #region Ctor
    
    public Post() { }
    
    public Post(int id, string userId, string content)
    {
        Id = id;
        UserId = userId;
        Content = content;
    }
    #endregion
    
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    
}