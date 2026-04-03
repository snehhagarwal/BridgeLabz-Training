using System;

// Node for text history
class TextNode
{
    public string Text;
    public TextNode prev,next;
}

// Text editor with undo/redo
class Editor
{
    TextNode current;

    // Add new text state
    public void Add(string text)
    {
        TextNode node=new TextNode{Text=text,prev=current};
        if (current != null)
        {
            current.next=node;
        }
        current=node;
    }

    // Undo to previous state
    public void Undo()
    {
        if(current!=null && current.prev != null)
        {
            current=current.prev;
        }
    }

    // Redo to next state
    public void Redo()
    {
        if(current!=null && current.next != null)
        {
            current=current.next;
        }
    }

    // Display current text
    public void Show()
    {
        Console.WriteLine(current!=null ? current.Text : "Empty");
    }
}

// Main class for demo
class EditorMain
{
    static void Main(string[] args)
    {
        Editor e=new Editor();
        e.Add("Hello");
        e.Add("Hello World");
        e.Undo();
        e.Redo();
    }
}