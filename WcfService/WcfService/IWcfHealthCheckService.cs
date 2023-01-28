using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
     [ServiceContract]
    public interface IWcfHealthCheckService
    {

        [OperationContract]
        bool HealthCheck();

        [OperationContract]
        string SayHello(CompositeType composite);

       
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        string name;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       
    }
}
