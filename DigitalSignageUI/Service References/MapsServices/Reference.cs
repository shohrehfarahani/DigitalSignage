﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalSignageUI.MapsServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MapsInfoWTO", Namespace="http://schemas.datacontract.org/2004/07/DigitalServices.Model")]
    [System.SerializableAttribute()]
    public partial class MapsInfoWTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int floorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int typeField;
        
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
        public int floor {
            get {
                return this.floorField;
            }
            set {
                if ((this.floorField.Equals(value) != true)) {
                    this.floorField = value;
                    this.RaisePropertyChanged("floor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PagingInfo", Namespace="http://schemas.datacontract.org/2004/07/DigitalServices.Model")]
    [System.SerializableAttribute()]
    public partial class PagingInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.MapsServices.OrderInfo[] orderLstField;
        
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
        public DigitalSignageUI.MapsServices.OrderInfo[] orderLst {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultMessageOfArrayOfMapsInfoWTONurSmnnE", Namespace="http://schemas.datacontract.org/2004/07/Aryaban.Engine.Core.WebService")]
    [System.SerializableAttribute()]
    public partial class ResultMessageOfArrayOfMapsInfoWTONurSmnnE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.MapsServices.Result resultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DigitalSignageUI.MapsServices.MapsInfoWTO[] resultSetField;
        
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
        public DigitalSignageUI.MapsServices.Result result {
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
        public DigitalSignageUI.MapsServices.MapsInfoWTO[] resultSet {
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
        private DigitalSignageUI.MapsServices.Result.state statusField;
        
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
        public DigitalSignageUI.MapsServices.Result.state status {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MapsServices.Imaps")]
    public interface Imaps {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imaps/searchDataOnMaps", ReplyAction="http://tempuri.org/Imaps/searchDataOnMapsResponse")]
        DigitalSignageUI.MapsServices.ResultMessageOfArrayOfMapsInfoWTONurSmnnE searchDataOnMaps(DigitalSignageUI.MapsServices.MapsInfoWTO mapsInfoWTO, DigitalSignageUI.MapsServices.PagingInfo paging);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imaps/searchDataOnMaps", ReplyAction="http://tempuri.org/Imaps/searchDataOnMapsResponse")]
        System.Threading.Tasks.Task<DigitalSignageUI.MapsServices.ResultMessageOfArrayOfMapsInfoWTONurSmnnE> searchDataOnMapsAsync(DigitalSignageUI.MapsServices.MapsInfoWTO mapsInfoWTO, DigitalSignageUI.MapsServices.PagingInfo paging);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ImapsChannel : DigitalSignageUI.MapsServices.Imaps, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImapsClient : System.ServiceModel.ClientBase<DigitalSignageUI.MapsServices.Imaps>, DigitalSignageUI.MapsServices.Imaps {
        
        public ImapsClient() {
        }
        
        public ImapsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImapsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImapsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImapsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DigitalSignageUI.MapsServices.ResultMessageOfArrayOfMapsInfoWTONurSmnnE searchDataOnMaps(DigitalSignageUI.MapsServices.MapsInfoWTO mapsInfoWTO, DigitalSignageUI.MapsServices.PagingInfo paging) {
            return base.Channel.searchDataOnMaps(mapsInfoWTO, paging);
        }
        
        public System.Threading.Tasks.Task<DigitalSignageUI.MapsServices.ResultMessageOfArrayOfMapsInfoWTONurSmnnE> searchDataOnMapsAsync(DigitalSignageUI.MapsServices.MapsInfoWTO mapsInfoWTO, DigitalSignageUI.MapsServices.PagingInfo paging) {
            return base.Channel.searchDataOnMapsAsync(mapsInfoWTO, paging);
        }
    }
}
