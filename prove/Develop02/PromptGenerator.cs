using System.Collections.Generic;
class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What was the best part of my day?",
        "What challenged me today, and how did I handle it?",
        "What am I grateful for today?",
        "What made me smile today?",
        "What did I learn today?"
    };
    public string RandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(prompts.Count);
        return prompts[index];
    }
}