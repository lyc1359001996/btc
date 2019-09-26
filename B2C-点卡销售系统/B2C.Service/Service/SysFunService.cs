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
    public class SysFunService : ISysFun
    {
        /// <summary>
        /// 指定id软删除
        /// </summary>
        /// <param name="t_nodeId"></param>
        public void DeleteSysFun(long t_nodeId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<SysFunEntity> bs = new BaseService<SysFunEntity>(ctx);
                bs.MarkDeleted(t_nodeId);
            }
        }
        /// <summary>
        /// 获取所有SysFun
        /// </summary>
        /// <returns></returns>
        public SysFunDTO[] GetAllSysFun()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<SysFunEntity> bs = new BaseService<SysFunEntity>(ctx);
                var sysfunentities = bs.GetAll().ToList();
                List<SysFunDTO> sysFunDTOs = new List<SysFunDTO>();
                foreach (var item in sysfunentities)
                {
                    SysFunDTO sysFunDTO = new SysFunDTO()
                    {
                        Id = item.Id,
                        CreateDateTime = item.CreateDateTime,
                        DisplayName = item.DisplayName,
                        DisplayOrder = item.DisplayOrder,
                        NodeURL = item.NodeURL,
                        ParentNodeId = item.ParentNodeId,
                        RoleIds = item.Roles.Select(u => u.Id).ToArray()
                    };
                }
                return sysFunDTOs.ToArray();
            }

        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t_SysFun"></param>
        /// <returns></returns>
        public long InsertSysFun(SysFunDTO t_SysFun)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                List<RoleInfoEntity> roleInfoEntities = new List<RoleInfoEntity>();
                foreach (var item in t_SysFun.RoleIds)
                {
                    roleInfoEntities.Add(ctx.RolesInfo.Where(u => u.Id == item).SingleOrDefault());
                }
                SysFunEntity sysFunEntity = new SysFunEntity()
                {
                    DisplayName = t_SysFun.DisplayName,
                    ParentNodeId = t_SysFun.ParentNodeId,
                    NodeURL = t_SysFun.NodeURL,
                    DisplayOrder = t_SysFun.DisplayOrder,
                    Roles = roleInfoEntities
                };
                ctx.SysFuns.Add(sysFunEntity);
                ctx.SaveChanges();
                return sysFunEntity.Id;
            }
        }
        /// <summary>
        /// 指定id查询SysFun
        /// </summary>
        /// <param name="t_nodeId"></param>
        /// <returns></returns>
        public SysFunDTO SelectSysFunByID(long t_nodeId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<SysFunEntity> bs = new BaseService<SysFunEntity>(ctx);
                var sysfun = bs.GetAll().Where(u => u.Id == t_nodeId).SingleOrDefault();
                SysFunDTO sysFunDTO = new SysFunDTO()
                {
                    Id = sysfun.Id,
                    CreateDateTime = sysfun.CreateDateTime,
                    DisplayName = sysfun.DisplayName,
                    DisplayOrder = sysfun.DisplayOrder,
                    NodeURL = sysfun.NodeURL,
                    ParentNodeId = sysfun.ParentNodeId,
                    RoleIds = sysfun.Roles.Select(u => u.Id).ToArray()
                };
                return sysFunDTO;
            }
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t_SysFun"></param>
        /// <returns></returns>
        public long UpdateSysFun(SysFunDTO t_SysFun)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                List<RoleInfoEntity> roleInfoEntities = new List<RoleInfoEntity>();
                foreach (var item in t_SysFun.RoleIds)
                {
                    roleInfoEntities.Add(ctx.RolesInfo.Where(u => u.Id == item).SingleOrDefault());
                }
                BaseService<SysFunEntity> bs = new BaseService<SysFunEntity>(ctx);
                var sysfun = bs.GetAll().Where(u => u.Id == t_SysFun.Id).SingleOrDefault();
                sysfun.DisplayName = t_SysFun.DisplayName;
                sysfun.DisplayOrder = t_SysFun.DisplayOrder;
                sysfun.NodeURL = t_SysFun.NodeURL;
                sysfun.ParentNodeId = t_SysFun.ParentNodeId;
                sysfun.Roles = roleInfoEntities;
                ctx.SaveChanges();
                return sysfun.Id;
            }
        }
    }
}
