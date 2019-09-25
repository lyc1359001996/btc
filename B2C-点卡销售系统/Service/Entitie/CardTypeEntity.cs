using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class CardTypeDTO:BaseEntity
    {
        public string CardTypeName { get; set; }//卡片类型名称
        public int CardPrice { get; set; }//卡片价格
        public string CardImage { get; set; }//对应图片地址
        public virtual ICollection<UserInfoEntity> UserInfos { get; set; } = new List<UserInfoEntity>();
    }
}
