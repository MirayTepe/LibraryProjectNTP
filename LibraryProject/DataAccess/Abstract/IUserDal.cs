using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Abstract
{
    public interface IUserDal
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        List<User> GetAll();
        void UpdateActive(User user);
        bool CheckUserForMail(string email);


    }
}
