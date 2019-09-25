///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

using B2C.Model;


namespace B2C.IDAL
{
	///
	//SysFun
	///
	public interface ISysFun
	{
		SysFunEntity SelectSysFunByID(int t_nodeId);
		
		IList<SysFunEntity> GetAllSysFun();
				
	
		int InsertSysFun(SysFunEntity t_SysFun);
		
		int UpdateSysFun(SysFunEntity t_SysFun);
		
		int DeleteSysFun(int t_nodeId);
	}
}


