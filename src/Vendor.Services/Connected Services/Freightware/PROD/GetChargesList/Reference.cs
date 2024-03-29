﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vendor.Services.Freightware.PROD.GetChargesList
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://namespace.softwareag.com/entirex/xml/mapping", ConfigurationName="Vendor.Services.Freightware.PROD.GetChargesList.FWV6WEBPort")]
    public interface FWV6WEBPort
    {
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="GetChargesList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListResponse> GetChargesListAsync(Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetChargesListSequence
    {
        
        private bool byTypeCodeField;
        
        private bool byTypeCodeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool ByTypeCode
        {
            get
            {
                return this.byTypeCodeField;
            }
            set
            {
                this.byTypeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ByTypeCodeSpecified
        {
            get
            {
                return this.byTypeCodeFieldSpecified;
            }
            set
            {
                this.byTypeCodeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetChargesListStartValues
    {
        
        private string chargeTypeField;
        
        private string chargeCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ChargeType
        {
            get
            {
                return this.chargeTypeField;
            }
            set
            {
                this.chargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ChargeCode
        {
            get
            {
                return this.chargeCodeField;
            }
            set
            {
                this.chargeCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetChargesListResponseChargesOutput
    {
        
        private decimal chargeAmountField;
        
        private bool chargeAmountFieldSpecified;
        
        private string compulsoryIndField;
        
        private string condChargeIndField;
        
        private GetChargesListResponseChargesOutputCondChargeDepots[] condChargeDepotssField;
        
        private string countryCodeField;
        
        private decimal dateCeaseField;
        
        private bool dateCeaseFieldSpecified;
        
        private decimal dateEffectiveField;
        
        private bool dateEffectiveFieldSpecified;
        
        private string descriptionField;
        
        private string headingField;
        
        private string levelIndField;
        
        private decimal minimumChargeField;
        
        private bool minimumChargeFieldSpecified;
        
        private decimal percentField;
        
        private bool percentFieldSpecified;
        
        private string programNameField;
        
        private string remarksField;
        
        private string outChargeTypeField;
        
        private string outChargeCodeField;
        
        private string typeField;
        
        private string vatIndField;
        
        private decimal outUniqueIdField;
        
        private bool outUniqueIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal ChargeAmount
        {
            get
            {
                return this.chargeAmountField;
            }
            set
            {
                this.chargeAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargeAmountSpecified
        {
            get
            {
                return this.chargeAmountFieldSpecified;
            }
            set
            {
                this.chargeAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CompulsoryInd
        {
            get
            {
                return this.compulsoryIndField;
            }
            set
            {
                this.compulsoryIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CondChargeInd
        {
            get
            {
                return this.condChargeIndField;
            }
            set
            {
                this.condChargeIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CondChargeDepots", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetChargesListResponseChargesOutputCondChargeDepots[] CondChargeDepotss
        {
            get
            {
                return this.condChargeDepotssField;
            }
            set
            {
                this.condChargeDepotssField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public decimal DateCease
        {
            get
            {
                return this.dateCeaseField;
            }
            set
            {
                this.dateCeaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateCeaseSpecified
        {
            get
            {
                return this.dateCeaseFieldSpecified;
            }
            set
            {
                this.dateCeaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal DateEffective
        {
            get
            {
                return this.dateEffectiveField;
            }
            set
            {
                this.dateEffectiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateEffectiveSpecified
        {
            get
            {
                return this.dateEffectiveFieldSpecified;
            }
            set
            {
                this.dateEffectiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string LevelInd
        {
            get
            {
                return this.levelIndField;
            }
            set
            {
                this.levelIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public decimal MinimumCharge
        {
            get
            {
                return this.minimumChargeField;
            }
            set
            {
                this.minimumChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumChargeSpecified
        {
            get
            {
                return this.minimumChargeFieldSpecified;
            }
            set
            {
                this.minimumChargeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public decimal Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentSpecified
        {
            get
            {
                return this.percentFieldSpecified;
            }
            set
            {
                this.percentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string ProgramName
        {
            get
            {
                return this.programNameField;
            }
            set
            {
                this.programNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string OutChargeType
        {
            get
            {
                return this.outChargeTypeField;
            }
            set
            {
                this.outChargeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string OutChargeCode
        {
            get
            {
                return this.outChargeCodeField;
            }
            set
            {
                this.outChargeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string VatInd
        {
            get
            {
                return this.vatIndField;
            }
            set
            {
                this.vatIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public decimal OutUniqueId
        {
            get
            {
                return this.outUniqueIdField;
            }
            set
            {
                this.outUniqueIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutUniqueIdSpecified
        {
            get
            {
                return this.outUniqueIdFieldSpecified;
            }
            set
            {
                this.outUniqueIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetChargesListResponseChargesOutputCondChargeDepots
    {
        
        private string condChargeDepCodeField;
        
        private string condChargeDepDescrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CondChargeDepCode
        {
            get
            {
                return this.condChargeDepCodeField;
            }
            set
            {
                this.condChargeDepCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CondChargeDepDescr
        {
            get
            {
                return this.condChargeDepDescrField;
            }
            set
            {
                this.condChargeDepDescrField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetChargesList", WrapperNamespace="urn:com-softwareag-entirex-rpc:FWV6WEB", IsWrapped=true)]
    public partial class GetChargesListRequest
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
        public Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListSequence Sequence;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListStartValues StartValues;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EffectiveDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomerCode;
        
        public GetChargesListRequest()
        {
        }
        
        public GetChargesListRequest(string InUserid, string InPassword, string InCustCode, string InRequestCtr, string IoSessionData, Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListSequence Sequence, Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListStartValues StartValues, string EffectiveDate, string CustomerCode)
        {
            this.InUserid = InUserid;
            this.InPassword = InPassword;
            this.InCustCode = InCustCode;
            this.InRequestCtr = InRequestCtr;
            this.IoSessionData = IoSessionData;
            this.Sequence = Sequence;
            this.StartValues = StartValues;
            this.EffectiveDate = EffectiveDate;
            this.CustomerCode = CustomerCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetChargesListResponse", WrapperNamespace="urn:com-softwareag-entirex-rpc:FWV6WEB", IsWrapped=true)]
    public partial class GetChargesListResponse
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
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ChargesOutput", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListResponseChargesOutput[] ChargesOutputs;
        
        public GetChargesListResponse()
        {
        }
        
        public GetChargesListResponse(string IoSessionData, string ReturnCtr, string ReturnCode, string ReturnMessage, Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListResponseChargesOutput[] ChargesOutputs)
        {
            this.IoSessionData = IoSessionData;
            this.ReturnCtr = ReturnCtr;
            this.ReturnCode = ReturnCode;
            this.ReturnMessage = ReturnMessage;
            this.ChargesOutputs = ChargesOutputs;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface FWV6WEBPortChannel : Vendor.Services.Freightware.PROD.GetChargesList.FWV6WEBPort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class FWV6WEBPortClient : System.ServiceModel.ClientBase<Vendor.Services.Freightware.PROD.GetChargesList.FWV6WEBPort>, Vendor.Services.Freightware.PROD.GetChargesList.FWV6WEBPort
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
        
        public System.Threading.Tasks.Task<Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListResponse> GetChargesListAsync(Vendor.Services.Freightware.PROD.GetChargesList.GetChargesListRequest request)
        {
            return base.Channel.GetChargesListAsync(request);
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
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP11Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
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
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP11Port))
            {
                return new System.ServiceModel.EndpointAddress("http://triton-fw.clients.dovetail.co.za:8080/FreightWareV6/services/GetChargesLis" +
                        "t");
            }
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP12Port))
            {
                return new System.ServiceModel.EndpointAddress("http://triton-fw.clients.dovetail.co.za:8080/FreightWareV6/services/GetChargesLis" +
                        "t");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            FWV6WEBSOAP11Port,
            
            FWV6WEBSOAP12Port,
        }
    }
}
