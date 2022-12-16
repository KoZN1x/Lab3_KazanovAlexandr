namespace Lab3_KazanovAlexandr
{
    public class Computer
    {
        public decimal price;
        public string model;
        public RAM ram;
        public HDD hdd;
        public Computer(int price, string model)
        {
            this.price = price;
            this.model = model;
            ram = new RAM();
            hdd = new HDD();
        }
        public Computer(int price, string model, RAM ram, HDD hdd)
        {
            this.price = price;
            this.model = model;
            this.ram = ram;
            this.hdd = hdd;
        }
        public string ToString()
        {
            return $"{model}'s price is {price}$.\n{ram.ToString()}\n{hdd.ToString()}";
        }
    }
    public class RAM
    {
        public string name;
        public int storage;
        public RAM() : this("Unknown", 0) { }
        public RAM(string name, int storage) 
        {
            this.name = name;
            this.storage = storage;
        }
        public string ToString()
        {
            return $"Name of RAM is {name}.\nStorage of RAM is {storage} Gb.";
        }
    }
    public class HDD
    {
        public string name;
        public double storage;
        public string type;
        public HDD() : this ("Unknown", 0, "Unknown") { }
        public HDD(string name, double storage, string type)
        {
            this.name = name;
            this.storage = storage;
            this.type = type;
        }
        public string ToString()
        {
            return $"Name of HDD is {name}.\nStorage of HDD is {storage} Tb.\nType of HDD is {type}.";
        }
    }
}