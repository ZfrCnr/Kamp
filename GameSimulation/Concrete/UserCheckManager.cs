using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Abstract;
using GameSimulation.Entities;

namespace GameSimulation.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}
