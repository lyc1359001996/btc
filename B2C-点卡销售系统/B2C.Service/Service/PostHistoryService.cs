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
    public class PostHistoryService : IPostHistory
    {
        public void DeletePostHistory(long t_postHistoryId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostHistoryEntity> bs = new BaseService<PostHistoryEntity>(ctx);
                bs.MarkDeleted(t_postHistoryId);
            }
        }
        private PostHistoryDTO ToDTO(PostHistoryEntity postHistoryEntity)
        {
            PostHistoryDTO postHistoryDTO = new PostHistoryDTO()
            {
                ApproveStateId= postHistoryEntity.ApproveStateId,
                Bank=postHistoryEntity.Bank,
                Id=postHistoryEntity.Id,
                Money=postHistoryEntity.Money,
                PostDesc=postHistoryEntity.PostDesc,
                UserId=postHistoryEntity.UserId
            };
            return postHistoryDTO;
        }
        public PostHistoryDTO[] GetAllPostHistory()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostHistoryEntity> bs = new BaseService<PostHistoryEntity>(ctx);
                return bs.GetAll().Select(e => ToDTO(e)).ToArray();
            }
        }

        public PostHistoryDTO[] GetAllPostHistoryByApproveState(long t_approveState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ApproveStateEntity> approveState = new BaseService<ApproveStateEntity>(ctx);
                if (approveState.GetById(t_approveState) != null)
                {
                    BaseService<PostHistoryEntity> bs = new BaseService<PostHistoryEntity>(ctx);
                    return bs.GetAll().Where(e=>e.ApproveStateId==t_approveState).Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public PostHistoryDTO[] GetAllPostHistoryByUserId(long t_userId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> userInfobs = new BaseService<UserInfoEntity>(ctx);
                if (userInfobs.GetById(t_userId) != null)
                {
                    BaseService<PostHistoryEntity> bs = new BaseService<PostHistoryEntity>(ctx);
                    return bs.GetAll().Where(e => e.UserId == t_userId).Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public long InsertPostHistory(PostHistoryDTO t_PostHistory)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                PostHistoryEntity postHistoryEntity = new PostHistoryEntity()
                {
                    ApproveStateId = t_PostHistory.ApproveStateId,
                    Bank = t_PostHistory.Bank,
                    Money=t_PostHistory.Money,
                    PostDesc=t_PostHistory.PostDesc,
                    UserId=t_PostHistory.UserId
                };
                ctx.PostHistories.Add(postHistoryEntity);
                ctx.SaveChanges();
                return postHistoryEntity.Id;

            }
        }

        public PostHistoryDTO SelectPostHistoryByID(long t_postHistoryId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostHistoryEntity> bs = new BaseService<PostHistoryEntity>(ctx);
                if (bs.GetById(t_postHistoryId) != null)
                {
                    return ToDTO(bs.GetById(t_postHistoryId));
                }
                else
                {
                    return null;
                }
            }
        }

        public long UpdatePostHistory(PostHistoryDTO t_PostHistory)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<PostHistoryEntity> bs = new BaseService<PostHistoryEntity>(ctx);
                if (bs.GetAll().Any(e => e.Id == t_PostHistory.Id))
                {
                    return 0;
                }
                else
                {
                    var postHistoryEntity = bs.GetById(t_PostHistory.Id);
                    postHistoryEntity.PostDesc = t_PostHistory.PostDesc;
                    postHistoryEntity.ApproveStateId = t_PostHistory.ApproveStateId;
                    postHistoryEntity.UserId = t_PostHistory.UserId;
                    postHistoryEntity.Bank = t_PostHistory.Bank;
                    postHistoryEntity.Money = t_PostHistory.Money;
                    ctx.SaveChanges();
                    return postHistoryEntity.Id;
                }
            }
        }
    }
}
