using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class AdviceDTO:BaseDTO
    {
        public long UserId { get; set; }//用户Id
        public string Content { get; set; }//投诉或建议内容
        public long UserName { get; set; }//用户名
    }
}
