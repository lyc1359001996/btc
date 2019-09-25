using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class ShophistoryDTO:BaseDTO
    {
        public long CardId { get; set; }//卡片Id
        public long UserId { get; set; }//用户Id
        public string CardName { get; set; }//卡片名
        public string UserName { get; set; }//用户名
    }
}
