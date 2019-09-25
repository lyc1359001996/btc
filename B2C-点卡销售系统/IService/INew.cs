using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
	///
	//New
	///
	public interface INew: IServiceSupport
    {
		NewsDTO SelectNewByID(long t_newsId);

        NewsDTO[] GetAllNew();


        long InsertNew(NewsDTO t_New);

        long UpdateNew(NewsDTO t_New);

        long DeleteNew(long t_newsId);
	}
}


