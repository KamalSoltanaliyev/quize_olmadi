namespace quize_olmadi
{
    public class Hotel
    {
        private string name;
        private Room[] rooms;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("duz deyil xiyar, cix cole!");
                }
                name = value;
            }
        }

        public Hotel(string name)
        {
            Name = name;
            rooms = new Room[0];
        }
        public void MakeReservation(int roomId)
        {
            try
            {
                if (roomId == null)
                {
                    throw new NullReferenceException("room null ola bilmez, xiyar");
                }

                Room room = rooms.FirstOrDefault(r => r.Id == roomId);

                if (room == null)
                {
                    throw new ArgumentException($"roomun bele id {roomId} tapilmayib, xiyar");
                }

               
                room.IsAvailable = false;
                Console.WriteLine($"Reservation made for Room {roomId}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}