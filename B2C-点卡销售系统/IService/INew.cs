using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//New
	///
	public interface INew: IServiceSupport
    {
		NewDTO SelectNewByID(long t_newsId);

        NewDTO[] GetAllNew();


        long InsertNew(NewDTO t_New);

        long UpdateNew(NewDTO t_New);

        void DeleteNew(long t_newsId);
	}
}


