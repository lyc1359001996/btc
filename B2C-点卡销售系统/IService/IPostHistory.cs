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
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//PostHistory
	///
	public interface IPostHistory: IServiceSupport
    {
		PostHistoryDTO SelectPostHistoryByID(long t_postHistoryId);

        PostHistoryDTO[] GetAllPostHistory();

        PostHistoryDTO[] GetAllPostHistoryByUserId(long t_userId);

        PostHistoryDTO[] GetAllPostHistoryByApproveState(long t_approveState);
		
	
		int InsertPostHistory(PostHistoryDTO t_PostHistory);
		
		int UpdatePostHistory(PostHistoryDTO t_PostHistory);
		
		void DeletePostHistory(long t_postHistoryId);
	}
}


