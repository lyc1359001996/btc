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
	//RoleInfo
	///
	public interface IRoleInfo
	{
		RoleInfoEntity SelectRoleInfoByID(int t_roleId);
		
		IList<RoleInfoEntity> GetAllRoleInfo();
				
	
		int InsertRoleInfo(RoleInfoEntity t_RoleInfo);
		
		int UpdateRoleInfo(RoleInfoEntity t_RoleInfo);
		
		int DeleteRoleInfo(int t_roleId);
	}
}


