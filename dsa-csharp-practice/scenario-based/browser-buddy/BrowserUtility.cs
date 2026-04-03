using System.Collections.Generic;

class BrowserUtility : IBrowserHistory
{
    private HistoryNode head;
    private HistoryNode current;
    private Stack<HistoryNode> closedTabs;

    public BrowserUtility()
    {
        head = null;
        current = null;
        closedTabs = new Stack<HistoryNode>();
    }

    public void Visit(string url)
    {
        HistoryNode node = new HistoryNode(url);

        if (head == null)
        {
            head = current = node;
        }
        else
        {
            current.Next = node;
            node.Prev = current;
            current = node;
        }

        Console.WriteLine("Visited: " + url);
    }

    public void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Moved Back");
        }
        else
        {
            Console.WriteLine("No previous page");
        }
    }

    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Moved Forward");
        }
        else
        {
            Console.WriteLine("No next page");
        }
    }

    public void CloseTab()
    {
        if (current != null)
        {
            closedTabs.Push(current);
            current = null;
            head = null;
            Console.WriteLine("Tab closed");
        }
        else
        {
            Console.WriteLine("No tab to close");
        }
    }

    public void RestoreTab()
    {
        if (closedTabs.Count > 0)
        {
            current = closedTabs.Pop();
            head = current;
            Console.WriteLine("Tab restored");
        }
        else
        {
            Console.WriteLine("No closed tabs");
        }
    }

    public void ShowCurrentPage()
    {
        if (current != null)
            Console.WriteLine("Current Page: " + current.Url);
        else
            Console.WriteLine("No page open");
    }
}
