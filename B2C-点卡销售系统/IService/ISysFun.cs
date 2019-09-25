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

namespace B2C.IDAL
{
	///
	//SysFun
	///
	public interface ISysFun: IServiceSupport
    {
		SysFunEntity SelectSysFunByID(int t_nodeId);
		
		IList<SysFunEntity> GetAllSysFun();
				
	
		int InsertSysFun(SysFunEntity t_SysFun);
		
		int UpdateSysFun(SysFunEntity t_SysFun);
		
		int DeleteSysFun(int t_nodeId);
	}
}


