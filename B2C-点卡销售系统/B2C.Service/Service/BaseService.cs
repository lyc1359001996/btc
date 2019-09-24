using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;
using Service.Entitie;

namespace B2C.Service.Service
{
    class BaseService<T> where T:BaseEntity
    {
        private B2CDbContext ctx;
        public BaseService(B2CDbContext ctx)
        {
            this.ctx = ctx;
        }
        /// <summary>
        /// 获取总数据条数(没有被软删除的数据)
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>().Where(e=>e.IsDelete==false);
        }
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="startIndex">开始位置</param>
        /// <param name="count">获取条数</param>
        /// <returns></returns>
        public IQueryable<T> GetPageDate(int startIndex,int count)
        {
            return GetAll().OrderBy(e => e.CreateDateTime).Skip(startIndex).Take(count);
        }
        /// <summary>
        /// 通过id查找数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(long id)
        {
            return GetAll().Where(e => e.Id == id).SingleOrDefault();
        }
        /// <summary>
        /// 软删除
        /// </summary>
        /// <param name="id"></param>
        public void MarkDeleted(long id)
        {
            GetById(id).IsDelete = true;
            ctx.SaveChanges();
        }
    }
}
