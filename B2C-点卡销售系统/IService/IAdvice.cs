using System;
using System.Collections.Generic;
using System.Text;
using B2C.DTO;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
    public interface IAdvice: IServiceSupport
    {
        AdviceDTO SelectAdviceByID(long t_adviceId);

        AdviceDTO[] GetAllAdvice();

        AdviceDTO[] GetAllAdviceByUserId(long t_userId);
        long InsertAdvice(AdviceDTO t_Advice);

        void DeleteAdvice(long t_adviceId);
    }
}
