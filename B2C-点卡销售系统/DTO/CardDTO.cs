using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class CardDTO:BaseDTO
    {
        public long CardNo { get; set; }//卡片序号
        public string CardPassword { get; set; }//卡片密码
        public string CardDesc { get; set; }//卡片描述
        public long CardTypeId { get; set; }//卡片类型Id
        public long CardStateId { get; set; }//卡片状态Id
        public string CardTypeName { get; set; }//卡片类型名
        public string CardStateName { get; set; }//卡片状态

    }
}
