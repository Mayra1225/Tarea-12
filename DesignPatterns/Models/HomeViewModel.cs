using System.Collections.Generic;

namespace DesignPatterns.Models
{
    public class HomeViewModel
    {

        public ICollection<Vehicle> Vehicles
        {
            get;
            set;
        }

    }
}