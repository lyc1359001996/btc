using System.Data;
using System.Collections.Generic;
using System;
using Service.Entitie;
using B2C.IService;
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//UserState
	///
	public interface IUserState: IServiceSupport
    {
        UserStateDTO SelectUserStateByID(long t_userStateId);

        UserStateDTO[] GetAllUserState();


        long InsertUserState(UserStateDTO t_UserState);

        long UpdateUserState(UserStateDTO t_UserState);
		
		void DeleteUserState(long t_userStateId);
	}
}


