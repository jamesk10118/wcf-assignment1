﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcf_assignment1_client.aaa {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="aaa.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkPrimeNum", ReplyAction="http://tempuri.org/IService1/checkPrimeNumResponse")]
        string checkPrimeNum(int n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkPrimeNum", ReplyAction="http://tempuri.org/IService1/checkPrimeNumResponse")]
        System.Threading.Tasks.Task<string> checkPrimeNumAsync(int n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkSumOfDigits", ReplyAction="http://tempuri.org/IService1/checkSumOfDigitsResponse")]
        double checkSumOfDigits(int n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkSumOfDigits", ReplyAction="http://tempuri.org/IService1/checkSumOfDigitsResponse")]
        System.Threading.Tasks.Task<double> checkSumOfDigitsAsync(int n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverseAString", ReplyAction="http://tempuri.org/IService1/reverseAStringResponse")]
        string reverseAString(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverseAString", ReplyAction="http://tempuri.org/IService1/reverseAStringResponse")]
        System.Threading.Tasks.Task<string> reverseAStringAsync(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/printHTMLTags", ReplyAction="http://tempuri.org/IService1/printHTMLTagsResponse")]
        string printHTMLTags(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/printHTMLTags", ReplyAction="http://tempuri.org/IService1/printHTMLTagsResponse")]
        System.Threading.Tasks.Task<string> printHTMLTagsAsync(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortNums", ReplyAction="http://tempuri.org/IService1/sortNumsResponse")]
        string sortNums(string sortType, int[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortNums", ReplyAction="http://tempuri.org/IService1/sortNumsResponse")]
        System.Threading.Tasks.Task<string> sortNumsAsync(string sortType, int[] data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : wcf_assignment1_client.aaa.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<wcf_assignment1_client.aaa.IService1>, wcf_assignment1_client.aaa.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string checkPrimeNum(int n1) {
            return base.Channel.checkPrimeNum(n1);
        }
        
        public System.Threading.Tasks.Task<string> checkPrimeNumAsync(int n1) {
            return base.Channel.checkPrimeNumAsync(n1);
        }
        
        public double checkSumOfDigits(int n1) {
            return base.Channel.checkSumOfDigits(n1);
        }
        
        public System.Threading.Tasks.Task<double> checkSumOfDigitsAsync(int n1) {
            return base.Channel.checkSumOfDigitsAsync(n1);
        }
        
        public string reverseAString(string s1) {
            return base.Channel.reverseAString(s1);
        }
        
        public System.Threading.Tasks.Task<string> reverseAStringAsync(string s1) {
            return base.Channel.reverseAStringAsync(s1);
        }
        
        public string printHTMLTags(string tag, string data) {
            return base.Channel.printHTMLTags(tag, data);
        }
        
        public System.Threading.Tasks.Task<string> printHTMLTagsAsync(string tag, string data) {
            return base.Channel.printHTMLTagsAsync(tag, data);
        }
        
        public string sortNums(string sortType, int[] data) {
            return base.Channel.sortNums(sortType, data);
        }
        
        public System.Threading.Tasks.Task<string> sortNumsAsync(string sortType, int[] data) {
            return base.Channel.sortNumsAsync(sortType, data);
        }
    }
}