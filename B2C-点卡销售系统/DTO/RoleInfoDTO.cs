using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class RoleInfoDTO:BaseDTO
    {
        public string RoleName { get; set; } //角色名称
        public string RoleDesc { get; set; } //角色描述
        public float DisCount { get; set; } //会员折扣
        public long[] SysfunIds { get; set; }
    }
}
