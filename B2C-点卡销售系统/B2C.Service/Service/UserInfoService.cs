using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using B2C.DTO;
using B2C.IService;
using B2C.Utility;
using Service;
using Service.Entitie;

namespace B2C.Service.Service
{
    public class UserInfoService : IUserInfo
    {
        /// <summary>
        /// 填写用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public long AddUserInfo(UserInfoDTO userInfo)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardTypeEntity> cardType
                    = new BaseService<CardTypeEntity>(ctx);
                UserInfoEntity userInfoEntity = new UserInfoEntity();
                userInfoEntity.Address = userInfo.Address;
                userInfoEntity.Email = userInfo.Email;
                userInfoEntity.Gender = userInfo.Gender;
                userInfoEntity.IDCardNo = userInfo.IDCardNo;
                userInfoEntity.Money = userInfo.Money;
                userInfoEntity.PassAnswer = userInfo.PassAnswer;
                userInfoEntity.PassQuestion = userInfo.PassQuestion;
                string salt = CommomHelper.CreateVerifyCode(5);
                string hash = CommomHelper.CalcMD5(salt + userInfo.Password);
                userInfoEntity.PassWordSalt = salt;
                userInfoEntity.PassWordHash = hash;
                userInfoEntity.PhoneNumber = userInfo.PhoneNumber;
                userInfoEntity.RoleInfoId = userInfo.RoleId;
                userInfoEntity.UserName = userInfo.UserName;
                userInfoEntity.UserStateId = userInfo.UserStateId;
                foreach (var item in cardType.GetAll().Where(a=>userInfo.CardTypeIds.Contains(a.Id)))
                {
                    userInfoEntity.CardTypes.Add(item);
                }
                ctx.UserInfos.Add(userInfoEntity);
                ctx.SaveChanges();
                return userInfoEntity.Id;
            }
        }
        /// <summary>
        /// 指定用户id软删除
        /// </summary>
        /// <param name="userInfoId"></param>
        public void DeleteUserInfo(long userInfoId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                bs.MarkDeleted(userInfoId);
            }
        }
        private UserInfoDTO ToDTO(UserInfoEntity userInfo)
        {
            UserInfoDTO userDTO = new UserInfoDTO()
            {
                UserName = userInfo.UserName,
                Address = userInfo.Address,
                Id = userInfo.Id,
                Gender = userInfo.Gender,
                Email = userInfo.Email,
                PassAnswer = userInfo.PassAnswer,
                IDCardNo = userInfo.IDCardNo,
                Money = userInfo.Money,
                PassQuestion = userInfo.PassQuestion,
                PhoneNumber = userInfo.PhoneNumber,
                UserRoleName = userInfo.RoleInfo.RoleName,
                UserState = userInfo.UserState.UserStateName,
                RoleId = userInfo.RoleInfoId,
                UserStateId = userInfo.UserStateId,
                
            };
            return userDTO;
        }
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public UserInfoDTO[] GetAllUserinfo()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                var users = bs.GetAll().Include(e => e.RoleInfo).Include(e => e.UserState).AsNoTracking().ToList().Select(l => ToDTO(l)).ToArray();
                return users;
            }
        }
        /// <summary>
        /// 指定角色id查询所有用户信息
        /// </summary>
        /// <param name="userRoleId"></param>
        /// <returns></returns>
        public UserInfoDTO[] GetAllUserinfoByUserRole(long userRoleId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                var users = bs.GetAll().Include(e => e.RoleInfo).Include(e => e.UserState).AsNoTracking().Where(e => e.RoleInfoId == userRoleId).ToList().Select(l => ToDTO(l)).ToArray();
                return users;
            }
        }
        /// <summary>
        /// 制定用户状态查询所有用户信息
        /// </summary>
        /// <param name="userStateId"></param>
        /// <returns></returns>
        public UserInfoDTO[] GetAllUserinfoByUserState(long userStateId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                var users = bs.GetAll().Include(e => e.RoleInfo).Include(e => e.UserState).AsNoTracking().Where(e => e.UserStateId == userStateId).ToList().Select(l => ToDTO(l)).ToArray();
                return users;
            }
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public long UpdateUserInfo(UserInfoDTO userInfo)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                var dbUser = bs.GetById(userInfo.Id);
                dbUser.Address = userInfo.Address;
                dbUser.Email = userInfo.Email;
                dbUser.Gender = userInfo.Gender;
                dbUser.IDCardNo = userInfo.IDCardNo;
                dbUser.Money = userInfo.Money;
                dbUser.PassQuestion = userInfo.PassQuestion;
                dbUser.PassAnswer = userInfo.PassAnswer;
                dbUser.PhoneNumber = userInfo.PhoneNumber;
                dbUser.RoleInfoId = userInfo.RoleId;
                dbUser.UserStateId = userInfo.UserStateId;
                dbUser.UserName = userInfo.UserName;
                string hash = CommomHelper.CalcMD5(dbUser.PassWordSalt + userInfo.Password);
                dbUser.PassWordHash = hash;
                dbUser.CardTypes.Clear();
                var atts = ctx.CardType.Where(a => a.IsDelete == false &&
                   userInfo.CardTypeIds.Contains(a.Id));
                foreach (var item in atts)
                {
                    dbUser.CardTypes.Add(item);
                }
                ctx.SaveChanges();
                return dbUser.Id;
            }
        }

    }
}
                    