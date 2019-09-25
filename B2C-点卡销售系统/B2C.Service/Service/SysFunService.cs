using B2C.DTO;
using B2C.IDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DAL.Service
{
    public class SysFunService : ISysFun
    {
        /// <summary>
        /// 指定id软删除
        /// </summary>
        /// <param name="t_nodeId"></param>
        public void DeleteSysFun(long t_nodeId)
        {
            using (resource)
            {

            }
        }
        /// <summary>
        /// 获取所有SysFun
        /// </summary>
        /// <returns></returns>
        public SysFunDTO[] GetAllSysFun()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t_SysFun"></param>
        /// <returns></returns>
        public long InsertSysFun(SysFunDTO t_SysFun)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 指定id查询SysFun
        /// </summary>
        /// <param name="t_nodeId"></param>
        /// <returns></returns>
        public SysFunDTO SelectSysFunByID(long t_nodeId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t_SysFun"></param>
        /// <returns></returns>
        public long UpdateSysFun(SysFunDTO t_SysFun)
        {
            throw new NotImplementedException();
        }
    }
}
