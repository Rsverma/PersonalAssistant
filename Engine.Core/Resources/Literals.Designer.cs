﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engine.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Literals {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Literals() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Engine.Core.Resources.Literals", typeof(Literals).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Good afternoon {0}..
        /// </summary>
        internal static string Greeting_Afternoon {
            get {
                return ResourceManager.GetString("Greeting_Afternoon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Good evening {0}..
        /// </summary>
        internal static string Greeting_Evening {
            get {
                return ResourceManager.GetString("Greeting_Evening", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Good morning {0}..
        /// </summary>
        internal static string Greeting_General {
            get {
                return ResourceManager.GetString("Greeting_General", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to नमस्ते {0}..
        /// </summary>
        internal static string Greeting_Morning {
            get {
                return ResourceManager.GetString("Greeting_Morning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to आज का टेम्परेचर {0} डिग्री रहेगा..
        /// </summary>
        internal static string Weather_CurrentTemperature {
            get {
                return ResourceManager.GetString("Weather_CurrentTemperature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Today&apos;s low will be {0}, and the high will be {1}..
        /// </summary>
        internal static string Weather_LowHighTemperatures {
            get {
                return ResourceManager.GetString("Weather_LowHighTemperatures", resourceCulture);
            }
        }
    }
}
