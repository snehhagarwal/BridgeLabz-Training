namespace traffic_manager
{
    class CustomNode
    {
        public Vehicle Data;
        public CustomNode Next;

        public CustomNode(Vehicle vehicle)
        {
            Data = vehicle;
            Next = null;
        }
    }
}
