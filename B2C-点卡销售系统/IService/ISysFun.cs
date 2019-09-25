///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System;
using Service.Entitie;
using B2C.IService;
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//SysFun
	///
	public interface ISysFun: IServiceSupport
    {
		SysFunDTO SelectSysFunByID(long t_nodeId);
		
		SysFunDTO[] GetAllSysFun();
				
	
		long InsertSysFun(SysFunDTO t_SysFun);

        long UpdateSysFun(SysFunDTO t_SysFun);
		
		void DeleteSysFun(long t_nodeId);
	}
}


