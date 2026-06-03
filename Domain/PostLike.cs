namespace Domain;

public class PostLike
{
    #region Ctor
    public PostLike() { }
    
    public PostLike(int id, int postId, string userId)
    {
        Id = id;
        UserId = userId;
        PostId = postId;
    }
    #endregion
    
    public int Id { get; set; }
    public int PostId { get; set; }
    public string UserId { get; set; }
    public DateTime CreatedAt { get; set; }
}