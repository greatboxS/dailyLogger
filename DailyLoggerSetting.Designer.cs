﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DailyLogger {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class DailyLoggerSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static DailyLoggerSetting defaultInstance = ((DailyLoggerSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DailyLoggerSetting())));
        
        public static DailyLoggerSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"\"")]
        public string BaseFolder {
            get {
                return ((string)(this["BaseFolder"]));
            }
            set {
                this["BaseFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"\"")]
        public string LoggerType {
            get {
                return ((string)(this["LoggerType"]));
            }
            set {
                this["LoggerType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"\"")]
        public string ShotKeys {
            get {
                return ((string)(this["ShotKeys"]));
            }
            set {
                this["ShotKeys"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"\"")]
        public string DailyLoggerViewModels {
            get {
                return ((string)(this["DailyLoggerViewModels"]));
            }
            set {
                this["DailyLoggerViewModels"] = value;
            }
        }
    }
}