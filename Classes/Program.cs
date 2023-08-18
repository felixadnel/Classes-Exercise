namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Dodge";
            myCar.Model = "Scatpack";
            myCar.Year = 2021;

            var nissan = new Car()
            {
                Make = "Nissan",
                Model = "350z",
                Year = 2006
            };

            var chevy = new Car("chevy", "zl1", 2022);

            var carList = new List<Car>() { myCar, chevy, nissan };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

        }
    }
}
