using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B2C.DAL.Service
{
    public class NewService : INew
    {
        /// <summary>
        /// 指定id软删除
        /// </summary>
        /// <param name="t_newsId"></param>
        /// <returns></returns>
        public void DeleteNew(long t_newsId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<NewsEntity> bs = new BaseService<NewsEntity>(ctx);
                bs.MarkDeleted(t_newsId);
            }
        }
        /// <summary>
        /// 获取所有new
        /// </summary>
        /// <returns></returns>
        public NewDTO[] GetAllNew()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<NewsEntity> bs = new BaseService<NewsEntity>(ctx);
                var NewEntitis = bs.GetAll().ToList();
                List<NewDTO> newDTOs = new List<NewDTO>();
                foreach (var item in NewEntitis)
                {
                    NewDTO newDTO = new NewDTO()
                    {
                        Id = item.Id,
                        Content = item.Content,
                        CreateDateTime = item.CreateDateTime,
                        NewsState = item.NewsState,
                        Title = item.Title
                    };
                    newDTOs.Add(newDTO);
                }
                return newDTOs.ToArray();
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t_New"></param>
        /// <returns></returns>
        public long InsertNew(NewDTO t_New)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                NewsEntity newsEntity = new NewsEntity();
                newsEntity.NewsState = t_New.NewsState;
                newsEntity.Title = t_New.Title;
                newsEntity.Content = t_New.Content;
                ctx.News.Add(newsEntity);
                ctx.SaveChanges();
                return newsEntity.Id;
            }
        }
        /// <summary>
        /// 指定id查询new
        /// </summary>
        /// <param name="t_newsId"></param>
        /// <returns></returns>
        public NewDTO SelectNewByID(long t_newsId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<NewsEntity> bs = new BaseService<NewsEntity>(ctx);
                var NewEntitis = bs.GetAll().Where(u => u.Id == t_newsId).SingleOrDefault();
                NewDTO newDTO = new NewDTO()
                {
                    Id = NewEntitis.Id,
                    Content = NewEntitis.Content,
                    CreateDateTime = NewEntitis.CreateDateTime,
                    NewsState = NewEntitis.NewsState,
                    Title = NewEntitis.Title
                };
                return newDTO;
            }
        }
        /// <summary>
        /// 更新new
        /// </summary>
        /// <param name="t_New"></param>
        /// <returns></returns>
        public long UpdateNew(NewDTO t_New)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<NewsEntity> bs = new BaseService<NewsEntity>(ctx);
                var NewEntitis = bs.GetAll().Where(u => u.Id == t_New.Id).SingleOrDefault();
                NewEntitis.NewsState = t_New.NewsState;
                NewEntitis.Title = t_New.Title;
                NewEntitis.Content = t_New.Content;
                ctx.SaveChanges();
                return NewEntitis.Id;
            }
        }
    }
}
