using System;
using System.Collections.Generic;

public class Post
{
    public User Author { get; set; }
    public string Content { get; set; }
    public List<Comment> Comments { get; set; }
    public List<User> Likes { get; set; }
    public DateTime CreatedAt { get; set; }

    public Post(User author, string content)
    {
        Author = author;
        Content = content;
        Comments = new List<Comment>();
        Likes = new List<User>();
        CreatedAt = DateTime.Now;
    }

    public void AddComment(Comment comment)
    {
        if (comment == null)
        {
            Console.WriteLine("Cannot add null comment.");
            return;
        }

        Comments.Add(comment);
        Console.WriteLine("Comment added successfully!");
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine($"{user.Name} already liked this post.");
            return;
        }

        Likes.Add(user);
        Console.WriteLine($"{user.Name} liked the post!");
    }
}
