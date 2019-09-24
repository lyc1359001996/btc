using B2C.DTO.DTO;
using B2C.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.IDAL
{
    public interface IApproveState:IServiceSupport
    {
        ApproveStateDTO SelectApproveStateByID(long t_approveStateId);

        ApproveStateDTO[] GetAllApproveState();

        long InsertApproveState(ApproveStateDTO t_ApproveState);

        long UpdateApproveState(ApproveStateDTO t_ApproveState);

        void DeleteApproveState(long t_approveStateId);
    }
}
