using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class RoleInfoEntity:BaseEntity
    {
        public string RoleName { get; set; } //角色名称
        public string RoleDesc { get; set; } //角色描述
        public float DisCount { get; set; } //会员折扣
        public virtual ICollection<SysFunEntity> SysFuns { get; set; } = new List<SysFunEntity>();
    }
}
