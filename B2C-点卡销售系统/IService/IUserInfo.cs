using System;
using System.Collections.Generic;
using System.Text;
using B2C.DTO;
using Service.Entitie;

namespace B2C.IService
{
    public interface IUserInfo : IServiceSupport
    {
        UserInfoDTO[] GetAllUserinfo();
        UserInfoDTO[] GetAllUserinfoByUserRole(long userRoleId);
        UserInfoDTO[] GetAllUserinfoByUserState(long userStateId);
        long AddUserInfo(UserInfoDTO userInfo);
        long UpdateUserInfo(UserInfoDTO userInfo);
        void DeleteUserInfo(long userInfoId);
    }
}
