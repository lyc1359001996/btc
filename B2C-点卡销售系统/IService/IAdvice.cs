using System;
using System.Collections.Generic;
using System.Text;
using B2C.DTO;
using Service.Entitie;

namespace B2C.IDAL
{
    public interface IAdvice:IServiceProvider
    {
        AdviceEntity SelectAdviceByID(int t_adviceId);

        AdviceDTO[] GetAllAdvice();

        AdviceDTO[] GetAllAdviceByUserId(string t_userId);
        long InsertAdvice(AdviceEntity t_Advice);

        void DeleteAdvice(long t_adviceId);
    }
}
