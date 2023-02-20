using System;
namespace InterfaceExercise
{
	public class Truck: IVehicle, ICompany
	{
        public Truck()
        {
        }
        public string CompanyName { get; set; }
        public string Slogan { get; set; }

        public int NumberOfDoors { get; set; }
        public bool HasAnEngine { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; }
        public int CylinderNumber { get; set; }


        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} Now driving in four wheel forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} Now driving forward");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} Now driving in four wheel backward");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse till we change gears in four wheel.");
            }
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} Truck is now in park");
        }

        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }

    }
	
}

