using System;
namespace Classes
{
	public class Car
	{
		public Car()
		{

		}
	
	
		public Car(string makeInput, string modelInput, int yearInput)
		{
			Make = makeInput;
			Model = modelInput;
			Year = yearInput;
		}


		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }



		 

	}

}

