using System;
class Video{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments;

    public Video(string title,string author, float length)
    {
        _title=title;
        _author=author;
        _length=length;
        _comments= new List<Comment>();
    }
    public void AddComment(Comment newComment){
        
        _comments.Add(newComment);
    }
    public int GetNumberOfComments(){
        return _comments.Count();

    }
    public void ShowVideoInfo() {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length} minutes, Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.ShowComment();
        }
    }
    
}