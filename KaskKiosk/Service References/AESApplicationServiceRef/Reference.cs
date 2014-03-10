﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaskKiosk.AESApplicationServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ApplicationDAO", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.DAO")]
    [System.SerializableAttribute()]
    public partial class ApplicationDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplicationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> AvailableForDaysField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> AvailableForEveningsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> AvailableForWeekendsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> FridayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> FridayToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> FullTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> MondayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> MondayToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryExpectationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> SaturdayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> SaturdayToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> SundayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> SundayToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> ThursdayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> ThursdayToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> TuesdayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> TuesdayToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> WednesdayFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> WednesdayToField;
        
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
        public int ApplicationID {
            get {
                return this.ApplicationIDField;
            }
            set {
                if ((this.ApplicationIDField.Equals(value) != true)) {
                    this.ApplicationIDField = value;
                    this.RaisePropertyChanged("ApplicationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationStatus {
            get {
                return this.ApplicationStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationStatusField, value) != true)) {
                    this.ApplicationStatusField = value;
                    this.RaisePropertyChanged("ApplicationStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> AvailableForDays {
            get {
                return this.AvailableForDaysField;
            }
            set {
                if ((this.AvailableForDaysField.Equals(value) != true)) {
                    this.AvailableForDaysField = value;
                    this.RaisePropertyChanged("AvailableForDays");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> AvailableForEvenings {
            get {
                return this.AvailableForEveningsField;
            }
            set {
                if ((this.AvailableForEveningsField.Equals(value) != true)) {
                    this.AvailableForEveningsField = value;
                    this.RaisePropertyChanged("AvailableForEvenings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> AvailableForWeekends {
            get {
                return this.AvailableForWeekendsField;
            }
            set {
                if ((this.AvailableForWeekendsField.Equals(value) != true)) {
                    this.AvailableForWeekendsField = value;
                    this.RaisePropertyChanged("AvailableForWeekends");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> FridayFrom {
            get {
                return this.FridayFromField;
            }
            set {
                if ((this.FridayFromField.Equals(value) != true)) {
                    this.FridayFromField = value;
                    this.RaisePropertyChanged("FridayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> FridayTo {
            get {
                return this.FridayToField;
            }
            set {
                if ((this.FridayToField.Equals(value) != true)) {
                    this.FridayToField = value;
                    this.RaisePropertyChanged("FridayTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> FullTime {
            get {
                return this.FullTimeField;
            }
            set {
                if ((this.FullTimeField.Equals(value) != true)) {
                    this.FullTimeField = value;
                    this.RaisePropertyChanged("FullTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> MondayFrom {
            get {
                return this.MondayFromField;
            }
            set {
                if ((this.MondayFromField.Equals(value) != true)) {
                    this.MondayFromField = value;
                    this.RaisePropertyChanged("MondayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> MondayTo {
            get {
                return this.MondayToField;
            }
            set {
                if ((this.MondayToField.Equals(value) != true)) {
                    this.MondayToField = value;
                    this.RaisePropertyChanged("MondayTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalaryExpectation {
            get {
                return this.SalaryExpectationField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryExpectationField, value) != true)) {
                    this.SalaryExpectationField = value;
                    this.RaisePropertyChanged("SalaryExpectation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> SaturdayFrom {
            get {
                return this.SaturdayFromField;
            }
            set {
                if ((this.SaturdayFromField.Equals(value) != true)) {
                    this.SaturdayFromField = value;
                    this.RaisePropertyChanged("SaturdayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> SaturdayTo {
            get {
                return this.SaturdayToField;
            }
            set {
                if ((this.SaturdayToField.Equals(value) != true)) {
                    this.SaturdayToField = value;
                    this.RaisePropertyChanged("SaturdayTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> SundayFrom {
            get {
                return this.SundayFromField;
            }
            set {
                if ((this.SundayFromField.Equals(value) != true)) {
                    this.SundayFromField = value;
                    this.RaisePropertyChanged("SundayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> SundayTo {
            get {
                return this.SundayToField;
            }
            set {
                if ((this.SundayToField.Equals(value) != true)) {
                    this.SundayToField = value;
                    this.RaisePropertyChanged("SundayTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> ThursdayFrom {
            get {
                return this.ThursdayFromField;
            }
            set {
                if ((this.ThursdayFromField.Equals(value) != true)) {
                    this.ThursdayFromField = value;
                    this.RaisePropertyChanged("ThursdayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> ThursdayTo {
            get {
                return this.ThursdayToField;
            }
            set {
                if ((this.ThursdayToField.Equals(value) != true)) {
                    this.ThursdayToField = value;
                    this.RaisePropertyChanged("ThursdayTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> TuesdayFrom {
            get {
                return this.TuesdayFromField;
            }
            set {
                if ((this.TuesdayFromField.Equals(value) != true)) {
                    this.TuesdayFromField = value;
                    this.RaisePropertyChanged("TuesdayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> TuesdayTo {
            get {
                return this.TuesdayToField;
            }
            set {
                if ((this.TuesdayToField.Equals(value) != true)) {
                    this.TuesdayToField = value;
                    this.RaisePropertyChanged("TuesdayTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> WednesdayFrom {
            get {
                return this.WednesdayFromField;
            }
            set {
                if ((this.WednesdayFromField.Equals(value) != true)) {
                    this.WednesdayFromField = value;
                    this.RaisePropertyChanged("WednesdayFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> WednesdayTo {
            get {
                return this.WednesdayToField;
            }
            set {
                if ((this.WednesdayToField.Equals(value) != true)) {
                    this.WednesdayToField = value;
                    this.RaisePropertyChanged("WednesdayTo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
    [System.SerializableAttribute()]
    public partial class KaskServiceException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AESApplicationServiceRef.IApplicationService")]
    public interface IApplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplicationByID", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationByIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(KaskKiosk.AESApplicationServiceRef.KaskServiceException), Action="http://tempuri.org/IApplicationService/GetApplicationByIDKaskServiceExceptionFaul" +
            "t", Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
        KaskKiosk.AESApplicationServiceRef.ApplicationDAO GetApplicationByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplicationByID", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationByIDResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.ApplicationDAO> GetApplicationByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplicationsByName", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationsByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(KaskKiosk.AESApplicationServiceRef.KaskServiceException), Action="http://tempuri.org/IApplicationService/GetApplicationsByNameKaskServiceExceptionF" +
            "ault", Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
        KaskKiosk.AESApplicationServiceRef.ApplicationDAO[] GetApplicationsByName(string first, string last, string ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplicationsByName", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationsByNameResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.ApplicationDAO[]> GetApplicationsByNameAsync(string first, string last, string ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplications", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(KaskKiosk.AESApplicationServiceRef.KaskServiceException), Action="http://tempuri.org/IApplicationService/GetApplicationsKaskServiceExceptionFault", Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
        KaskKiosk.AESApplicationServiceRef.ApplicationDAO[] GetApplications();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplications", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationsResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.ApplicationDAO[]> GetApplicationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/CreateApplication", ReplyAction="http://tempuri.org/IApplicationService/CreateApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(KaskKiosk.AESApplicationServiceRef.KaskServiceException), Action="http://tempuri.org/IApplicationService/CreateApplicationKaskServiceExceptionFault" +
            "", Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
        bool CreateApplication(KaskKiosk.AESApplicationServiceRef.ApplicationDAO app);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/CreateApplication", ReplyAction="http://tempuri.org/IApplicationService/CreateApplicationResponse")]
        System.Threading.Tasks.Task<bool> CreateApplicationAsync(KaskKiosk.AESApplicationServiceRef.ApplicationDAO app);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/UpdateApplication", ReplyAction="http://tempuri.org/IApplicationService/UpdateApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(KaskKiosk.AESApplicationServiceRef.KaskServiceException), Action="http://tempuri.org/IApplicationService/UpdateApplicationKaskServiceExceptionFault" +
            "", Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
        bool UpdateApplication(KaskKiosk.AESApplicationServiceRef.ApplicationDAO newApp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/UpdateApplication", ReplyAction="http://tempuri.org/IApplicationService/UpdateApplicationResponse")]
        System.Threading.Tasks.Task<bool> UpdateApplicationAsync(KaskKiosk.AESApplicationServiceRef.ApplicationDAO newApp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/DeleteApplication", ReplyAction="http://tempuri.org/IApplicationService/DeleteApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(KaskKiosk.AESApplicationServiceRef.KaskServiceException), Action="http://tempuri.org/IApplicationService/DeleteApplicationKaskServiceExceptionFault" +
            "", Name="KaskServiceException", Namespace="http://schemas.datacontract.org/2004/07/Kask.Services.Exceptions")]
        bool DeleteApplication(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/DeleteApplication", ReplyAction="http://tempuri.org/IApplicationService/DeleteApplicationResponse")]
        System.Threading.Tasks.Task<bool> DeleteApplicationAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationServiceChannel : KaskKiosk.AESApplicationServiceRef.IApplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationServiceClient : System.ServiceModel.ClientBase<KaskKiosk.AESApplicationServiceRef.IApplicationService>, KaskKiosk.AESApplicationServiceRef.IApplicationService {
        
        public ApplicationServiceClient() {
        }
        
        public ApplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KaskKiosk.AESApplicationServiceRef.ApplicationDAO GetApplicationByID(int id) {
            return base.Channel.GetApplicationByID(id);
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.ApplicationDAO> GetApplicationByIDAsync(int id) {
            return base.Channel.GetApplicationByIDAsync(id);
        }
        
        public KaskKiosk.AESApplicationServiceRef.ApplicationDAO[] GetApplicationsByName(string first, string last, string ssn) {
            return base.Channel.GetApplicationsByName(first, last, ssn);
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.ApplicationDAO[]> GetApplicationsByNameAsync(string first, string last, string ssn) {
            return base.Channel.GetApplicationsByNameAsync(first, last, ssn);
        }
        
        public KaskKiosk.AESApplicationServiceRef.ApplicationDAO[] GetApplications() {
            return base.Channel.GetApplications();
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.ApplicationDAO[]> GetApplicationsAsync() {
            return base.Channel.GetApplicationsAsync();
        }
        
        public bool CreateApplication(KaskKiosk.AESApplicationServiceRef.ApplicationDAO app) {
            return base.Channel.CreateApplication(app);
        }
        
        public System.Threading.Tasks.Task<bool> CreateApplicationAsync(KaskKiosk.AESApplicationServiceRef.ApplicationDAO app) {
            return base.Channel.CreateApplicationAsync(app);
        }
        
        public bool UpdateApplication(KaskKiosk.AESApplicationServiceRef.ApplicationDAO newApp) {
            return base.Channel.UpdateApplication(newApp);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateApplicationAsync(KaskKiosk.AESApplicationServiceRef.ApplicationDAO newApp) {
            return base.Channel.UpdateApplicationAsync(newApp);
        }
        
        public bool DeleteApplication(int ID) {
            return base.Channel.DeleteApplication(ID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteApplicationAsync(int ID) {
            return base.Channel.DeleteApplicationAsync(ID);
        }
    }
}
