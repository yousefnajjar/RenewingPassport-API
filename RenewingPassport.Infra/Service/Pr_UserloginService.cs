using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_UserloginService : IPr_UserloginService
    {
        private readonly IPr_UserloginRepository _pr_UserloginRepository;
        public Pr_UserloginService(IPr_UserloginRepository pr_UserloginRepository)
        {
            _pr_UserloginRepository = pr_UserloginRepository;
        }
        public bool CreateUser(Pr_Userlogin pr_Userlogin)
        {
            return _pr_UserloginRepository.CreateUser(pr_Userlogin);
        }

        public bool DeleteUser(int id)
        {
            return _pr_UserloginRepository.DeleteUser(id);
        }

        public List<Pr_Userlogin> GetAllUser()
        {
            return _pr_UserloginRepository.GetAllUser();
        }

        public Pr_Userlogin GetByEmail(GetByEmail email)
        {
            return _pr_UserloginRepository.GetByEmail(email);
        }

        public bool UpdatePassword(UpdatePassword updatePassword)
        {
            return _pr_UserloginRepository.UpdatePassword(updatePassword);
        }

        public bool UpdatUser(Pr_Userlogin pr_Passport)
        {
            return _pr_UserloginRepository.UpdatUser(pr_Passport);
        }
    }
}
