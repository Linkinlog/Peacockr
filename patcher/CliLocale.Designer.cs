﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HitmanPatcher {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CliLocale {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CliLocale() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("HitmanPatcher.CliLocale", typeof(CliLocale).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string HeadlessDescription {
            get {
                return ResourceManager.GetString("HeadlessDescription", resourceCulture);
            }
        }
        
        internal static string DomainDescription {
            get {
                return ResourceManager.GetString("DomainDescription", resourceCulture);
            }
        }
        
        internal static string UseHttpDescription {
            get {
                return ResourceManager.GetString("UseHttpDescription", resourceCulture);
            }
        }
        
        internal static string OptionalDynResDescription {
            get {
                return ResourceManager.GetString("OptionalDynResDescription", resourceCulture);
            }
        }
        
        internal static string HeadlessBanner {
            get {
                return ResourceManager.GetString("HeadlessBanner", resourceCulture);
            }
        }
        
        internal static string HelpHeader {
            get {
                return ResourceManager.GetString("HelpHeader", resourceCulture);
            }
        }
        
        internal static string PatchSteamDescription {
            get {
                return ResourceManager.GetString("PatchSteamDescription", resourceCulture);
            }
        }
    }
}
