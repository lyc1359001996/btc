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
	//PostFailedInfo
	///
	public interface IPostFailedInfo: IServiceSupport
    {
		PostFailedInfoEntity SelectPostFailedInfoByID(int t_postFailedInfoId);
		
		IList<PostFailedInfoEntity> GetAllPostFailedInfo();
				
		IList<PostFailedInfoEntity> GetAllPostFailedInfoByUserId(string t_userId);
		
		IList<PostFailedInfoEntity> GetAllPostFailedInfoByPostHistoryId(int t_postHistoryId);
		
	
		int InsertPostFailedInfo(PostFailedInfoEntity t_PostFailedInfo);
		
		int UpdatePostFailedInfo(PostFailedInfoEntity t_PostFailedInfo);
		
		int DeletePostFailedInfo(int t_postFailedInfoId);
	}
}


