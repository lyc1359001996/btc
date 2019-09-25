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
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//PostFailedInfo
	///
	public interface IPostFailedInfo: IServiceSupport
    {
		PostFailedInfoDTO SelectPostFailedInfoByID(long t_postFailedInfoId);

        PostFailedInfoDTO[] GetAllPostFailedInfo();

        PostFailedInfoDTO[] GetAllPostFailedInfoByUserId(long t_userId);

        PostFailedInfoDTO[] GetAllPostFailedInfoByPostHistoryId(long t_postHistoryId);


        long InsertPostFailedInfo(PostFailedInfoDTO t_PostFailedInfo);

        long UpdatePostFailedInfo(PostFailedInfoDTO t_PostFailedInfo);
		
		void DeletePostFailedInfo(long t_postFailedInfoId);
	}
}


