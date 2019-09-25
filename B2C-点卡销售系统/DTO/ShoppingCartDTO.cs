using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class ShoppingCartDTO:BaseDTO
    {
        public int Num { get; set; }//购买数量

        public long CardTypeId { get; set; }//卡片类型Id
        public long UserId { get; set; }//用户Id
        public string CardTypeName { get; set; }//卡片状态名
        public string UserName { get; set; }//用户名
    }
}
