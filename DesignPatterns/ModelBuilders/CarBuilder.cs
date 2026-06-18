using DesignPatterns.Models;

namespace DesignPatterns.ModelBuilders
{
    public class CarBuilder
    {
        private string color = "red";
        private string model = "Mustag";
        private string brand = "Ford";

        public CarBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public Vehicle Build()
        {
            return new Car(color, model, brand);
        }

    }
}
