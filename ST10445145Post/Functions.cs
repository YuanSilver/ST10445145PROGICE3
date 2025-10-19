using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10445145Post
{
    class Functions
    {
        public static int TotalPost()
        {
            List<Post> posts = PostRespository.GetSamplePosts();
            return posts.Count;
        }

        public static void MostLikedPost()
        {
            List<Post> posts = PostRespository.GetSamplePosts();
            var mostLikedPost = posts.OrderByDescending(p => p.Likes).FirstOrDefault();
            if (mostLikedPost != null)
            {
                Console.WriteLine($"Most Liked Post: {mostLikedPost.Content} with {mostLikedPost.Likes} likes.");
            }
            else
            {
                Console.WriteLine("No posts available.");
            }
        }

        public static void MorninPost()
        {
            var posts = PostRespository.GetSamplePosts();

            var morningPosts = posts
                .Where(p=> p.Content.IndexOf("morning", StringComparison.OrdinalIgnoreCase) >=0)
                .ToList();

            Console.WriteLine("Morning Posts:");
            foreach (var post in morningPosts)
            {
                Console.WriteLine($"Post ID: {post.Id}, Content: {post.Content}, Likes: {post.Likes}");
            }

        }

        public static int AverageLikes()
        {
            List<Post> posts = PostRespository.GetSamplePosts();
            int avgLikes = posts.Sum(p => p.Likes);
            avgLikes = avgLikes / posts.Count();
            return avgLikes;
        }

        public static void Top3Post()
        {
            var posts = PostRespository.GetSamplePosts();

            var top3Posts = posts
                .OrderByDescending(p => p.Likes)
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 most liked posts:");
            foreach (var post in top3Posts)
            {
                Console.WriteLine($"Post ID: {post.Id}, Likes: {post.Likes}, Content: {post.Content}");
            }

        }
    }
}
