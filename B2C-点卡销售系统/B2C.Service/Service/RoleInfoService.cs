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
    public class RoleInfoService : IRoleInfo
    {
        /// <summary>
        /// 指定id软删除
        /// </summary>
        /// <param name="t_roleId"></param>
        public void DeleteRoleInfo(long t_roleId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<RoleInfoEntity> bs = new BaseService<RoleInfoEntity>(ctx);
                bs.MarkDeleted(t_roleId);
            }
        }
        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        public RoleInfoDTO[] GetAllRoleInfo()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<RoleInfoEntity> bs = new BaseService<RoleInfoEntity>(ctx);
                var roleInfoEntities = bs.GetAll().ToList();
                List<RoleInfoDTO> roleInfoDTOs = new List<RoleInfoDTO>();
                foreach (var item in roleInfoEntities)
                {
                    RoleInfoDTO roleInfoDTO = new RoleInfoDTO()
                    {
                        Id = item.Id,
                        CreateDateTime = item.CreateDateTime,
                        DisCount = item.DisCount,
                        RoleDesc = item.RoleDesc,
                        RoleName = item.RoleName,
                        SysfunIds = item.SysFuns.Select(u => u.Id).ToArray()
                    };
                }
                return roleInfoDTOs.ToArray();
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t_RoleInfo"></param>
        /// <returns></returns>
        public long InsertRoleInfo(RoleInfoDTO t_RoleInfo)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                List<SysFunEntity> sysFunEntities = new List<SysFunEntity>();
                foreach (var item in t_RoleInfo.SysfunIds)
                {
                    sysFunEntities.Add(ctx.SysFuns.Where(u => u.Id == item).SingleOrDefault());
                }
                RoleInfoEntity roleInfoEntity = new RoleInfoEntity()
                {
                    DisCount = t_RoleInfo.DisCount,
                    RoleName = t_RoleInfo.RoleName,
                    RoleDesc = t_RoleInfo.RoleDesc,
                    SysFuns = sysFunEntities
                };
                ctx.RolesInfo.Add(roleInfoEntity);
                ctx.SaveChanges();
                return roleInfoEntity.Id;
            }
        }
        /// <summary>
        /// 指定id查询
        /// </summary>
        /// <param name="t_roleId"></param>
        /// <returns></returns>
        public RoleInfoDTO SelectRoleInfoByID(long t_roleId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<RoleInfoEntity> bs = new BaseService<RoleInfoEntity>(ctx);
                var roleInfo = bs.GetAll().Where(u => u.Id == t_roleId).SingleOrDefault();
                RoleInfoDTO roleInfoDTO = new RoleInfoDTO()
                {
                    Id = roleInfo.Id,
                    CreateDateTime = roleInfo.CreateDateTime,
                    RoleDesc = roleInfo.RoleDesc,
                    DisCount = roleInfo.DisCount,
                    RoleName = roleInfo.RoleName,
                    SysfunIds = roleInfo.SysFuns.Select(u => u.Id).ToArray()
                };
                return roleInfoDTO;
            }
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t_RoleInfo"></param>
        /// <returns></returns>
        public long UpdateRoleInfo(RoleInfoDTO t_RoleInfo)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                List<SysFunEntity> sysFunEntities = new List<SysFunEntity>();
                foreach (var item in t_RoleInfo.SysfunIds)
                {
                    sysFunEntities.Add(ctx.SysFuns.Where(u => u.Id == item).SingleOrDefault());
                }
                BaseService<RoleInfoEntity> bs = new BaseService<RoleInfoEntity>(ctx);
                var roleInfo = bs.GetAll().Where(u => u.Id == t_RoleInfo.Id).SingleOrDefault();
                roleInfo.RoleDesc = t_RoleInfo.RoleDesc;
                roleInfo.RoleName = t_RoleInfo.RoleName;
                roleInfo.DisCount = t_RoleInfo.DisCount;
                roleInfo.SysFuns = sysFunEntities;
                ctx.SaveChanges();
                return roleInfo.Id;
            }
        }
    }
}
