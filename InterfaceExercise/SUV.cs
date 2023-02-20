using System;
namespace InterfaceExercise
{
	public class SUV: IVehicle, ICompany
	{
		public SUV()
		{
		}
        public string CompanyName { get; set; }
        public string Slogan { get; set; }

        public int NumberOfDoors { get; set; }
        public bool HasAnEngine { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public bool HasChangedGears { get; set; }

        public bool HasHatchBack { get; set; }
        public string Color { get; set; }


        public void Drive()
        {
            if(HasHatchBack == true)
            {
                Console.WriteLine($"{GetType().Name} Now driving forward in Mom car");
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
            Console.WriteLine($"{GetType().Name} SUV is now in park");

        }

        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }
    }
}

