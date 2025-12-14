using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Mini Social Network ===\n");

        User alice = new User("Alice", 25);
        User bob = new User("Bob", 30);
        User carol = new User("Carol", 22);
        User dave = new User("Dave", 28);

        Console.WriteLine("\n--- Adding Friends ---");
        alice.AddFriend(bob);
        alice.AddFriend(carol);
        bob.AddFriend(alice);
        bob.AddFriend(carol);
        bob.AddFriend(dave);
        carol.AddFriend(alice);
        carol.AddFriend(bob);

        Console.WriteLine("\n--- Testing Duplicate Friend ---");
        alice.AddFriend(bob);

        Console.WriteLine("\n--- Testing Self Friend ---");
        alice.AddFriend(alice);

        Console.WriteLine("\n--- Creating Posts ---");
        alice.CreatePost("Hello world! This is my first post!");
        bob.CreatePost("Having a great day at the park!");
        carol.CreatePost("Just finished reading an amazing book!");
        dave.CreatePost("Learning C# is fun!");

        Console.WriteLine("\n--- Adding Comments ---");
        Comment comment1 = new Comment(bob, "Nice post Alice!");
        alice.Posts[0].AddComment(comment1);

        Comment comment2 = new Comment(carol, "Sounds like fun Bob!");
        bob.Posts[0].AddComment(comment2);

        Comment comment3 = new Comment(alice, "What book was it?");
        carol.Posts[0].AddComment(comment3);

        Comment comment4 = new Comment(bob, "Keep it up!");
        dave.Posts[0].AddComment(comment4);

        Console.WriteLine("\n--- Adding Likes to Posts ---");
        alice.Posts[0].AddLike(bob);
        alice.Posts[0].AddLike(carol);
        bob.Posts[0].AddLike(alice);
        carol.Posts[0].AddLike(bob);
        dave.Posts[0].AddLike(bob);

        Console.WriteLine("\n--- Testing Duplicate Like ---");
        alice.Posts[0].AddLike(bob);

        Console.WriteLine("\n--- Adding Likes to Comments ---");
        comment1.AddLike(alice);
        comment1.AddLike(carol);
        comment2.AddLike(bob);
        comment3.AddLike(carol);

        Console.WriteLine("\n--- Showing Feeds ---");
        alice.ShowFeed();
        bob.ShowFeed();
        carol.ShowFeed();

        Console.WriteLine("\n--- Removing Friend ---");
        alice.RemoveFriend(carol);
        alice.ShowFeed();

        Console.WriteLine("\n--- Testing Empty Post ---");
        alice.CreatePost("");

        Console.WriteLine("\n=== End of Demo ===");
    }
}
