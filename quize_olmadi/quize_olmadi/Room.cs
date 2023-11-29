namespace quize_olmadi
{
    public class Room
    {
        private static int counter = 1;
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int PersonCapacity { get; }
        public bool IsAvailable { get; set; } = true;

        public Room (int id, string name, decimal price, int personCapacity)
        {
            Id = counter++;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Capacity: {PersonCapacity}, Available: {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}





