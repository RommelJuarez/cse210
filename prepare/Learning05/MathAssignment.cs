using System;
public class MathAssignment:Assignment{
    private string _textBookSection;
    private string _problems;


    public MathAssignment(string textBookSection,string problems,string studentName,string topic)
    :base(studentName,topic){
        
        _problems=problems;
        _textBookSection=textBookSection;
    }
   
    public string GetHomeworkList(){
        return "Section: "+_textBookSection+", Problems: "+_problems;
    }

}