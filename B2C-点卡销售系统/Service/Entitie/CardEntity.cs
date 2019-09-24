using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class CardEntity:BaseEntity
    {
        public long CardNo { get; set; }//卡片序号
        public string CardPassword { get; set; }//卡片密码
        public string CardDesc { get; set; }//卡片描述
        public virtual CardTypeEntity CardType { get; set; }//卡片类型对象
        public virtual CardStateEntity CardState { get; set; }//卡片状态对象

        public long CardTypeId { get; set; }//卡片类型Id
        public long CardStateId { get; set; }//卡片状态Id

    }
}
