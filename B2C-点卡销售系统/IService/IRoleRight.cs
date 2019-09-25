///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;

namespace B2C.IDAL
{
	///
	//RoleRight
	///
	public interface IRoleRight: IServiceSupport
    {
		RoleRightEntity SelectRoleRightByID(int t_roleRightId);
		
		IList<RoleRightEntity> GetAllRoleRight();
				
		IList<RoleRightEntity> GetAllRoleRightByRoleId(int t_roleId);
		
		IList<RoleRightEntity> GetAllRoleRightByNodeId(int t_nodeId);
		
	
		int InsertRoleRight(RoleRightEntity t_RoleRight);
		
		int UpdateRoleRight(RoleRightEntity t_RoleRight);
		
		int DeleteRoleRight(int t_roleRightId);
	}
}


