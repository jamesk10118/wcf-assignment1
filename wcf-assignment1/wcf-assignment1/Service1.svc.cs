using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string checkPrimeNum(int n1)
        {
            string result = "true";

            for (int i = 2; i < n1; i++)
            {
                if ((n1 % i == 0))
                {
                    result = "false";
                }
            }
            return (result);
        }

        public double checkSumOfDigits(int n1)
        {
            int result = 0;
            string num = n1.ToString();
            for(int i=0; i < n1.ToString().Length; i++)
            {
                int currentNum = int.Parse(num[i].ToString());
                result += currentNum;
            }
            return (result);
        }

        public string reverseAString(string s1)
        {
            string reverse = "";

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                reverse += s1[i].ToString();
            }

            return reverse;
        }

        public string printHTMLTags(string tag, string data)
        {
            return "<" + tag + ">" + data + "</" + tag + ">";
        }

        public string sortNums(string sortType, string data)
        {
            List<string> nums = data.Split(',').ToList();
            List<int> listofInts = new List<int>();
            for(int i = 0; i < nums.Count; i++)
            {
                listofInts.Add(int.Parse(nums[i]));
            }
            if(sortType == "ascending")
            {
                listofInts.Sort((x, y) => x.CompareTo(y));
            }
            else
            {
                listofInts.Sort((x, y) => y.CompareTo(x));
            }
            return string.Join(", ", listofInts);
        }


    }
}
