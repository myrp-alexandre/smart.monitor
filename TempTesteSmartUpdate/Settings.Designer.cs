﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TempTesteSmartUpdate {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Host=localhost;Username=postgres;Password=yu45thn@;Database=smart")]
        public string ConexaoLocal {
            get {
                return ((string)(this["ConexaoLocal"]));
            }
            set {
                this["ConexaoLocal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("hostaddr=127.0.0.1 port=5433 dbname=smt user=postgres password=yu45thn@")]
        public string ConexaoRemota {
            get {
                return ((string)(this["ConexaoRemota"]));
            }
            set {
                this["ConexaoRemota"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int MoradoresLimiteDownload {
            get {
                return ((int)(this["MoradoresLimiteDownload"]));
            }
            set {
                this["MoradoresLimiteDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExecutarAtualizacaoAoIniciar {
            get {
                return ((bool)(this["ExecutarAtualizacaoAoIniciar"]));
            }
            set {
                this["ExecutarAtualizacaoAoIniciar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("atualizarcadastros_moradores")]
        public string MoradoresProcedimentoDownload {
            get {
                return ((string)(this["MoradoresProcedimentoDownload"]));
            }
            set {
                this["MoradoresProcedimentoDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int VeiculosLimiteDownload {
            get {
                return ((int)(this["VeiculosLimiteDownload"]));
            }
            set {
                this["VeiculosLimiteDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("atualizarcadastros_veiculos")]
        public string VeiculosProcedimentoDownload {
            get {
                return ((string)(this["VeiculosProcedimentoDownload"]));
            }
            set {
                this["VeiculosProcedimentoDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MoradoresIntervaloDownload {
            get {
                return ((int)(this["MoradoresIntervaloDownload"]));
            }
            set {
                this["MoradoresIntervaloDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int VeiculosIntervaloDownload {
            get {
                return ((int)(this["VeiculosIntervaloDownload"]));
            }
            set {
                this["VeiculosIntervaloDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int UploadIntervalo {
            get {
                return ((int)(this["UploadIntervalo"]));
            }
            set {
                this["UploadIntervalo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("atualizarpassagens")]
        public string UploadProcedimento {
            get {
                return ((string)(this["UploadProcedimento"]));
            }
            set {
                this["UploadProcedimento"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int UploadLimiteTransferencia {
            get {
                return ((int)(this["UploadLimiteTransferencia"]));
            }
            set {
                this["UploadLimiteTransferencia"] = value;
            }
        }
    }
}
