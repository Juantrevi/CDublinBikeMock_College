namespace DublinBikeMock.models;

public class BikeStation
{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bikes { get; set; }
        public int Stands { get; set; }
        public int MechanicalBikes { get; set; }
        public int ElectricalBikes { get; set; }
        public int ElectricalInternalBatteryBikes { get; set; }
        public int ElectricalRemovableBatteryBikes { get; set; }

        public BikeStation(int id, string name, int bikes)
        {
                Id = id;
                Name = name;
                Bikes = bikes;
        }

        public BikeStation()
        {
        }
}