﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="myData", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibraryData")]
    [System.SerializableAttribute()]
    public partial class myData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Igetdata")]
    public interface Igetdata {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/AllData", ReplyAction="http://tempuri.org/Igetdata/AllDataResponse")]
        WindowsFormsClient.ServiceReference1.myData[] AllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/AllData", ReplyAction="http://tempuri.org/Igetdata/AllDataResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.ServiceReference1.myData[]> AllDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/Create", ReplyAction="http://tempuri.org/Igetdata/CreateResponse")]
        void Create(WindowsFormsClient.ServiceReference1.myData d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/Create", ReplyAction="http://tempuri.org/Igetdata/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(WindowsFormsClient.ServiceReference1.myData d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/searchData", ReplyAction="http://tempuri.org/Igetdata/searchDataResponse")]
        WindowsFormsClient.ServiceReference1.myData searchData(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/searchData", ReplyAction="http://tempuri.org/Igetdata/searchDataResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.ServiceReference1.myData> searchDataAsync(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/update", ReplyAction="http://tempuri.org/Igetdata/updateResponse")]
        void update(WindowsFormsClient.ServiceReference1.myData x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igetdata/update", ReplyAction="http://tempuri.org/Igetdata/updateResponse")]
        System.Threading.Tasks.Task updateAsync(WindowsFormsClient.ServiceReference1.myData x);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IgetdataChannel : WindowsFormsClient.ServiceReference1.Igetdata, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IgetdataClient : System.ServiceModel.ClientBase<WindowsFormsClient.ServiceReference1.Igetdata>, WindowsFormsClient.ServiceReference1.Igetdata {
        
        public IgetdataClient() {
        }
        
        public IgetdataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IgetdataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgetdataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgetdataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsClient.ServiceReference1.myData[] AllData() {
            return base.Channel.AllData();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.ServiceReference1.myData[]> AllDataAsync() {
            return base.Channel.AllDataAsync();
        }
        
        public void Create(WindowsFormsClient.ServiceReference1.myData d) {
            base.Channel.Create(d);
        }
        
        public System.Threading.Tasks.Task CreateAsync(WindowsFormsClient.ServiceReference1.myData d) {
            return base.Channel.CreateAsync(d);
        }
        
        public WindowsFormsClient.ServiceReference1.myData searchData(int x) {
            return base.Channel.searchData(x);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.ServiceReference1.myData> searchDataAsync(int x) {
            return base.Channel.searchDataAsync(x);
        }
        
        public void update(WindowsFormsClient.ServiceReference1.myData x) {
            base.Channel.update(x);
        }
        
        public System.Threading.Tasks.Task updateAsync(WindowsFormsClient.ServiceReference1.myData x) {
            return base.Channel.updateAsync(x);
        }
    }
}