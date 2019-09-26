using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace B2C.DAL.Service
{
    public class PostFailedInfoService : IPostFailedInfo
    {
        public void DeletePostFailedInfo(long t_postFailedInfoId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostFailedInfoEntity> bs = new BaseService<PostFailedInfoEntity>(ctx);
                bs.MarkDeleted(t_postFailedInfoId);
            }
        }
        private PostFailedInfoDTO ToDTO(PostFailedInfoEntity postFailedInfoEntity)
        {
            PostFailedInfoDTO postFailedInfoDTO = new PostFailedInfoDTO()
            {
                Id = postFailedInfoEntity.Id,
                PostHistoryId = postFailedInfoEntity.PostHistoryId,
                ReadState = postFailedInfoEntity.ReadState,
                UserId=postFailedInfoEntity.UserId
            };
            return postFailedInfoDTO;
        }
        public PostFailedInfoDTO[] GetAllPostFailedInfo()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostFailedInfoEntity> bs = new BaseService<PostFailedInfoEntity>(ctx);
                return bs.GetAll().Include(e => e.PostHistory).Include(e => e.User).AsNoTracking().ToList().Select(e => ToDTO(e)).ToArray();
            }
        }

        public PostFailedInfoDTO[] GetAllPostFailedInfoByPostHistoryId(long t_postHistoryId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostHistoryEntity> postHistorybs = new BaseService<PostHistoryEntity>(ctx);
                if (postHistorybs.GetById(t_postHistoryId)!=null)
                {
                    BaseService<PostFailedInfoEntity> bs = new BaseService<PostFailedInfoEntity>(ctx);
                    return bs.GetAll().Include(e => e.PostHistory).Include(e => e.User).AsNoTracking().Where(e => e.PostHistoryId == t_postHistoryId).ToList().Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
                
            }
        }

        public PostFailedInfoDTO[] GetAllPostFailedInfoByUserId(long t_userId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> UserInfobs = new BaseService<UserInfoEntity>(ctx);
                if (UserInfobs.GetById(t_userId) != null)
                {
                    BaseService<PostFailedInfoEntity> bs = new BaseService<PostFailedInfoEntity>(ctx);
                    return bs.GetAll().Include(e => e.PostHistory).Include(e => e.User).AsNoTracking().Where(e => e.UserId == t_userId).ToList().Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public long InsertPostFailedInfo(PostFailedInfoDTO t_PostFailedInfo)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                PostFailedInfoEntity postFailedInfoEntity = new PostFailedInfoEntity()
                {
                    PostHistoryId = t_PostFailedInfo.PostHistoryId,
                    ReadState = t_PostFailedInfo.ReadState,
                    UserId = t_PostFailedInfo.UserId
                };
                ctx.PostFailedInfos.Add(postFailedInfoEntity);
                ctx.SaveChanges();
                return postFailedInfoEntity.Id;
                
            }
        }

        public PostFailedInfoDTO SelectPostFailedInfoByID(long t_postFailedInfoId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostFailedInfoEntity> bs = new BaseService<PostFailedInfoEntity>(ctx);
                if (bs.GetById(t_postFailedInfoId) != null)
                {
                    return ToDTO(bs.GetAll().Include(e => e.PostHistory).Include(e => e.User).AsNoTracking().Where(e=>e.Id== t_postFailedInfoId).SingleOrDefault());
                }
                else
                {
                    return null;
                }
            }
        }

        public long UpdatePostFailedInfo(PostFailedInfoDTO t_PostFailedInfo)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostFailedInfoEntity> bs = new BaseService<PostFailedInfoEntity>(ctx);
                if (bs.GetAll().Any(e=>e.Id== t_PostFailedInfo.Id))
                {
                    return 0;
                }
                else
                {
                    var postFailedEntity= bs.GetById(t_PostFailedInfo.Id);
                    postFailedEntity.PostHistoryId = t_PostFailedInfo.PostHistoryId;
                    postFailedEntity.ReadState = t_PostFailedInfo.ReadState;
                    postFailedEntity.UserId = t_PostFailedInfo.UserId;
                    ctx.SaveChanges();
                    return postFailedEntity.Id;
                }
            }
        }
    }
}
