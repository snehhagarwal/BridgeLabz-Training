class AmbulanceNode
{
    public string unitName;
    public bool isAvailable;
    public AmbulanceNode next;

    public AmbulanceNode(string name, bool available)
    {
        unitName = name;
        isAvailable = available;
        next = null;
    }
}