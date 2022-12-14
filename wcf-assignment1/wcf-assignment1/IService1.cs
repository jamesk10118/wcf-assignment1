using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string checkPrimeNum(int n1);
        [OperationContract]
        double checkSumOfDigits(int n1);
        [OperationContract]
        string reverseAString(string s1);
        [OperationContract]
        string printHTMLTags(string tag, string data);
        [OperationContract]
        string sortNums(string sortType, string data);
    }
}
