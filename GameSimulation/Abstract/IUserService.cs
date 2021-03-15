using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);
    }
}
