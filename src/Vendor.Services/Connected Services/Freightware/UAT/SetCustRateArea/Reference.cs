﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vendor.Services.Freightware.UAT.SetCustRateArea
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://namespace.softwareag.com/entirex/xml/mapping", ConfigurationName="Vendor.Services.Freightware.UAT.SetCustRateArea.FWV6WEBPort")]
    public interface FWV6WEBPort
    {
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="SetCustRateArea", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaResponse> SetCustRateAreaAsync(Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class SetCustRateAreaInAction
    {
        
        private bool inAddField;
        
        private bool inAddFieldSpecified;
        
        private bool inModifyField;
        
        private bool inModifyFieldSpecified;
        
        private bool inPurgeField;
        
        private bool inPurgeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool InAdd
        {
            get
            {
                return this.inAddField;
            }
            set
            {
                this.inAddField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InAddSpecified
        {
            get
            {
                return this.inAddFieldSpecified;
            }
            set
            {
                this.inAddFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool InModify
        {
            get
            {
                return this.inModifyField;
            }
            set
            {
                this.inModifyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InModifySpecified
        {
            get
            {
                return this.inModifyFieldSpecified;
            }
            set
            {
                this.inModifyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool InPurge
        {
            get
            {
                return this.inPurgeField;
            }
            set
            {
                this.inPurgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InPurgeSpecified
        {
            get
            {
                return this.inPurgeFieldSpecified;
            }
            set
            {
                this.inPurgeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class SetCustRateAreaInCustRateArea
    {
        
        private string custCodeField;
        
        private string custRateAreaField;
        
        private string areaNameLongField;
        
        private string areaNameShortField;
        
        private string branchField;
        
        private SetCustRateAreaInCustRateAreaInPCodeLine[] inPCodeLinesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CustCode
        {
            get
            {
                return this.custCodeField;
            }
            set
            {
                this.custCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CustRateArea
        {
            get
            {
                return this.custRateAreaField;
            }
            set
            {
                this.custRateAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string AreaNameLong
        {
            get
            {
                return this.areaNameLongField;
            }
            set
            {
                this.areaNameLongField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string AreaNameShort
        {
            get
            {
                return this.areaNameShortField;
            }
            set
            {
                this.areaNameShortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("InPCodeLine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public SetCustRateAreaInCustRateAreaInPCodeLine[] InPCodeLines
        {
            get
            {
                return this.inPCodeLinesField;
            }
            set
            {
                this.inPCodeLinesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class SetCustRateAreaInCustRateAreaInPCodeLine
    {
        
        private string inItemPostCodeField;
        
        private string inItemPCodeNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string InItemPostCode
        {
            get
            {
                return this.inItemPostCodeField;
            }
            set
            {
                this.inItemPostCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string InItemPCodeName
        {
            get
            {
                return this.inItemPCodeNameField;
            }
            set
            {
                this.inItemPCodeNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class SetCustRateAreaResponseOutCustRateArea
    {
        
        private string custCodeField;
        
        private string custNameField;
        
        private string custRateAreaField;
        
        private string areaNameLongField;
        
        private string areaNameShortField;
        
        private string branchField;
        
        private string branchNameField;
        
        private decimal pCodeLineCtrField;
        
        private bool pCodeLineCtrFieldSpecified;
        
        private SetCustRateAreaResponseOutCustRateAreaPCodeLineItem[] pCodeLineItemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CustCode
        {
            get
            {
                return this.custCodeField;
            }
            set
            {
                this.custCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CustName
        {
            get
            {
                return this.custNameField;
            }
            set
            {
                this.custNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CustRateArea
        {
            get
            {
                return this.custRateAreaField;
            }
            set
            {
                this.custRateAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string AreaNameLong
        {
            get
            {
                return this.areaNameLongField;
            }
            set
            {
                this.areaNameLongField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string AreaNameShort
        {
            get
            {
                return this.areaNameShortField;
            }
            set
            {
                this.areaNameShortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string BranchName
        {
            get
            {
                return this.branchNameField;
            }
            set
            {
                this.branchNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public decimal PCodeLineCtr
        {
            get
            {
                return this.pCodeLineCtrField;
            }
            set
            {
                this.pCodeLineCtrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PCodeLineCtrSpecified
        {
            get
            {
                return this.pCodeLineCtrFieldSpecified;
            }
            set
            {
                this.pCodeLineCtrFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PCodeLineItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public SetCustRateAreaResponseOutCustRateAreaPCodeLineItem[] PCodeLineItems
        {
            get
            {
                return this.pCodeLineItemsField;
            }
            set
            {
                this.pCodeLineItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class SetCustRateAreaResponseOutCustRateAreaPCodeLineItem
    {
        
        private string itemPostCodeField;
        
        private string itemPCodeNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ItemPostCode
        {
            get
            {
                return this.itemPostCodeField;
            }
            set
            {
                this.itemPostCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ItemPCodeName
        {
            get
            {
                return this.itemPCodeNameField;
            }
            set
            {
                this.itemPCodeNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCustRateArea", WrapperNamespace="urn:com-softwareag-entirex-rpc:FWV6WEB", IsWrapped=true)]
    public partial class SetCustRateAreaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InUserid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InCustCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InRequestCtr;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IoSessionData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaInAction InAction;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaInCustRateArea InCustRateArea;
        
        public SetCustRateAreaRequest()
        {
        }
        
        public SetCustRateAreaRequest(string InUserid, string InPassword, string InCustCode, string InRequestCtr, string IoSessionData, Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaInAction InAction, Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaInCustRateArea InCustRateArea)
        {
            this.InUserid = InUserid;
            this.InPassword = InPassword;
            this.InCustCode = InCustCode;
            this.InRequestCtr = InRequestCtr;
            this.IoSessionData = IoSessionData;
            this.InAction = InAction;
            this.InCustRateArea = InCustRateArea;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCustRateAreaResponse", WrapperNamespace="urn:com-softwareag-entirex-rpc:FWV6WEB", IsWrapped=true)]
    public partial class SetCustRateAreaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IoSessionData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnCtr;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnMessage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaResponseOutCustRateArea OutCustRateArea;
        
        public SetCustRateAreaResponse()
        {
        }
        
        public SetCustRateAreaResponse(string IoSessionData, string ReturnCtr, string ReturnCode, string ReturnMessage, Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaResponseOutCustRateArea OutCustRateArea)
        {
            this.IoSessionData = IoSessionData;
            this.ReturnCtr = ReturnCtr;
            this.ReturnCode = ReturnCode;
            this.ReturnMessage = ReturnMessage;
            this.OutCustRateArea = OutCustRateArea;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface FWV6WEBPortChannel : Vendor.Services.Freightware.UAT.SetCustRateArea.FWV6WEBPort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class FWV6WEBPortClient : System.ServiceModel.ClientBase<Vendor.Services.Freightware.UAT.SetCustRateArea.FWV6WEBPort>, Vendor.Services.Freightware.UAT.SetCustRateArea.FWV6WEBPort
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FWV6WEBPortClient(EndpointConfiguration endpointConfiguration) : 
                base(FWV6WEBPortClient.GetBindingForEndpoint(endpointConfiguration), FWV6WEBPortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FWV6WEBPortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FWV6WEBPortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FWV6WEBPortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FWV6WEBPortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FWV6WEBPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaResponse> SetCustRateAreaAsync(Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaRequest request)
        {
            return base.Channel.SetCustRateAreaAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP12Port))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP11Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP12Port))
            {
                return new System.ServiceModel.EndpointAddress("http://triton-fw.clients.dovetail.co.za:8180/FreightWareV6Test/services/SetCustRa" +
                        "teArea.FWV6WEBSOAP12Port/");
            }
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP11Port))
            {
                return new System.ServiceModel.EndpointAddress("http://triton-fw.clients.dovetail.co.za:8180/FreightWareV6Test/services/SetCustRa" +
                        "teArea.FWV6WEBSOAP11Port/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            FWV6WEBSOAP12Port,
            
            FWV6WEBSOAP11Port,
        }
    }
}
