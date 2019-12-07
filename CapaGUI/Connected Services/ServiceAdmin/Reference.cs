﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceAdmin {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAdmin.WebService2Soap")]
    public interface WebService2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/verificar_usuario_service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.ServiceAdmin.Usuario verificar_usuario_service(string rut, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/verificar_usuario_service", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceAdmin.Usuario> verificar_usuario_serviceAsync(string rut, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregar_usuario_service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void agregar_usuario_service(CapaGUI.ServiceAdmin.Usuario auxUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregar_usuario_service", ReplyAction="*")]
        System.Threading.Tasks.Task agregar_usuario_serviceAsync(CapaGUI.ServiceAdmin.Usuario auxUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consulta_usuario_service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.ServiceAdmin.Usuario consulta_usuario_service(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consulta_usuario_service", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceAdmin.Usuario> consulta_usuario_serviceAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarUsuarios_service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listarUsuarios_service();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarUsuarios_service", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listarUsuarios_serviceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_usuario_service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminar_usuario_service(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_usuario_service", ReplyAction="*")]
        System.Threading.Tasks.Task eliminar_usuario_serviceAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_usuario_service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizar_usuario_service(CapaGUI.ServiceAdmin.Usuario auxUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_usuario_service", ReplyAction="*")]
        System.Threading.Tasks.Task actualizar_usuario_serviceAsync(CapaGUI.ServiceAdmin.Usuario auxUsuario);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nombreField;
        
        private string contraseñaField;
        
        private int cargoField;
        
        private int idField;
        
        private string rutField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                this.contraseñaField = value;
                this.RaisePropertyChanged("Contraseña");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Cargo {
            get {
                return this.cargoField;
            }
            set {
                this.cargoField = value;
                this.RaisePropertyChanged("Cargo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("Rut");
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
    public interface WebService2SoapChannel : CapaGUI.ServiceAdmin.WebService2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService2SoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceAdmin.WebService2Soap>, CapaGUI.ServiceAdmin.WebService2Soap {
        
        public WebService2SoapClient() {
        }
        
        public WebService2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CapaGUI.ServiceAdmin.Usuario verificar_usuario_service(string rut, string user) {
            return base.Channel.verificar_usuario_service(rut, user);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceAdmin.Usuario> verificar_usuario_serviceAsync(string rut, string user) {
            return base.Channel.verificar_usuario_serviceAsync(rut, user);
        }
        
        public void agregar_usuario_service(CapaGUI.ServiceAdmin.Usuario auxUsuario) {
            base.Channel.agregar_usuario_service(auxUsuario);
        }
        
        public System.Threading.Tasks.Task agregar_usuario_serviceAsync(CapaGUI.ServiceAdmin.Usuario auxUsuario) {
            return base.Channel.agregar_usuario_serviceAsync(auxUsuario);
        }
        
        public CapaGUI.ServiceAdmin.Usuario consulta_usuario_service(string user) {
            return base.Channel.consulta_usuario_service(user);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceAdmin.Usuario> consulta_usuario_serviceAsync(string user) {
            return base.Channel.consulta_usuario_serviceAsync(user);
        }
        
        public System.Data.DataSet listarUsuarios_service() {
            return base.Channel.listarUsuarios_service();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listarUsuarios_serviceAsync() {
            return base.Channel.listarUsuarios_serviceAsync();
        }
        
        public void eliminar_usuario_service(string username) {
            base.Channel.eliminar_usuario_service(username);
        }
        
        public System.Threading.Tasks.Task eliminar_usuario_serviceAsync(string username) {
            return base.Channel.eliminar_usuario_serviceAsync(username);
        }
        
        public void actualizar_usuario_service(CapaGUI.ServiceAdmin.Usuario auxUsuario) {
            base.Channel.actualizar_usuario_service(auxUsuario);
        }
        
        public System.Threading.Tasks.Task actualizar_usuario_serviceAsync(CapaGUI.ServiceAdmin.Usuario auxUsuario) {
            return base.Channel.actualizar_usuario_serviceAsync(auxUsuario);
        }
    }
}
