using System;
using System.Collections.Generic;

public class Comment
{
    public User Author { get; set; }
    public string Content { get; set; }
    public List<User> Likes { get; set; }

    public Comment(User author, string content)
    {
        Author = author;
        Content = content;
        Likes = new List<User>();
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine($"{user.Name} already liked this comment.");
            return;
        }

        Likes.Add(user);
        Console.WriteLine($"{user.Name} liked the comment!");
    }
}
