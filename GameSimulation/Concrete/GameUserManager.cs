using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Abstract;
using GameSimulation.Entities;

namespace GameSimulation.Concrete
{
    public class GameUserManager : BaseUserManager
    {
        private IUserCheckService _userCheckService;

        public GameUserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public override void Save(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Save(user);
            }

            else
            {
                throw new Exception("Mernis doğrulaması başarısız!");
            }
        }
    }
}
