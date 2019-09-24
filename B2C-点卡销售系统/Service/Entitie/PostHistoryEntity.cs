using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class PostHistoryEntity:BaseEntity
    {
        public virtual ApproveStateEntity ApproveState { get; set; }//审核状态对象
        public virtual UserInfoEntity User { get; set; }//用户对象

        public long ApproveStateId { get; set; }//审核状态Id
        public long UserId { get; set; }//用户状态Id
        public string Bank { get; set; }//汇款银行
        public float Money { get; set; }//汇款金额
        public string PostDesc { get; set; }//备注
    }
}
