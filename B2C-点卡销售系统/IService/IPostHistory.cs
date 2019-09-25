///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
	///
	//PostHistory
	///
	public interface IPostHistory: IServiceSupport
    {
		PostHistoryEntity SelectPostHistoryByID(int t_postHistoryId);
		
		IList<PostHistoryEntity> GetAllPostHistory();
				
		IList<PostHistoryEntity> GetAllPostHistoryByUserId(string t_userId);
		
		IList<PostHistoryEntity> GetAllPostHistoryByApproveState(int t_approveState);
		
	
		int InsertPostHistory(PostHistoryEntity t_PostHistory);
		
		int UpdatePostHistory(PostHistoryEntity t_PostHistory);
		
		int DeletePostHistory(int t_postHistoryId);
	}
}


