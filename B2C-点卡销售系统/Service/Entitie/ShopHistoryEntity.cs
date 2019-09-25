using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class ShopHistoryEntity:BaseEntity
    {
        public virtual CardEntity Card { get; set; }//卡片对象
        public virtual UserInfoEntity User { get; set; }//用户对象

        public long CardId { get; set; }//卡片Id
        public long UserId { get; set; }//用户Id
    }
}
