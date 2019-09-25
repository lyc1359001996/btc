using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class PostFailedInfoDTO:BaseDTO
    {
        public long PostHistoryId { get; set; }//汇款历史记录Id
        public long UserId { get; set; }//用户状态Id
        public bool ReadState { get; set; }//消息阅读状态0：未读；1：已读
    }
}
