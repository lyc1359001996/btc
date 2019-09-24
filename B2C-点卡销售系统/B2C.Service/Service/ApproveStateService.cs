using B2C.DTO.DTO;
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
    public class ApproveStateService : IApproveState
    {
        /// <summary>
        /// 指定Id软删除
        /// </summary>
        /// <param name="t_approveStateId"></param>
        /// <returns></returns>
        public void DeleteApproveState(long t_approveStateId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ApproveStateEntity> bs = new BaseService<ApproveStateEntity>(ctx);
                bs.MarkDeleted(t_approveStateId);
            }
        }
        /// <summary>
        /// 获取所有ApproveState
        /// </summary>
        /// <returns></returns>
        public ApproveStateDTO[] GetAllApproveState()
        {
            List<ApproveStateDTO> approveStateDTOs = new List<ApproveStateDTO>();
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ApproveStateEntity> bs = new BaseService<ApproveStateEntity>(ctx);
                var States = bs.GetAll().ToList();
                foreach (var item in States)
                {
                    ApproveStateDTO approveStateDTO = new ApproveStateDTO()
                    {
                        ApproveStateName = item.ApproveStateName
                    };
                    approveStateDTOs.Add(approveStateDTO);
                }
                return approveStateDTOs.ToArray();
            }

        }
        /// <summary>
        /// 新增ApproveState
        /// </summary>
        /// <param name="t_ApproveState"></param>
        /// <returns></returns>
        public long InsertApproveState(ApproveStateDTO t_ApproveState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                
            }
            return 0;
        }
        /// <summary>
        /// 指定Id查询ApproveState
        /// </summary>
        /// <param name="t_approveStateId"></param>
        /// <returns></returns>
        public ApproveStateDTO SelectApproveStateByID(long t_approveStateId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 更新ApproveState
        /// </summary>
        /// <param name="t_ApproveState"></param>
        /// <returns></returns>
        public long UpdateApproveState(ApproveStateDTO t_ApproveState)
        {
            throw new NotImplementedException();
        }
    }
}
