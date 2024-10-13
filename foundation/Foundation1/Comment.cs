using System;
class Comment {
    private  string _name;
    private string _text;

    public Comment(string[] comment){
        _name= comment[0];
        _text= comment[1];
    }
    public void ShowComment(){
        Console.WriteLine($"User: {_name}, Comment: {_text}");
    }

}