﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AreaCalculator.AreaCalcuServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap")]
    public interface AreaCalculatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCuadrado", ReplyAction="*")]
        int AreaCuadrado(int lados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCuadrado", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AreaCuadradoAsync(int lados);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento AreaTrianguloResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaTriangulo", ReplyAction="*")]
        AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponse AreaTriangulo(AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaTriangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponse> AreaTrianguloAsync(AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento AreaCirculoResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCirculo", ReplyAction="*")]
        AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponse AreaCirculo(AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCirculo", ReplyAction="*")]
        System.Threading.Tasks.Task<AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponse> AreaCirculoAsync(AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AreaTrianguloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AreaTriangulo", Namespace="http://tempuri.org/", Order=0)]
        public AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequestBody Body;
        
        public AreaTrianguloRequest() {
        }
        
        public AreaTrianguloRequest(AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AreaTrianguloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int bases;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int altura;
        
        public AreaTrianguloRequestBody() {
        }
        
        public AreaTrianguloRequestBody(int bases, int altura) {
            this.bases = bases;
            this.altura = altura;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AreaTrianguloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AreaTrianguloResponse", Namespace="http://tempuri.org/", Order=0)]
        public AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponseBody Body;
        
        public AreaTrianguloResponse() {
        }
        
        public AreaTrianguloResponse(AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AreaTrianguloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AreaTrianguloResult;
        
        public AreaTrianguloResponseBody() {
        }
        
        public AreaTrianguloResponseBody(string AreaTrianguloResult) {
            this.AreaTrianguloResult = AreaTrianguloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AreaCirculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AreaCirculo", Namespace="http://tempuri.org/", Order=0)]
        public AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequestBody Body;
        
        public AreaCirculoRequest() {
        }
        
        public AreaCirculoRequest(AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AreaCirculoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float Radio;
        
        public AreaCirculoRequestBody() {
        }
        
        public AreaCirculoRequestBody(float Radio) {
            this.Radio = Radio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AreaCirculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AreaCirculoResponse", Namespace="http://tempuri.org/", Order=0)]
        public AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponseBody Body;
        
        public AreaCirculoResponse() {
        }
        
        public AreaCirculoResponse(AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AreaCirculoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AreaCirculoResult;
        
        public AreaCirculoResponseBody() {
        }
        
        public AreaCirculoResponseBody(string AreaCirculoResult) {
            this.AreaCirculoResult = AreaCirculoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AreaCalculatorWebServiceSoapChannel : AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AreaCalculatorWebServiceSoapClient : System.ServiceModel.ClientBase<AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap>, AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap {
        
        public AreaCalculatorWebServiceSoapClient() {
        }
        
        public AreaCalculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AreaCalculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreaCalculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreaCalculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AreaCuadrado(int lados) {
            return base.Channel.AreaCuadrado(lados);
        }
        
        public System.Threading.Tasks.Task<int> AreaCuadradoAsync(int lados) {
            return base.Channel.AreaCuadradoAsync(lados);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponse AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap.AreaTriangulo(AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest request) {
            return base.Channel.AreaTriangulo(request);
        }
        
        public string AreaTriangulo(int bases, int altura) {
            AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest inValue = new AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest();
            inValue.Body = new AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequestBody();
            inValue.Body.bases = bases;
            inValue.Body.altura = altura;
            AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponse retVal = ((AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap)(this)).AreaTriangulo(inValue);
            return retVal.Body.AreaTrianguloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponse> AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap.AreaTrianguloAsync(AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest request) {
            return base.Channel.AreaTrianguloAsync(request);
        }
        
        public System.Threading.Tasks.Task<AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloResponse> AreaTrianguloAsync(int bases, int altura) {
            AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest inValue = new AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequest();
            inValue.Body = new AreaCalculator.AreaCalcuServiceReference1.AreaTrianguloRequestBody();
            inValue.Body.bases = bases;
            inValue.Body.altura = altura;
            return ((AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap)(this)).AreaTrianguloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponse AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap.AreaCirculo(AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest request) {
            return base.Channel.AreaCirculo(request);
        }
        
        public string AreaCirculo(float Radio) {
            AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest inValue = new AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest();
            inValue.Body = new AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequestBody();
            inValue.Body.Radio = Radio;
            AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponse retVal = ((AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap)(this)).AreaCirculo(inValue);
            return retVal.Body.AreaCirculoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponse> AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap.AreaCirculoAsync(AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest request) {
            return base.Channel.AreaCirculoAsync(request);
        }
        
        public System.Threading.Tasks.Task<AreaCalculator.AreaCalcuServiceReference1.AreaCirculoResponse> AreaCirculoAsync(float Radio) {
            AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest inValue = new AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequest();
            inValue.Body = new AreaCalculator.AreaCalcuServiceReference1.AreaCirculoRequestBody();
            inValue.Body.Radio = Radio;
            return ((AreaCalculator.AreaCalcuServiceReference1.AreaCalculatorWebServiceSoap)(this)).AreaCirculoAsync(inValue);
        }
    }
}
