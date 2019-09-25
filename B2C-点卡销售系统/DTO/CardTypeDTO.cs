using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class CardTypeDTO:BaseDTO
    {
        public string CardTypeName { get; set; }//卡片类型名称
        public int CardPrice { get; set; }//卡片价格
        public string CardImage { get; set; }//对应图片地址
        public long[] UserInfoIdS { get; set; }
    }
}
