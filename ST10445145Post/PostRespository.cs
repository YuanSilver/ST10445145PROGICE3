using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10445145Post
{
    public class PostRespository
    {
        
        public static List<Post> GetSamplePosts()
        {
            return new List<Post>
            {
                new Post { Id = 1, Content = "Good morning everyone!", Likes = 150 },
                new Post { Id = 2, Content = "Lunch time updates.", Likes = 85 },
                new Post { Id = 3, Content = "Had a productive morning meeting.", Likes = 200 },
                new Post { Id = 4, Content = "Evening walk by the lake.", Likes = 120 },
                new Post { Id = 5, Content = "Morning workouts keep me going.", Likes = 180 },
                new Post { Id = 6, Content = "Late night coding session complete.", Likes = 95 },
                new Post { Id = 7, Content = "Reading a great book on software architecture.", Likes = 110 },
                new Post { Id = 8, Content = "Starting my morning with a strong coffee.", Likes = 160 },
                new Post { Id = 9, Content = "New blog post about C# LINQ is live!", Likes = 130 },
                new Post { Id = 10, Content = "Exploring the lakeside this evening.", Likes = 145 },
                new Post { Id = 11, Content = "Monday morning motivation quotes incoming.", Likes = 175 },
                new Post { Id = 12, Content = "Just submitted my final year project!", Likes = 220 },
                new Post { Id = 13, Content = "Breakfast with the team today.", Likes = 90 },
                new Post { Id = 14, Content = "A calm and peaceful morning at the park.", Likes = 155 },
                new Post { Id = 15, Content = "Midday walk to clear the mind.", Likes = 105 },
                new Post { Id = 16, Content = "Happy Friday everyone!", Likes = 140 },
                new Post { Id = 17, Content = "Setting up my morning tasks and priorities.", Likes = 125 },
                new Post { Id = 18, Content = "Rewriting code to improve efficiency.", Likes = 100 },
                new Post { Id = 19, Content = "How do you structure your morning routine?", Likes = 165 },
                new Post { Id = 20, Content = "Launching a new feature this afternoon.", Likes = 190 },
                new Post { Id = 21, Content = "Quick morning yoga before work.", Likes = 170 },
                new Post { Id = 22, Content = "Discussing algorithms over coffee.", Likes = 115 },
                new Post { Id = 23, Content = "My thoughts on software testing strategies.", Likes = 135 },
                new Post { Id = 24, Content = "Working remotely from the garden today.", Likes = 125 },
                new Post { Id = 25, Content = "Morning checklist done. Ready to go!", Likes = 160 },
                new Post { Id = 26, Content = "Evening reflections on today’s work.", Likes = 108 },
                new Post { Id = 27, Content = "Planning next week’s development sprint.", Likes = 132 },
                new Post { Id = 28, Content = "Refactoring legacy code today.", Likes = 97 },
                new Post { Id = 29, Content = "Morning energy levels: high!", Likes = 173 },
                new Post { Id = 30, Content = "Reviewing design patterns this afternoon.", Likes = 142 }
            };
        }

    }
}
