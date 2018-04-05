namespace Barrenmoor
{
    public class Item
    {
        private string Name { get; set; }
        private int ContextVal { get; set; }

        public Item(string name, int val)
        {
            Name = name;
            ContextVal = val;
        }
    }
}