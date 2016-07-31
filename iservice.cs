using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF_Demo
{
    //this is contract
    //whichever class will implement this interface that class will become a service
    [ServiceContract]
    interface iservice
    {
        [OperationContract]
        bool Login(string userId, string password);

        [OperationContract]
        List<Order> getOrders(string city);
    }
}
