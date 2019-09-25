using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class UserStateDTO:BaseDTO
    {
        public string UserStateName { get; set; } //用户状态名
        public bool UserState { get; set; } //用户状态
    }
}
