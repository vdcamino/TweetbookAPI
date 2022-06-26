using TweetbookAPI.Domain;

namespace TweetbookAPI.Services
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(Post post);

        Task<bool> DeletePostAsync(Guid postId);

        Task<bool> UpdatePostAsync(Post postToUpdate);

        Task<Post> GetPostByIdAsync(Guid postId);

        Task<List<Post>> GetPostsAsync();
    }
}
