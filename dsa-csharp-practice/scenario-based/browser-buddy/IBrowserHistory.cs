interface IBrowserHistory
{
    void Visit(string url);
    void Back();
    void Forward();
    void CloseTab();
    void RestoreTab();
    void ShowCurrentPage();
}