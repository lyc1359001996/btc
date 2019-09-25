using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
	///
	//RoleInfo
	///
	public interface IRoleInfo: IServiceSupport
    {
		RoleInfoEntity SelectRoleInfoByID(int t_roleId);
		
		IList<RoleInfoEntity> GetAllRoleInfo();
				
	
		int InsertRoleInfo(RoleInfoEntity t_RoleInfo);
		
		int UpdateRoleInfo(RoleInfoEntity t_RoleInfo);
		
		int DeleteRoleInfo(int t_roleId);
	}
}


