﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engine.Core {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Application : global::System.Configuration.ApplicationSettingsBase {
        
        private static Application defaultInstance = ((Application)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Application())));
        
        public static Application Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("e6e48c70fe025013c0c4fdf06cc9b7d3")]
        public string OWMAPIKey {
            get {
                return ((string)(this["OWMAPIKey"]));
            }
        }
    }
}
