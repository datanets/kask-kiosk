﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Application", Namespace="http://schemas.datacontract.org/2004/07/Kask.DAL2.Models")]
    [System.SerializableAttribute()]
    public partial class Application : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Application_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationStatusField;
        
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
        public int Application_ID {
            get {
                return this.Application_IDField;
            }
            set {
                if ((this.Application_IDField.Equals(value) != true)) {
                    this.Application_IDField = value;
                    this.RaisePropertyChanged("Application_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Applicant", Namespace="http://schemas.datacontract.org/2004/07/Kask.DAL2.Models")]
    [System.SerializableAttribute()]
    public partial class Applicant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Applicant_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SSNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
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
        public int Applicant_ID {
            get {
                return this.Applicant_IDField;
            }
            set {
                if ((this.Applicant_IDField.Equals(value) != true)) {
                    this.Applicant_IDField = value;
                    this.RaisePropertyChanged("Applicant_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SSN {
            get {
                return this.SSNField;
            }
            set {
                if ((object.ReferenceEquals(this.SSNField, value) != true)) {
                    this.SSNField = value;
                    this.RaisePropertyChanged("SSN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Applied", Namespace="http://schemas.datacontract.org/2004/07/Kask.DAL2.Models")]
    [System.SerializableAttribute()]
    public partial class Applied : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Applicant_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Application_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Job_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAppliedField;
        
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
        public int Applicant_ID {
            get {
                return this.Applicant_IDField;
            }
            set {
                if ((this.Applicant_IDField.Equals(value) != true)) {
                    this.Applicant_IDField = value;
                    this.RaisePropertyChanged("Applicant_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Application_ID {
            get {
                return this.Application_IDField;
            }
            set {
                if ((this.Application_IDField.Equals(value) != true)) {
                    this.Application_IDField = value;
                    this.RaisePropertyChanged("Application_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Job_ID {
            get {
                return this.Job_IDField;
            }
            set {
                if ((this.Job_IDField.Equals(value) != true)) {
                    this.Job_IDField = value;
                    this.RaisePropertyChanged("Job_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime DateApplied {
            get {
                return this.DateAppliedField;
            }
            set {
                if ((this.DateAppliedField.Equals(value) != true)) {
                    this.DateAppliedField = value;
                    this.RaisePropertyChanged("DateApplied");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AESApplicationServiceRef.IApplicationService")]
    public interface IApplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplicationById", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationByIdResponse")]
        KaskKiosk.AESApplicationServiceRef.Application GetApplicationById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplicationById", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationByIdResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Application> GetApplicationByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplications", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationsResponse")]
        KaskKiosk.AESApplicationServiceRef.Application[] GetApplications();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/GetApplications", ReplyAction="http://tempuri.org/IApplicationService/GetApplicationsResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Application[]> GetApplicationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/CreateApplication", ReplyAction="http://tempuri.org/IApplicationService/CreateApplicationResponse")]
        bool CreateApplication(KaskKiosk.AESApplicationServiceRef.Application app);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/CreateApplication", ReplyAction="http://tempuri.org/IApplicationService/CreateApplicationResponse")]
        System.Threading.Tasks.Task<bool> CreateApplicationAsync(KaskKiosk.AESApplicationServiceRef.Application app);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/UpdateApplication", ReplyAction="http://tempuri.org/IApplicationService/UpdateApplicationResponse")]
        bool UpdateApplication(KaskKiosk.AESApplicationServiceRef.Application newApp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/UpdateApplication", ReplyAction="http://tempuri.org/IApplicationService/UpdateApplicationResponse")]
        System.Threading.Tasks.Task<bool> UpdateApplicationAsync(KaskKiosk.AESApplicationServiceRef.Application newApp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationService/DeleteApplication", ReplyAction="http://tempuri.org/IApplicationService/DeleteApplicationResponse")]
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
        
        public KaskKiosk.AESApplicationServiceRef.Application GetApplicationById(int id) {
            return base.Channel.GetApplicationById(id);
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Application> GetApplicationByIdAsync(int id) {
            return base.Channel.GetApplicationByIdAsync(id);
        }
        
        public KaskKiosk.AESApplicationServiceRef.Application[] GetApplications() {
            return base.Channel.GetApplications();
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Application[]> GetApplicationsAsync() {
            return base.Channel.GetApplicationsAsync();
        }
        
        public bool CreateApplication(KaskKiosk.AESApplicationServiceRef.Application app) {
            return base.Channel.CreateApplication(app);
        }
        
        public System.Threading.Tasks.Task<bool> CreateApplicationAsync(KaskKiosk.AESApplicationServiceRef.Application app) {
            return base.Channel.CreateApplicationAsync(app);
        }
        
        public bool UpdateApplication(KaskKiosk.AESApplicationServiceRef.Application newApp) {
            return base.Channel.UpdateApplication(newApp);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateApplicationAsync(KaskKiosk.AESApplicationServiceRef.Application newApp) {
            return base.Channel.UpdateApplicationAsync(newApp);
        }
        
        public bool DeleteApplication(int ID) {
            return base.Channel.DeleteApplication(ID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteApplicationAsync(int ID) {
            return base.Channel.DeleteApplicationAsync(ID);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AESApplicationServiceRef.IApplicantService")]
    public interface IApplicantService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/GetApplicantByID", ReplyAction="http://tempuri.org/IApplicantService/GetApplicantByIDResponse")]
        KaskKiosk.AESApplicationServiceRef.Applicant GetApplicantByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/GetApplicantByID", ReplyAction="http://tempuri.org/IApplicantService/GetApplicantByIDResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applicant> GetApplicantByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/GetApplicants", ReplyAction="http://tempuri.org/IApplicantService/GetApplicantsResponse")]
        KaskKiosk.AESApplicationServiceRef.Applicant[] GetApplicants();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/GetApplicants", ReplyAction="http://tempuri.org/IApplicantService/GetApplicantsResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applicant[]> GetApplicantsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/CreateApplicant", ReplyAction="http://tempuri.org/IApplicantService/CreateApplicantResponse")]
        bool CreateApplicant(KaskKiosk.AESApplicationServiceRef.Applicant a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/CreateApplicant", ReplyAction="http://tempuri.org/IApplicantService/CreateApplicantResponse")]
        System.Threading.Tasks.Task<bool> CreateApplicantAsync(KaskKiosk.AESApplicationServiceRef.Applicant a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/UpdateApplicant", ReplyAction="http://tempuri.org/IApplicantService/UpdateApplicantResponse")]
        bool UpdateApplicant(KaskKiosk.AESApplicationServiceRef.Applicant newApp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/UpdateApplicant", ReplyAction="http://tempuri.org/IApplicantService/UpdateApplicantResponse")]
        System.Threading.Tasks.Task<bool> UpdateApplicantAsync(KaskKiosk.AESApplicationServiceRef.Applicant newApp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/DeleteApplicant", ReplyAction="http://tempuri.org/IApplicantService/DeleteApplicantResponse")]
        bool DeleteApplicant(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicantService/DeleteApplicant", ReplyAction="http://tempuri.org/IApplicantService/DeleteApplicantResponse")]
        System.Threading.Tasks.Task<bool> DeleteApplicantAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicantServiceChannel : KaskKiosk.AESApplicationServiceRef.IApplicantService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicantServiceClient : System.ServiceModel.ClientBase<KaskKiosk.AESApplicationServiceRef.IApplicantService>, KaskKiosk.AESApplicationServiceRef.IApplicantService {
        
        public ApplicantServiceClient() {
        }
        
        public ApplicantServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicantServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicantServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicantServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KaskKiosk.AESApplicationServiceRef.Applicant GetApplicantByID(int id) {
            return base.Channel.GetApplicantByID(id);
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applicant> GetApplicantByIDAsync(int id) {
            return base.Channel.GetApplicantByIDAsync(id);
        }
        
        public KaskKiosk.AESApplicationServiceRef.Applicant[] GetApplicants() {
            return base.Channel.GetApplicants();
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applicant[]> GetApplicantsAsync() {
            return base.Channel.GetApplicantsAsync();
        }
        
        public bool CreateApplicant(KaskKiosk.AESApplicationServiceRef.Applicant a) {
            return base.Channel.CreateApplicant(a);
        }
        
        public System.Threading.Tasks.Task<bool> CreateApplicantAsync(KaskKiosk.AESApplicationServiceRef.Applicant a) {
            return base.Channel.CreateApplicantAsync(a);
        }
        
        public bool UpdateApplicant(KaskKiosk.AESApplicationServiceRef.Applicant newApp) {
            return base.Channel.UpdateApplicant(newApp);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateApplicantAsync(KaskKiosk.AESApplicationServiceRef.Applicant newApp) {
            return base.Channel.UpdateApplicantAsync(newApp);
        }
        
        public bool DeleteApplicant(int ID) {
            return base.Channel.DeleteApplicant(ID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteApplicantAsync(int ID) {
            return base.Channel.DeleteApplicantAsync(ID);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AESApplicationServiceRef.IAppliedService")]
    public interface IAppliedService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/GetAppliedByID", ReplyAction="http://tempuri.org/IAppliedService/GetAppliedByIDResponse")]
        KaskKiosk.AESApplicationServiceRef.Applied GetAppliedByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/GetAppliedByID", ReplyAction="http://tempuri.org/IAppliedService/GetAppliedByIDResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applied> GetAppliedByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/GetApplieds", ReplyAction="http://tempuri.org/IAppliedService/GetAppliedsResponse")]
        KaskKiosk.AESApplicationServiceRef.Applied[] GetApplieds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/GetApplieds", ReplyAction="http://tempuri.org/IAppliedService/GetAppliedsResponse")]
        System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applied[]> GetAppliedsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/CreateApplied", ReplyAction="http://tempuri.org/IAppliedService/CreateAppliedResponse")]
        bool CreateApplied(KaskKiosk.AESApplicationServiceRef.Applied a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/CreateApplied", ReplyAction="http://tempuri.org/IAppliedService/CreateAppliedResponse")]
        System.Threading.Tasks.Task<bool> CreateAppliedAsync(KaskKiosk.AESApplicationServiceRef.Applied a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/UpdateApplied", ReplyAction="http://tempuri.org/IAppliedService/UpdateAppliedResponse")]
        bool UpdateApplied(KaskKiosk.AESApplicationServiceRef.Applied a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/UpdateApplied", ReplyAction="http://tempuri.org/IAppliedService/UpdateAppliedResponse")]
        System.Threading.Tasks.Task<bool> UpdateAppliedAsync(KaskKiosk.AESApplicationServiceRef.Applied a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/DeleteApplied", ReplyAction="http://tempuri.org/IAppliedService/DeleteAppliedResponse")]
        bool DeleteApplied(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppliedService/DeleteApplied", ReplyAction="http://tempuri.org/IAppliedService/DeleteAppliedResponse")]
        System.Threading.Tasks.Task<bool> DeleteAppliedAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppliedServiceChannel : KaskKiosk.AESApplicationServiceRef.IAppliedService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppliedServiceClient : System.ServiceModel.ClientBase<KaskKiosk.AESApplicationServiceRef.IAppliedService>, KaskKiosk.AESApplicationServiceRef.IAppliedService {
        
        public AppliedServiceClient() {
        }
        
        public AppliedServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppliedServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppliedServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppliedServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KaskKiosk.AESApplicationServiceRef.Applied GetAppliedByID(int id) {
            return base.Channel.GetAppliedByID(id);
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applied> GetAppliedByIDAsync(int id) {
            return base.Channel.GetAppliedByIDAsync(id);
        }
        
        public KaskKiosk.AESApplicationServiceRef.Applied[] GetApplieds() {
            return base.Channel.GetApplieds();
        }
        
        public System.Threading.Tasks.Task<KaskKiosk.AESApplicationServiceRef.Applied[]> GetAppliedsAsync() {
            return base.Channel.GetAppliedsAsync();
        }
        
        public bool CreateApplied(KaskKiosk.AESApplicationServiceRef.Applied a) {
            return base.Channel.CreateApplied(a);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAppliedAsync(KaskKiosk.AESApplicationServiceRef.Applied a) {
            return base.Channel.CreateAppliedAsync(a);
        }
        
        public bool UpdateApplied(KaskKiosk.AESApplicationServiceRef.Applied a) {
            return base.Channel.UpdateApplied(a);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAppliedAsync(KaskKiosk.AESApplicationServiceRef.Applied a) {
            return base.Channel.UpdateAppliedAsync(a);
        }
        
        public bool DeleteApplied(int id) {
            return base.Channel.DeleteApplied(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAppliedAsync(int id) {
            return base.Channel.DeleteAppliedAsync(id);
        }
    }
}