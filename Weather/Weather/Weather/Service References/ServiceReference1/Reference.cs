﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weather.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/celciustofarenheit", ReplyAction="http://tempuri.org/IService1/celciustofarenheitResponse")]
        double celciustofarenheit(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/celciustofarenheit", ReplyAction="http://tempuri.org/IService1/celciustofarenheitResponse")]
        System.Threading.Tasks.Task<double> celciustofarenheitAsync(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/farenheittocelcius", ReplyAction="http://tempuri.org/IService1/farenheittocelciusResponse")]
        double farenheittocelcius(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/farenheittocelcius", ReplyAction="http://tempuri.org/IService1/farenheittocelciusResponse")]
        System.Threading.Tasks.Task<double> farenheittocelciusAsync(double temp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Weather.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Weather.ServiceReference1.IService1>, Weather.ServiceReference1.IService1 {
        
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
        
        public double celciustofarenheit(double temp) {
            return base.Channel.celciustofarenheit(temp);
        }
        
        public System.Threading.Tasks.Task<double> celciustofarenheitAsync(double temp) {
            return base.Channel.celciustofarenheitAsync(temp);
        }
        
        public double farenheittocelcius(double temp) {
            return base.Channel.farenheittocelcius(temp);
        }
        
        public System.Threading.Tasks.Task<double> farenheittocelciusAsync(double temp) {
            return base.Channel.farenheittocelciusAsync(temp);
        }
    }
}
