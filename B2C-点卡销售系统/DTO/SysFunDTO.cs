using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class SysFunDTO:BaseDTO
    {
        public string DisplayName { get; set; } //菜单名称
        public string NodeURL { get; set; } //菜单连接地址
        public string DisplayOrder { get; set; } //菜单显示顺序
        public string ParentNodeId { get; set; } //父节点id
        public long[] RoleIds { get; set; }
    }
}
