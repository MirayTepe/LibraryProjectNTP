using Entities.Concrete;
using Entities.DTOs;
using LibraryProject.DataAccess.Concrete.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Abstract
{
    public interface IAdminDal
    {
       
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
        List<Admin> GetAll();
        List<Admin> GetAllAdminsAndUsers(); 
        bool CheckUser(LoginDto loginDto);
        bool SendMail(string username, string email);
        Mail CheckUserForMail(string username, string email);
    }
}
