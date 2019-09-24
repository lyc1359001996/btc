using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class UserStateEntity:BaseEntity
    {
        public string UserStateName { get; set; } //用户状态名
        public bool UserState { get; set; } //用户状态
    }
}
