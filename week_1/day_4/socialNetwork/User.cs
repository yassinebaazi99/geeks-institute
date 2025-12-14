using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<User> Friends { get; set; }
    public List<Post> Posts { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
        Friends = new List<User>();
        Posts = new List<Post>();
    }

    public void AddFriend(User user)
    {
        if (user == this)
        {
            Console.WriteLine("You cannot add yourself as a friend.");
            return;
        }

        if (Friends.Contains(user))
        {
            Console.WriteLine($"{user.Name} is already your friend.");
            return;
        }

        Friends.Add(user);
        Console.WriteLine($"{user.Name} is now your friend!");
    }

    public void RemoveFriend(User user)
    {
        if (Friends.Contains(user))
        {
            Friends.Remove(user);
            Console.WriteLine($"{user.Name} has been removed from your friends.");
        }
        else
        {
            Console.WriteLine($"{user.Name} is not in your friends list.");
        }
    }

    public void CreatePost(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            Console.WriteLine("Post content cannot be empty.");
            return;
        }

        Post newPost = new Post(this, content);
        Posts.Add(newPost);
        Console.WriteLine("Post created successfully!");
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n=== {Name}'s Feed ===");

        List<Post> feedPosts = new List<Post>();

        foreach (User friend in Friends)
        {
            feedPosts.AddRange(friend.Posts);
        }

        if (feedPosts.Count == 0)
        {
            Console.WriteLine("No posts to show. Add more friends!");
            return;
        }

        foreach (Post post in feedPosts.OrderByDescending(p => p.CreatedAt))
        {
            Console.WriteLine($"\n{post.Author.Name} posted: \"{post.Content}\" (Likes: {post.Likes.Count})");

            if (post.Comments.Count > 0)
            {
                foreach (Comment comment in post.Comments)
                {
                    Console.WriteLine($"  {comment.Author.Name} commented: \"{comment.Content}\" (Likes: {comment.Likes.Count})");
                }
            }
        }
    }
}
