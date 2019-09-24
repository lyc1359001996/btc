using System;
using System.Collections.Generic;
using System.Text;
using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;

namespace B2C.DAL.Service
{
    public class AdviceService : IAdvice
    {
        public void DeleteAdvice(long t_adviceId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<AdviceEntity> bs = new BaseService<AdviceEntity>(ctx);
                bs.MarkDeleted(t_adviceId);
            }
        }

        public AdviceDTO[] GetAllAdvice()
        {
            throw new NotImplementedException();
        }

        public AdviceDTO[] GetAllAdviceByUserId(string t_userId)
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public long InsertAdvice(AdviceEntity t_Advice)
        {
            throw new NotImplementedException();
        }

        public AdviceEntity SelectAdviceByID(int t_adviceId)
        {
            throw new NotImplementedException();
        }
    }
}
