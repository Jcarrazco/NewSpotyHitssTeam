﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteSpotyHitss.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Web.PlaylistServices.CompositeType GetDataUsingDataContract(Web.PlaylistServices.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Web.PlaylistServices.CompositeType> GetDataUsingDataContractAsync(Web.PlaylistServices.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/borrar_playlist", ReplyAction="http://tempuri.org/IService1/borrar_playlistResponse")]
        string borrar_playlist(string lista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/borrar_playlist", ReplyAction="http://tempuri.org/IService1/borrar_playlistResponse")]
        System.Threading.Tasks.Task<string> borrar_playlistAsync(string lista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/crear_playlist", ReplyAction="http://tempuri.org/IService1/crear_playlistResponse")]
        string crear_playlist(string nombre, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/crear_playlist", ReplyAction="http://tempuri.org/IService1/crear_playlistResponse")]
        System.Threading.Tasks.Task<string> crear_playlistAsync(string nombre, string descripcion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebSiteSpotyHitss.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebSiteSpotyHitss.ServiceReference1.IService1>, WebSiteSpotyHitss.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Web.PlaylistServices.CompositeType GetDataUsingDataContract(Web.PlaylistServices.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Web.PlaylistServices.CompositeType> GetDataUsingDataContractAsync(Web.PlaylistServices.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string borrar_playlist(string lista) {
            return base.Channel.borrar_playlist(lista);
        }
        
        public System.Threading.Tasks.Task<string> borrar_playlistAsync(string lista) {
            return base.Channel.borrar_playlistAsync(lista);
        }
        
        public string crear_playlist(string nombre, string descripcion) {
            return base.Channel.crear_playlist(nombre, descripcion);
        }
        
        public System.Threading.Tasks.Task<string> crear_playlistAsync(string nombre, string descripcion) {
            return base.Channel.crear_playlistAsync(nombre, descripcion);
        }
    }
}