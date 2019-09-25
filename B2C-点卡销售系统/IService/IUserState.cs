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
	//UserState
	///
	public interface IUserState
	{
		UserStateEntity SelectUserStateByID(int t_userStateId);
		
		IList<UserStateEntity> GetAllUserState();
				
	
		int InsertUserState(UserStateEntity t_UserState);
		
		int UpdateUserState(UserStateEntity t_UserState);
		
		int DeleteUserState(int t_userStateId);
	}
}


