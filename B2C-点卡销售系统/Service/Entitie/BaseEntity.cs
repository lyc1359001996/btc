using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class BaseEntity
    {
        public long Id { get; set; }//表ID
        public DateTime CreateDateTime { get; set; } = DateTime.Now;//创建时间
        public bool IsDelete { get; set; } = false;//软删除
    }
}
