using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
