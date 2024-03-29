using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }

    public int CountComments() {

        return _comments.Count();

        // int count = 0;
        // count = _comments.Count();
        // return count;

    }

    public void DisplayComments() {
        //video information
        Console.WriteLine($"Video: {_title} by {_author} ({_length} seconds).");
        Console.WriteLine();

        //comments and comment count
        Console.WriteLine($"{_title} has {_comments.Count()} comments.");
        foreach (Comment comment in _comments) {
            comment.DisplayComment();
        }
    }
}
