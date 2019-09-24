using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class AdviceEntity:BaseEntity
    { 
        public virtual UserInfoEntity User { get; set; }//用户对象
        public long UserId { get; set; }//用户Id
        public string Content { get; set; }//投诉或建议内容
    }
}
