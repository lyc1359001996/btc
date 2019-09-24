using System;
using System.Collections.Generic;
using System.Text;
using B2C.DTO;
using Service.Entitie;

namespace B2C.IService
{
    public interface IUserService:IServiceSupport
    {
        UserDTO[] GetAllUserinfo();
        UserDTO[] GetAllUserinfoByUserRole(long userRoleId);
        UserDTO[] GetAllUserinfoByUserState(long userStateId);
        long AddUserInfo(UserDTO userInfo);
        long UpdateUserInfo(UserDTO userInfo);
        void DeleteUserInfo(long userInfoId);
    }
}
