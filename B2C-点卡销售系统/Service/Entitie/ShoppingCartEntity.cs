using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class ShoppingCartEntity:BaseEntity
    {
        public int Num { get; set; }//购买数量
        public virtual CardTypeEntity CardType { get; set; }//卡片类型对象
        public virtual UserInfoEntity User { get; set; }//用户对象

        public long CardTypeId { get; set; }//卡片类型Id
        public long UserId { get; set; }//用户状态Id
    }
}
