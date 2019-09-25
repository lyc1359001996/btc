using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//RoleInfo
	///
	public interface IRoleInfo: IServiceSupport
    {
		RoleInfoDTO SelectRoleInfoByID(long t_roleId);

        RoleInfoDTO[] GetAllRoleInfo();


        long InsertRoleInfo(RoleInfoDTO t_RoleInfo);

        long UpdateRoleInfo(RoleInfoDTO t_RoleInfo);
		
		void DeleteRoleInfo(long t_roleId);
	}
}


