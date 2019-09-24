using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class SysFunEntity:BaseEntity
    {
        public string DisplayName { get; set; } //菜单名称
        public string NodeURL { get; set; } //菜单连接地址
        public string DisplayOrder { get; set; } //菜单显示顺序
        public string ParentNodeId { get; set; } //父节点id
        public virtual ICollection<RoleInfoEntity> Roles { get; set; } = new List<RoleInfoEntity>();
    }
}
