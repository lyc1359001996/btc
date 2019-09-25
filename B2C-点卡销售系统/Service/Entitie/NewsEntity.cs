using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class NewsDTO:BaseEntity
    {
        public string Title { get; set; }//公告标题
        public string Content { get; set; }//公告内容
        public bool NewsState { get; set; }//消息发布状态1：已发布；0：未发布
    }
}
