﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalSignageUI.StoresServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StoresInfoWTO", Namespace="http://schemas.datacontract.org/2004/07/DigitalServices.Model")]
    [System.SerializableAttribute()]
    public partial class StoresInfoWTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int category_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string endWorkTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int map_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phone1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phone2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string startWorkTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int unitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string workingDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int xField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yField;
        
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
        public int category_id {
            get {
                return this.category_idField;
            }
            set {
                if ((this.category_idField.Equals(value) != true)) {
                    this.category_idField = value;
                    this.RaisePropertyChanged("category_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string endWorkTime {
            get {
                return this.endWorkTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.endWorkTimeField, value) != true)) {
                    this.endWorkTimeField = value;
                    this.RaisePropertyChanged("endWorkTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int map_id {
            get {
                return this.map_idField;
            }
            set {
                if ((this.map_idField.Equals(value) != true)) {
                    this.map_idField = value;
                    this.RaisePropertyChanged("map_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone1 {
            get {
                return this.phone1Field;
            }
            set {
                if ((object.ReferenceEquals(this.phone1Field, value) != true)) {
                    this.phone1Field = value;
                    this.RaisePropertyChanged("phone1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone2 {
            get {
                return this.phone2Field;
            }
            set {
                if ((object.ReferenceEquals(this.phone2Field, value) != true)) {
                    this.phone2Field = value;
                    this.RaisePropertyChanged("phone2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string startWorkTime {
            get {
                return this.startWorkTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.startWorkTimeField, value) != true)) {
                    this.startWorkTimeField = value;
                    this.RaisePropertyChanged("startWorkTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int unit {
            get {
                return this.unitField;
            }
            set {
                if ((this.unitField.Equals(value) != true)) {
                    this.unitField = value;
                    this.RaisePropertyChanged("unit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string workingDay {
            get {
                return this.workingDayField;
            }
            set {
                if ((object.ReferenceEquals(this.workingDayField, value) != true)) {
                    this.workingDayField = value;
                    this.RaisePropertyChanged("workingDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int x {
            get {
                return this.xField;
            }
            set {
                if ((this.xField.Equals(value) != true)) {
                    this.xField = value;
                    this.RaisePropertyChanged("x");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int y {
            get {
                return this.yField;
            }
            set {
                if ((this.yField.Equals(value) != true)) {
                    this.yField = value;
                    this.RaisePropertyChanged("y");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultMessageOfstring", Namespace="http://schemas.datacontract.org/2004/07/Aryaban.Engine.Core.WebService")]
    [System.SerializableAttribute()]
    public partial class ResultMessageOfstring : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.StoresServices.Result resultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string resultSetField;
        
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
        public DigitalSignageUI.StoresServices.Result result {
            get {
                return this.resultField;
            }
            set {
                if ((object.ReferenceEquals(this.resultField, value) != true)) {
                    this.resultField = value;
                    this.RaisePropertyChanged("result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string resultSet {
            get {
                return this.resultSetField;
            }
            set {
                if ((object.ReferenceEquals(this.resultSetField, value) != true)) {
                    this.resultSetField = value;
                    this.RaisePropertyChanged("resultSet");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/Aryaban.Engine.Core.WebService")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string callbackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string redirectUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.StoresServices.Result.state statusField;
        
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
        public string callback {
            get {
                return this.callbackField;
            }
            set {
                if ((object.ReferenceEquals(this.callbackField, value) != true)) {
                    this.callbackField = value;
                    this.RaisePropertyChanged("callback");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                if ((object.ReferenceEquals(this.messageField, value) != true)) {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string redirectUrl {
            get {
                return this.redirectUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.redirectUrlField, value) != true)) {
                    this.redirectUrlField = value;
                    this.RaisePropertyChanged("redirectUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DigitalSignageUI.StoresServices.Result.state status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="Result.state", Namespace="http://schemas.datacontract.org/2004/07/Aryaban.Engine.Core.WebService")]
        public enum state : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            error = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            success = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            warning = 2,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PagingInfo", Namespace="http://schemas.datacontract.org/2004/07/DigitalServices.Model")]
    [System.SerializableAttribute()]
    public partial class PagingInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.StoresServices.OrderInfo[] orderLstField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageSizeField;
        
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
        public DigitalSignageUI.StoresServices.OrderInfo[] orderLst {
            get {
                return this.orderLstField;
            }
            set {
                if ((object.ReferenceEquals(this.orderLstField, value) != true)) {
                    this.orderLstField = value;
                    this.RaisePropertyChanged("orderLst");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pageNumber {
            get {
                return this.pageNumberField;
            }
            set {
                if ((this.pageNumberField.Equals(value) != true)) {
                    this.pageNumberField = value;
                    this.RaisePropertyChanged("pageNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                if ((this.pageSizeField.Equals(value) != true)) {
                    this.pageSizeField = value;
                    this.RaisePropertyChanged("pageSize");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderInfo", Namespace="http://schemas.datacontract.org/2004/07/DigitalServices.Model")]
    [System.SerializableAttribute()]
    public partial class OrderInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string orderNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sortTypeField;
        
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
        public string orderName {
            get {
                return this.orderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.orderNameField, value) != true)) {
                    this.orderNameField = value;
                    this.RaisePropertyChanged("orderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sortType {
            get {
                return this.sortTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.sortTypeField, value) != true)) {
                    this.sortTypeField = value;
                    this.RaisePropertyChanged("sortType");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultMessageOfArrayOfStoresInfoWTONurSmnnE", Namespace="http://schemas.datacontract.org/2004/07/Aryaban.Engine.Core.WebService")]
    [System.SerializableAttribute()]
    public partial class ResultMessageOfArrayOfStoresInfoWTONurSmnnE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.StoresServices.Result resultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.StoresServices.StoresInfoWTO[] resultSetField;
        
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
        public DigitalSignageUI.StoresServices.Result result {
            get {
                return this.resultField;
            }
            set {
                if ((object.ReferenceEquals(this.resultField, value) != true)) {
                    this.resultField = value;
                    this.RaisePropertyChanged("result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DigitalSignageUI.StoresServices.StoresInfoWTO[] resultSet {
            get {
                return this.resultSetField;
            }
            set {
                if ((object.ReferenceEquals(this.resultSetField, value) != true)) {
                    this.resultSetField = value;
                    this.RaisePropertyChanged("resultSet");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StoresServices.Istores")]
    public interface Istores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/addStore", ReplyAction="http://tempuri.org/Istores/addStoreResponse")]
        DigitalSignageUI.StoresServices.ResultMessageOfstring addStore(DigitalSignageUI.StoresServices.StoresInfoWTO stores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/addStore", ReplyAction="http://tempuri.org/Istores/addStoreResponse")]
        System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfstring> addStoreAsync(DigitalSignageUI.StoresServices.StoresInfoWTO stores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/editStore", ReplyAction="http://tempuri.org/Istores/editStoreResponse")]
        DigitalSignageUI.StoresServices.ResultMessageOfstring editStore(DigitalSignageUI.StoresServices.StoresInfoWTO stores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/editStore", ReplyAction="http://tempuri.org/Istores/editStoreResponse")]
        System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfstring> editStoreAsync(DigitalSignageUI.StoresServices.StoresInfoWTO stores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/deleteStore", ReplyAction="http://tempuri.org/Istores/deleteStoreResponse")]
        DigitalSignageUI.StoresServices.ResultMessageOfstring deleteStore(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/deleteStore", ReplyAction="http://tempuri.org/Istores/deleteStoreResponse")]
        System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfstring> deleteStoreAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/searchDataOnStores", ReplyAction="http://tempuri.org/Istores/searchDataOnStoresResponse")]
        DigitalSignageUI.StoresServices.ResultMessageOfArrayOfStoresInfoWTONurSmnnE searchDataOnStores(DigitalSignageUI.StoresServices.StoresInfoWTO storesInfoWTO, DigitalSignageUI.StoresServices.PagingInfo paging);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istores/searchDataOnStores", ReplyAction="http://tempuri.org/Istores/searchDataOnStoresResponse")]
        System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfArrayOfStoresInfoWTONurSmnnE> searchDataOnStoresAsync(DigitalSignageUI.StoresServices.StoresInfoWTO storesInfoWTO, DigitalSignageUI.StoresServices.PagingInfo paging);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IstoresChannel : DigitalSignageUI.StoresServices.Istores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IstoresClient : System.ServiceModel.ClientBase<DigitalSignageUI.StoresServices.Istores>, DigitalSignageUI.StoresServices.Istores {
        
        public IstoresClient() {
        }
        
        public IstoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IstoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IstoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IstoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DigitalSignageUI.StoresServices.ResultMessageOfstring addStore(DigitalSignageUI.StoresServices.StoresInfoWTO stores) {
            return base.Channel.addStore(stores);
        }
        
        public System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfstring> addStoreAsync(DigitalSignageUI.StoresServices.StoresInfoWTO stores) {
            return base.Channel.addStoreAsync(stores);
        }
        
        public DigitalSignageUI.StoresServices.ResultMessageOfstring editStore(DigitalSignageUI.StoresServices.StoresInfoWTO stores) {
            return base.Channel.editStore(stores);
        }
        
        public System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfstring> editStoreAsync(DigitalSignageUI.StoresServices.StoresInfoWTO stores) {
            return base.Channel.editStoreAsync(stores);
        }
        
        public DigitalSignageUI.StoresServices.ResultMessageOfstring deleteStore(long id) {
            return base.Channel.deleteStore(id);
        }
        
        public System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfstring> deleteStoreAsync(long id) {
            return base.Channel.deleteStoreAsync(id);
        }
        
        public DigitalSignageUI.StoresServices.ResultMessageOfArrayOfStoresInfoWTONurSmnnE searchDataOnStores(DigitalSignageUI.StoresServices.StoresInfoWTO storesInfoWTO, DigitalSignageUI.StoresServices.PagingInfo paging) {
            return base.Channel.searchDataOnStores(storesInfoWTO, paging);
        }
        
        public System.Threading.Tasks.Task<DigitalSignageUI.StoresServices.ResultMessageOfArrayOfStoresInfoWTONurSmnnE> searchDataOnStoresAsync(DigitalSignageUI.StoresServices.StoresInfoWTO storesInfoWTO, DigitalSignageUI.StoresServices.PagingInfo paging) {
            return base.Channel.searchDataOnStoresAsync(storesInfoWTO, paging);
        }
    }
}
