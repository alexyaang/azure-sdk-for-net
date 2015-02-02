﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Common.Authentication.Properties
{


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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Common.Authentication.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Account needs to be specified.
        /// </summary>
        public static string AccountNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("AccountNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Azure Powershell.
        /// </summary>
        public static string AzureDirectoryName {
            get {
                return ResourceManager.GetString("AzureDirectoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No certificate was found in the certificate store with thumbprint {0}.
        /// </summary>
        public static string CertificateNotFoundInStore {
            get {
                return ResourceManager.GetString("CertificateNotFoundInStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changing public environment is not supported..
        /// </summary>
        public static string ChangingDefaultEnvironmentNotSupported {
            get {
                return ResourceManager.GetString("ChangingDefaultEnvironmentNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -Credential parameter can only be used with Organization ID credentials. For more information, please refer to http://go.microsoft.com/fwlink/?linkid=331007&amp;clcid=0x409 for more information about the difference between an organizational account and a Microsoft account..
        /// </summary>
        public static string CredentialOrganizationIdMessage {
            get {
                return ResourceManager.GetString("CredentialOrganizationIdMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment name needs to be specified.
        /// </summary>
        public static string EnvironmentNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("EnvironmentNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment needs to be specified.
        /// </summary>
        public static string EnvironmentNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("EnvironmentNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The environment name &apos;{0}&apos; is not found..
        /// </summary>
        public static string EnvironmentNotFound {
            get {
                return ResourceManager.GetString("EnvironmentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Microsoft Azure credential in the Windows PowerShell session has expired. Please use Add-AzureAccount to login again..
        /// </summary>
        public static string ExpiredRefreshToken {
            get {
                return ResourceManager.GetString("ExpiredRefreshToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File path is not valid.
        /// </summary>
        public static string FilePathIsNotValid {
            get {
                return ResourceManager.GetString("FilePathIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal characters in path..
        /// </summary>
        public static string IllegalPath {
            get {
                return ResourceManager.GetString("IllegalPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid certificate format. Publish settings may be corrupted. Use Get-AzurePublishSettingsFile to download updated settings.
        /// </summary>
        public static string InvalidCertificate {
            get {
                return ResourceManager.GetString("InvalidCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credential type invalid, only handles &apos;{0}&apos;.
        /// </summary>
        public static string InvalidCredentialType {
            get {
                return ResourceManager.GetString("InvalidCredentialType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Select-AzureSubscription -Default &lt;subscriptionName&gt; to set the default subscription..
        /// </summary>
        public static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is an invalid DNS name for {1}.
        /// </summary>
        public static string InvalidDnsName {
            get {
                return ResourceManager.GetString("InvalidDnsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided file in {0} must be have {1} extension.
        /// </summary>
        public static string InvalidFileExtension {
            get {
                return ResourceManager.GetString("InvalidFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create instance of management client type {0}. It does not have the expected constructor..
        /// </summary>
        public static string InvalidManagementClientType {
            get {
                return ResourceManager.GetString("InvalidManagementClientType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is invalid or empty.
        /// </summary>
        public static string InvalidOrEmptyArgumentMessage {
            get {
                return ResourceManager.GetString("InvalidOrEmptyArgumentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must specify a non-null subscription name..
        /// </summary>
        public static string InvalidSubscriptionName {
            get {
                return ResourceManager.GetString("InvalidSubscriptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Azure credentials have not been set up or have expired, please run Add-AzureAccount to set up your Azure credentials..
        /// </summary>
        public static string InvalidSubscriptionState {
            get {
                return ResourceManager.GetString("InvalidSubscriptionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please connect to internet before executing this cmdlet.
        /// </summary>
        public static string NoInternetConnection {
            get {
                return ResourceManager.GetString("NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path {0} doesn&apos;t exist..
        /// </summary>
        public static string PathDoesNotExist {
            get {
                return ResourceManager.GetString("PathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path for {0} doesn&apos;t exist in {1}..
        /// </summary>
        public static string PathDoesNotExistForElement {
            get {
                return ResourceManager.GetString("PathDoesNotExistForElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;whr={0}.
        /// </summary>
        public static string PublishSettingsFileRealmFormat {
            get {
                return ResourceManager.GetString("PublishSettingsFileRealmFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default subscription is being removed. Use Select-AzureSubscription -Default &lt;subscriptionName&gt; to select a new default subscription..
        /// </summary>
        public static string RemoveDefaultSubscription {
            get {
                return ResourceManager.GetString("RemoveDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing public environment is not supported..
        /// </summary>
        public static string RemovingDefaultEnvironmentsNotSupported {
            get {
                return ResourceManager.GetString("RemovingDefaultEnvironmentsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve service key for ServicePrincipal account {0}. Please run the Add-AzureAccount cmdlet to supply the credentials for this service principal..
        /// </summary>
        public static string ServiceKeyNotFound {
            get {
                return ResourceManager.GetString("ServiceKeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided service name {0} already exists, please pick another name.
        /// </summary>
        public static string ServiceNameExists {
            get {
                return ResourceManager.GetString("ServiceNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The subscription id {0} doesn&apos;t exist..
        /// </summary>
        public static string SubscriptionIdNotFoundMessage {
            get {
                return ResourceManager.GetString("SubscriptionIdNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription name needs to be specified.
        /// </summary>
        public static string SubscriptionNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("SubscriptionNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The subscription name {0} doesn&apos;t exist..
        /// </summary>
        public static string SubscriptionNameNotFoundMessage {
            get {
                return ResourceManager.GetString("SubscriptionNameNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription needs to be specified.
        /// </summary>
        public static string SubscriptionNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("SubscriptionNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to update mismatching Json structured: {0} {1}..
        /// </summary>
        public static string UnableToPatchJson {
            get {
                return ResourceManager.GetString("UnableToPatchJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal credential type.
        /// </summary>
        public static string UnknownCredentialType {
            get {
                return ResourceManager.GetString("UnknownCredentialType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name is not valid.
        /// </summary>
        public static string UserNameIsNotValid {
            get {
                return ResourceManager.GetString("UserNameIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name needs to be specified.
        /// </summary>
        public static string UserNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("UserNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  (x86).
        /// </summary>
        public static string x86InProgramFiles {
            get {
                return ResourceManager.GetString("x86InProgramFiles", resourceCulture);
            }
        }
    }
}
