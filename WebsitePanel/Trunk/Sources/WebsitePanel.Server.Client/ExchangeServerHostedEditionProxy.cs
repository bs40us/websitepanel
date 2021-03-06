//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace WebsitePanel.Providers.ExchangeHostedEdition {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ExchangeServerHostedEditionSoap", Namespace="http://smbsaas/websitepanel/server/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceProviderItem))]
    public partial class ExchangeServerHostedEdition : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        public ServiceProviderSettingsSoapHeader ServiceProviderSettingsSoapHeaderValue;
        
        private System.Threading.SendOrPostCallback CreateOrganizationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOrganizationDomainsOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddOrganizationDomainOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteOrganizationDomainOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOrganizationDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateOrganizationQuotasOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateOrganizationCatchAllAddressOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateOrganizationServicePlanOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteOrganizationOperationCompleted;
        
        /// <remarks/>
        public ExchangeServerHostedEdition() {
            this.Url = "http://localhost:9003/ExchangeServerHostedEdition.asmx";
        }
        
        /// <remarks/>
        public event CreateOrganizationCompletedEventHandler CreateOrganizationCompleted;
        
        /// <remarks/>
        public event GetOrganizationDomainsCompletedEventHandler GetOrganizationDomainsCompleted;
        
        /// <remarks/>
        public event AddOrganizationDomainCompletedEventHandler AddOrganizationDomainCompleted;
        
        /// <remarks/>
        public event DeleteOrganizationDomainCompletedEventHandler DeleteOrganizationDomainCompleted;
        
        /// <remarks/>
        public event GetOrganizationDetailsCompletedEventHandler GetOrganizationDetailsCompleted;
        
        /// <remarks/>
        public event UpdateOrganizationQuotasCompletedEventHandler UpdateOrganizationQuotasCompleted;
        
        /// <remarks/>
        public event UpdateOrganizationCatchAllAddressCompletedEventHandler UpdateOrganizationCatchAllAddressCompleted;
        
        /// <remarks/>
        public event UpdateOrganizationServicePlanCompletedEventHandler UpdateOrganizationServicePlanCompleted;
        
        /// <remarks/>
        public event DeleteOrganizationCompletedEventHandler DeleteOrganizationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/CreateOrganization", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateOrganization(string organizationId, string programId, string offerId, string domain, string adminName, string adminEmail, string adminPassword) {
            this.Invoke("CreateOrganization", new object[] {
                        organizationId,
                        programId,
                        offerId,
                        domain,
                        adminName,
                        adminEmail,
                        adminPassword});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateOrganization(string organizationId, string programId, string offerId, string domain, string adminName, string adminEmail, string adminPassword, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateOrganization", new object[] {
                        organizationId,
                        programId,
                        offerId,
                        domain,
                        adminName,
                        adminEmail,
                        adminPassword}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndCreateOrganization(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void CreateOrganizationAsync(string organizationId, string programId, string offerId, string domain, string adminName, string adminEmail, string adminPassword) {
            this.CreateOrganizationAsync(organizationId, programId, offerId, domain, adminName, adminEmail, adminPassword, null);
        }
        
        /// <remarks/>
        public void CreateOrganizationAsync(string organizationId, string programId, string offerId, string domain, string adminName, string adminEmail, string adminPassword, object userState) {
            if ((this.CreateOrganizationOperationCompleted == null)) {
                this.CreateOrganizationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateOrganizationOperationCompleted);
            }
            this.InvokeAsync("CreateOrganization", new object[] {
                        organizationId,
                        programId,
                        offerId,
                        domain,
                        adminName,
                        adminEmail,
                        adminPassword}, this.CreateOrganizationOperationCompleted, userState);
        }
        
        private void OnCreateOrganizationOperationCompleted(object arg) {
            if ((this.CreateOrganizationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateOrganizationCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetOrganizationDomains", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExchangeOrganizationDomain[] GetOrganizationDomains(string organizationId) {
            object[] results = this.Invoke("GetOrganizationDomains", new object[] {
                        organizationId});
            return ((ExchangeOrganizationDomain[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetOrganizationDomains(string organizationId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetOrganizationDomains", new object[] {
                        organizationId}, callback, asyncState);
        }
        
        /// <remarks/>
        public ExchangeOrganizationDomain[] EndGetOrganizationDomains(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExchangeOrganizationDomain[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOrganizationDomainsAsync(string organizationId) {
            this.GetOrganizationDomainsAsync(organizationId, null);
        }
        
        /// <remarks/>
        public void GetOrganizationDomainsAsync(string organizationId, object userState) {
            if ((this.GetOrganizationDomainsOperationCompleted == null)) {
                this.GetOrganizationDomainsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOrganizationDomainsOperationCompleted);
            }
            this.InvokeAsync("GetOrganizationDomains", new object[] {
                        organizationId}, this.GetOrganizationDomainsOperationCompleted, userState);
        }
        
        private void OnGetOrganizationDomainsOperationCompleted(object arg) {
            if ((this.GetOrganizationDomainsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOrganizationDomainsCompleted(this, new GetOrganizationDomainsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/AddOrganizationDomain", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddOrganizationDomain(string organizationId, string domain) {
            this.Invoke("AddOrganizationDomain", new object[] {
                        organizationId,
                        domain});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddOrganizationDomain(string organizationId, string domain, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddOrganizationDomain", new object[] {
                        organizationId,
                        domain}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAddOrganizationDomain(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void AddOrganizationDomainAsync(string organizationId, string domain) {
            this.AddOrganizationDomainAsync(organizationId, domain, null);
        }
        
        /// <remarks/>
        public void AddOrganizationDomainAsync(string organizationId, string domain, object userState) {
            if ((this.AddOrganizationDomainOperationCompleted == null)) {
                this.AddOrganizationDomainOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOrganizationDomainOperationCompleted);
            }
            this.InvokeAsync("AddOrganizationDomain", new object[] {
                        organizationId,
                        domain}, this.AddOrganizationDomainOperationCompleted, userState);
        }
        
        private void OnAddOrganizationDomainOperationCompleted(object arg) {
            if ((this.AddOrganizationDomainCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddOrganizationDomainCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/DeleteOrganizationDomain", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteOrganizationDomain(string organizationId, string domain) {
            this.Invoke("DeleteOrganizationDomain", new object[] {
                        organizationId,
                        domain});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteOrganizationDomain(string organizationId, string domain, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteOrganizationDomain", new object[] {
                        organizationId,
                        domain}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndDeleteOrganizationDomain(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void DeleteOrganizationDomainAsync(string organizationId, string domain) {
            this.DeleteOrganizationDomainAsync(organizationId, domain, null);
        }
        
        /// <remarks/>
        public void DeleteOrganizationDomainAsync(string organizationId, string domain, object userState) {
            if ((this.DeleteOrganizationDomainOperationCompleted == null)) {
                this.DeleteOrganizationDomainOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteOrganizationDomainOperationCompleted);
            }
            this.InvokeAsync("DeleteOrganizationDomain", new object[] {
                        organizationId,
                        domain}, this.DeleteOrganizationDomainOperationCompleted, userState);
        }
        
        private void OnDeleteOrganizationDomainOperationCompleted(object arg) {
            if ((this.DeleteOrganizationDomainCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteOrganizationDomainCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetOrganizationDetails", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExchangeOrganization GetOrganizationDetails(string organizationId) {
            object[] results = this.Invoke("GetOrganizationDetails", new object[] {
                        organizationId});
            return ((ExchangeOrganization)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetOrganizationDetails(string organizationId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetOrganizationDetails", new object[] {
                        organizationId}, callback, asyncState);
        }
        
        /// <remarks/>
        public ExchangeOrganization EndGetOrganizationDetails(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExchangeOrganization)(results[0]));
        }
        
        /// <remarks/>
        public void GetOrganizationDetailsAsync(string organizationId) {
            this.GetOrganizationDetailsAsync(organizationId, null);
        }
        
        /// <remarks/>
        public void GetOrganizationDetailsAsync(string organizationId, object userState) {
            if ((this.GetOrganizationDetailsOperationCompleted == null)) {
                this.GetOrganizationDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOrganizationDetailsOperationCompleted);
            }
            this.InvokeAsync("GetOrganizationDetails", new object[] {
                        organizationId}, this.GetOrganizationDetailsOperationCompleted, userState);
        }
        
        private void OnGetOrganizationDetailsOperationCompleted(object arg) {
            if ((this.GetOrganizationDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOrganizationDetailsCompleted(this, new GetOrganizationDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/UpdateOrganizationQuotas", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateOrganizationQuotas(string organizationId, int mailboxesNumber, int contactsNumber, int distributionListsNumber) {
            this.Invoke("UpdateOrganizationQuotas", new object[] {
                        organizationId,
                        mailboxesNumber,
                        contactsNumber,
                        distributionListsNumber});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateOrganizationQuotas(string organizationId, int mailboxesNumber, int contactsNumber, int distributionListsNumber, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateOrganizationQuotas", new object[] {
                        organizationId,
                        mailboxesNumber,
                        contactsNumber,
                        distributionListsNumber}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdateOrganizationQuotas(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void UpdateOrganizationQuotasAsync(string organizationId, int mailboxesNumber, int contactsNumber, int distributionListsNumber) {
            this.UpdateOrganizationQuotasAsync(organizationId, mailboxesNumber, contactsNumber, distributionListsNumber, null);
        }
        
        /// <remarks/>
        public void UpdateOrganizationQuotasAsync(string organizationId, int mailboxesNumber, int contactsNumber, int distributionListsNumber, object userState) {
            if ((this.UpdateOrganizationQuotasOperationCompleted == null)) {
                this.UpdateOrganizationQuotasOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateOrganizationQuotasOperationCompleted);
            }
            this.InvokeAsync("UpdateOrganizationQuotas", new object[] {
                        organizationId,
                        mailboxesNumber,
                        contactsNumber,
                        distributionListsNumber}, this.UpdateOrganizationQuotasOperationCompleted, userState);
        }
        
        private void OnUpdateOrganizationQuotasOperationCompleted(object arg) {
            if ((this.UpdateOrganizationQuotasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateOrganizationQuotasCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/UpdateOrganizationCatchAllAddress", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateOrganizationCatchAllAddress(string organizationId, string catchAllEmail) {
            this.Invoke("UpdateOrganizationCatchAllAddress", new object[] {
                        organizationId,
                        catchAllEmail});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateOrganizationCatchAllAddress(string organizationId, string catchAllEmail, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateOrganizationCatchAllAddress", new object[] {
                        organizationId,
                        catchAllEmail}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdateOrganizationCatchAllAddress(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void UpdateOrganizationCatchAllAddressAsync(string organizationId, string catchAllEmail) {
            this.UpdateOrganizationCatchAllAddressAsync(organizationId, catchAllEmail, null);
        }
        
        /// <remarks/>
        public void UpdateOrganizationCatchAllAddressAsync(string organizationId, string catchAllEmail, object userState) {
            if ((this.UpdateOrganizationCatchAllAddressOperationCompleted == null)) {
                this.UpdateOrganizationCatchAllAddressOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateOrganizationCatchAllAddressOperationCompleted);
            }
            this.InvokeAsync("UpdateOrganizationCatchAllAddress", new object[] {
                        organizationId,
                        catchAllEmail}, this.UpdateOrganizationCatchAllAddressOperationCompleted, userState);
        }
        
        private void OnUpdateOrganizationCatchAllAddressOperationCompleted(object arg) {
            if ((this.UpdateOrganizationCatchAllAddressCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateOrganizationCatchAllAddressCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/UpdateOrganizationServicePlan", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateOrganizationServicePlan(string organizationId, string programId, string offerId) {
            this.Invoke("UpdateOrganizationServicePlan", new object[] {
                        organizationId,
                        programId,
                        offerId});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateOrganizationServicePlan(string organizationId, string programId, string offerId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateOrganizationServicePlan", new object[] {
                        organizationId,
                        programId,
                        offerId}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdateOrganizationServicePlan(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void UpdateOrganizationServicePlanAsync(string organizationId, string programId, string offerId) {
            this.UpdateOrganizationServicePlanAsync(organizationId, programId, offerId, null);
        }
        
        /// <remarks/>
        public void UpdateOrganizationServicePlanAsync(string organizationId, string programId, string offerId, object userState) {
            if ((this.UpdateOrganizationServicePlanOperationCompleted == null)) {
                this.UpdateOrganizationServicePlanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateOrganizationServicePlanOperationCompleted);
            }
            this.InvokeAsync("UpdateOrganizationServicePlan", new object[] {
                        organizationId,
                        programId,
                        offerId}, this.UpdateOrganizationServicePlanOperationCompleted, userState);
        }
        
        private void OnUpdateOrganizationServicePlanOperationCompleted(object arg) {
            if ((this.UpdateOrganizationServicePlanCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateOrganizationServicePlanCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/DeleteOrganization", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteOrganization(string organizationId) {
            this.Invoke("DeleteOrganization", new object[] {
                        organizationId});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteOrganization(string organizationId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteOrganization", new object[] {
                        organizationId}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndDeleteOrganization(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void DeleteOrganizationAsync(string organizationId) {
            this.DeleteOrganizationAsync(organizationId, null);
        }
        
        /// <remarks/>
        public void DeleteOrganizationAsync(string organizationId, object userState) {
            if ((this.DeleteOrganizationOperationCompleted == null)) {
                this.DeleteOrganizationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteOrganizationOperationCompleted);
            }
            this.InvokeAsync("DeleteOrganization", new object[] {
                        organizationId}, this.DeleteOrganizationOperationCompleted, userState);
        }
        
        private void OnDeleteOrganizationOperationCompleted(object arg) {
            if ((this.DeleteOrganizationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteOrganizationCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void CreateOrganizationCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetOrganizationDomainsCompletedEventHandler(object sender, GetOrganizationDomainsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOrganizationDomainsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOrganizationDomainsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExchangeOrganizationDomain[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExchangeOrganizationDomain[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void AddOrganizationDomainCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void DeleteOrganizationDomainCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetOrganizationDetailsCompletedEventHandler(object sender, GetOrganizationDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOrganizationDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOrganizationDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExchangeOrganization Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExchangeOrganization)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void UpdateOrganizationQuotasCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void UpdateOrganizationCatchAllAddressCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void UpdateOrganizationServicePlanCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void DeleteOrganizationCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}
