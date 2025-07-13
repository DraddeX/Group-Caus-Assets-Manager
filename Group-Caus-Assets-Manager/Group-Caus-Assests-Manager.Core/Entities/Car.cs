namespace Group_Caus_Assests_Manager.Core.Entities
{
    public class Car
    {
        public Car(int id, string name, string licensePlate)
        {
            Id = id;
            Name = name;
            LicensePlate = licensePlate;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
    }
}
