using Group_Caus_Assests_Manager.Core.Enums;

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
        public bool IsAvailable { get; set; } = true;
        public FuelState FuelState { get; set; } = FuelState.Full;
        public string Notes { get; set; } = string.Empty;
    }
}
