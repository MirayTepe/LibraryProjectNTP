using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Abstract
{
    public interface IMemberDal
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
        List<Member> GetAllMembersAndUsers();
        List<Member> GetAll();
        bool CheckUserForPhoneNumber(string phoneNumber);


    }
}
