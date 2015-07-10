﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarQube.TeamBuild.PreProcessor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarQube.TeamBuild.PreProcessor.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /key:{SonarQube project key}.
        /// </summary>
        public static string CmdLine_ArgDescription_ProjectKey {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /name:{SonarQube project name}.
        /// </summary>
        public static string CmdLine_ArgDescription_ProjectName {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /version:{SonarQube project version}.
        /// </summary>
        public static string CmdLine_ArgDescription_ProjectVersion {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating config and output folders....
        /// </summary>
        public static string DIAG_CreatingFolders {
            get {
                return ResourceManager.GetString("DIAG_CreatingFolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating the FxCop ruleset: {0}.
        /// </summary>
        public static string DIAG_GeneratingRuleset {
            get {
                return ResourceManager.GetString("DIAG_GeneratingRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving the config file to {0}.
        /// </summary>
        public static string DIAG_SavingConfigFile {
            get {
                return ResourceManager.GetString("DIAG_SavingConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarQube pre-processing cannot be performed - required settings are missing.
        /// </summary>
        public static string ERROR_CannotPerformProcessing {
            get {
                return ResourceManager.GetString("ERROR_CannotPerformProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following CheckId should not appear multiple times: {0}.
        /// </summary>
        public static string ERROR_DuplicateCheckId {
            get {
                return ResourceManager.GetString("ERROR_DuplicateCheckId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting at least three command line arguments:
        ///- SonarQube project key
        ///- SonarQube project name
        ///- SonarQube project version
        ///The full path to a settings file can also be supplied. If it is not supplied, the exe will attempt to locate a default settings file in the same directory as the SonarQube.MSBuild.Runner..
        /// </summary>
        public static string ERROR_InvalidCommandLineArgs {
            get {
                return ResourceManager.GetString("ERROR_InvalidCommandLineArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are using MSBuild SonarQube Runner 0.9 which is not compatible with the current C# plugin. Please upgrade the MSBuild SonarQube Runner located on the build agent..
        /// </summary>
        public static string ERROR_InvokedFromBootstrapper0_9 {
            get {
                return ResourceManager.GetString("ERROR_InvokedFromBootstrapper0_9", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SonarQube server url was not configured. Do not call the PreProcessor executable directly - use the SonarQube.MSBuild.Runner.exe instead..
        /// </summary>
        public static string ERROR_NoHostUrl {
            get {
                return ResourceManager.GetString("ERROR_NoHostUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while trying to connect to the SonarQube server. Please check that the web server is accessible. Url {0}.
        /// </summary>
        public static string ERROR_WebException {
            get {
                return ResourceManager.GetString("ERROR_WebException", resourceCulture);
            }
        }
    }
}
