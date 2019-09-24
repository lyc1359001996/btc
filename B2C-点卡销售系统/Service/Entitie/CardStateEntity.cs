using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class CardStateEntity:BaseEntity
    {
        public string CardStateName { get; set; }//卡片描述
        public int CardState { get; set; }//卡片状态
    }
}
