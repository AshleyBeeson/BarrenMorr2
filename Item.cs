namespace Barrenmoor
{
    public class Item
    {
        public string Name { get; set; }
        public EquipmentType type { get; set; }
        public int ContextVal { get; set; }

        public bool isUsed;

        public Item(string name, int context, EquipmentType type)
        {
            Name = name;
            ContextVal = context;
            this.type = type;
        }
    }
}