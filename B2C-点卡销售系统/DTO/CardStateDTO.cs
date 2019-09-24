using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class CardStateDTO : BaseDTO
    {
        public string CardStateName { get; set; }//卡片描述
        public int CardState { get; set; }//卡片状态
    }
}
