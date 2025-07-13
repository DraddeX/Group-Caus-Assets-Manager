using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Entities
{
    public class Driver
    {
        public Driver(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
