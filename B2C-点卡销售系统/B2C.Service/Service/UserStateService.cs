using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B2C.DAL.Service
{
    public class UserStateService : IUserState
    {
        /// <summary>
        /// 指定用户id软删除
        /// </summary>
        /// <param name="t_userStateId"></param>
        /// <returns></returns>
        public void DeleteUserState(long t_userStateId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserStateEntity> bs = new BaseService<UserStateEntity>(ctx);
                bs.MarkDeleted(t_userStateId);
            }
        }
        /// <summary>
        /// 获取所有用户状态
        /// </summary>
        /// <returns></returns>
        public UserStateDTO[] GetAllUserState()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserStateEntity> bs = new BaseService<UserStateEntity>(ctx);
                var userstates = bs.GetAll().ToList();
                List<UserStateDTO> userStateDTOs = new List<UserStateDTO>();
                foreach (var item in userstates)
                {
                    UserStateDTO userStateDTO = new UserStateDTO()
                    {
                        Id = item.Id,
                        CreateDateTime = item.CreateDateTime,
                        UserState = item.UserState,
                        UserStateName = item.UserStateName
                    };
                    userStateDTOs.Add(userStateDTO);
                }
                return userStateDTOs.ToArray();
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t_UserState"></param>
        /// <returns></returns>
        public long InsertUserState(UserStateDTO t_UserState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                //BaseService<UserStateEntity> bs = new BaseService<UserStateEntity>(ctx);
                UserStateEntity userStateEntity = new UserStateEntity()
                {
                    UserStateName = t_UserState.UserStateName
                };
                ctx.UserStates.Add(userStateEntity);
                ctx.SaveChanges();
                return userStateEntity.Id;
            }
        }
        /// <summary>
        /// 指定用户id查询用户状态
        /// </summary>
        /// <param name="t_userStateId"></param>
        /// <returns></returns>
        public UserStateDTO SelectUserStateByID(long t_userStateId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserStateEntity> bs = new BaseService<UserStateEntity>(ctx);
                var userstatedto = bs.GetAll().Where(u => u.Id == t_userStateId).SingleOrDefault();
                UserStateDTO userStateDTO = new UserStateDTO()
                {
                    Id = userstatedto.Id,
                    CreateDateTime = userstatedto.CreateDateTime,
                    UserState = userstatedto.UserState,
                    UserStateName = userstatedto.UserStateName
                };
                return userStateDTO;
            }
        }
        /// <summary>
        /// 更新用户状态
        /// </summary>
        /// <param name="t_UserState"></param>
        /// <returns></returns>
        public long UpdateUserState(UserStateDTO t_UserState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserStateEntity> bs = new BaseService<UserStateEntity>(ctx);
                var userState = bs.GetAll().Where(u => u.Id == t_UserState.Id).SingleOrDefault();
                userState.UserState = t_UserState.UserState;
                userState.UserStateName = t_UserState.UserStateName;
                ctx.SaveChanges();
                return userState.Id;
            }
        }
    }
}
