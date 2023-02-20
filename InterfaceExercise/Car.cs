using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
		}

        public int NumberOfDoors { get  ; set ; }
        public bool HasAnEngine { get ; set ; }
        public string Model { get ; set ; }
        public string Make { get ; set ; }
        public string CompanyName { get ; set ; }
        public string Slogan { get ; set ; }
        public bool HasChangedGears { get; set; }

        public int NumberOfSeats { get; set; }
        public bool IsSafe { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} Now driving forward");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} Now driving backward");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse till we change gears.");
            }
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} Now in park");
        }
        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }
    }
}

