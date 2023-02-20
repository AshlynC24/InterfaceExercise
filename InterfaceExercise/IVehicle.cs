using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        public int NumberOfDoors { get; set; }
        public bool HasAnEngine { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public bool HasChangedGears { get; set; }


        public void Drive();
        public void Reverse();
        public void Park();

        public void ChangeGears(bool IsChanged);
    }
}

