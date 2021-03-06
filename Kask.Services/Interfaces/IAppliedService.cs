﻿using Kask.Services.DAO;

using Kask.Services.Exceptions;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Kask.Services.Interfaces
{
    [ServiceContract]
    public interface IAppliedService
    {
        [OperationContract]
        [FaultContract(typeof(KaskServiceException))]
        AppliedDAO GetAppliedByID(int id);

        [OperationContract]
        [FaultContract(typeof(KaskServiceException))]
        IList<AppliedDAO> GetApplieds();

        [OperationContract]
        [FaultContract(typeof(KaskServiceException))]
        [WebGet(UriTemplate = "Applied?first={first}&last={last}&ssn={ssn}")]
        IList<AppliedDAO> GetAppliedsByName(string first, string last, string ssn);

        [OperationContract]
        [FaultContract(typeof(KaskServiceException))]
        bool CreateApplied(AppliedDAO a);

        [OperationContract]
        [FaultContract(typeof(KaskServiceException))]
        bool UpdateApplied(AppliedDAO newApp);

        [OperationContract]
        [FaultContract(typeof(KaskServiceException))]
        bool DeleteApplied(int id);
    }
}
