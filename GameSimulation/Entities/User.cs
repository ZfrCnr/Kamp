using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    public class User : IEntity 
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
