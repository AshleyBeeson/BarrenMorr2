namespace Barrenmoor
{
    public class Item
    {
        public string Name { get; set; }
        public int ContextVal { get; set; }

        public Item(string name, int val)
        {
            Name = name;
            ContextVal = val;
        }
    }
}