namespace DesignPatterns.Models
{
    public class Car : Vehicle
    {

        public override int Tires => 4;


        public Car(
            string color,
            string brand,
            string model,
            int year = 2026)

            : base(
                  color,
                  brand,
                  model,
                  year)
        {

        }

    }
}