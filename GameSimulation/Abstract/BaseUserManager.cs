using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Save(User user)
        {
            Console.WriteLine("Sn. " + user.FirstName + " " + user.LastName + " kayıt işleminiz yapıldı.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Sn. " + user.FirstName + " " + user.LastName + " bilgileriniz güncellendi.");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Sn. " + user.FirstName + " " + user.LastName + " hesabınız silindi.");
        }
    }
}
