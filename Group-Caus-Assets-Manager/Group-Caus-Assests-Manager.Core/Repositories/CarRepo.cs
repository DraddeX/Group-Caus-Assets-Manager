using Group_Caus_Assests_Manager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Repositories
{
    public class CarRepo
    {
        public List<Car> _cars;
        public CarRepo()
        {
            _cars =
            [
                new Car(1, "701", "ABC-123"),
                new Car(2, "702", "ABC-123"),
                new Car(3, "703", "ABC-123"),
                new Car(4, "704", "ABC-123"),
                new Car(5, "705", "ABC-123"),
            ];
        }
    }
}

