using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;

namespace B2C.DAL.Service
{
    public class AdviceService : IAdvice
    {
        /// <summary>
        /// 根据Id软删除
        /// </summary>
        /// <param name="t_adviceId"></param>
        public void DeleteAdvice(long t_adviceId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<AdviceEntity> bs = new BaseService<AdviceEntity>(ctx);
                bs.MarkDeleted(t_adviceId);
            }
        }
        /// <summary>
        /// 获取所有Advice
        /// </summary>
        /// <returns></returns>
        public AdviceDTO[] GetAllAdvice()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<AdviceEntity> bs = new BaseService<AdviceEntity>(ctx);
                var users = bs.GetAll().Include(e => e.User).AsNoTracking().ToList();
                List<AdviceDTO> adviceDTOs = new List<AdviceDTO>();
                foreach (var item in users)
                {
                    AdviceDTO adviceDTO = new AdviceDTO()
                    {
                        Id = item.Id,
                        Content = item.Content,
                        CreateDateTime = item.CreateDateTime,
                        UserId = item.UserId,
                        UserName = item.User.UserName
                    };
                    adviceDTOs.Add(adviceDTO);
                }
                return adviceDTOs.ToArray();
            }
        }
        /// <summary>
        /// 获取指定用户id的所有Advice
        /// </summary>
        /// <param name="t_userId"></param>
        /// <returns></returns>
        public AdviceDTO[] GetAllAdviceByUserId(long t_userId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<AdviceEntity> bs = new BaseService<AdviceEntity>(ctx);
                var users = bs
                    .GetAll()
                    .Include(e => e.User)
                    .Where(e => e.UserId == t_userId)
                    .AsNoTracking()
                    .ToList();
                List<AdviceDTO> adviceDTOs = new List<AdviceDTO>();
                foreach (var item in users)
                {
                    AdviceDTO adviceDTO = new AdviceDTO()
                    {
                        Id = item.Id,
                        Content = item.Content,
                        CreateDateTime = item.CreateDateTime,
                        UserId = item.UserId,
                        UserName = item.User.UserName
                    };
                    adviceDTOs.Add(adviceDTO);
                }
                return adviceDTOs.ToArray();
            }
        }
        /// <summary>
        /// 新增Advice
        /// </summary>
        /// <param name="t_Advice"></param>
        /// <returns></returns>
        public long InsertAdvice(AdviceDTO t_Advice)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                var user = bs.GetById(t_Advice.UserId);
                AdviceEntity adviceEntity = new AdviceEntity()
                {
                    UserId = t_Advice.UserId,
                    Content = t_Advice.Content,
                    User = user
                };
                ctx.Advice.Add(adviceEntity);
                ctx.SaveChanges();
                return adviceEntity.Id;
            }

        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="t_adviceId"></param>
        /// <returns></returns>
        public AdviceDTO SelectAdviceByID(long t_adviceId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<AdviceEntity> bs = new BaseService<AdviceEntity>(ctx);
                var advice = bs.GetById(t_adviceId);
                AdviceDTO adviceDTO = new AdviceDTO()
                {
                    Id = advice.Id,
                    Content = advice.Content,
                    CreateDateTime = advice.CreateDateTime,
                    UserId = advice.UserId,
                    UserName = advice.User.UserName
                };
                return adviceDTO;
            }
        }
    }
}
