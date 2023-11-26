using System.Data;

namespace _03._Store_Boxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQantuity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQantity = itemQantuity;
            PriceForBox = item.Price * itemQantuity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQantity { get; set; }
        public decimal PriceForBox { get; set; }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] data = command.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber, currentItem, itemQantity);       

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
}
