﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Globalization.Analyzers {
    using System;
    using System.Reflection;
    
    
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
    internal class SystemGlobalizationAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SystemGlobalizationAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Globalization.Analyzers.SystemGlobalizationAnalyzersResources", typeof(SystemGlobalizationAnalyzersResources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to If an overload exists that takes a CultureInfo argument, it should always be called in favor of an overload that does not. The CultureInfo type contains culture-specific information required for performing numeric and string operations, such as casing, formatting, and string comparisons. In scenarios where conversion and parsing behavior should never change between cultures, specify CultureInfo.InvariantCulture, otherwise, specify CultureInfo.CurrentCulture..
        /// </summary>
        internal static string SpecifyCultureInfoDescription {
            get {
                return ResourceManager.GetString("SpecifyCultureInfoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Because the behavior of &apos;{0}&apos; could vary based on the current user&apos;s locale settings, replace this call in &apos;{1}&apos; with a call to &apos;{2}&apos;. If the result of &apos;{2}&apos; will be displayed to the user, specify &apos;CultureInfo.CurrentCulture&apos; as the &apos;CultureInfo&apos; parameter. Otherwise, if the result will be stored and accessed by software, such as when it is persisted to disk or to a database, specify &apos;CultureInfo.InvariantCulture&apos;..
        /// </summary>
        internal static string SpecifyCultureInfoDiagnosis {
            get {
                return ResourceManager.GetString("SpecifyCultureInfoDiagnosis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify CultureInfo.
        /// </summary>
        internal static string SpecifyCultureInfoTitle {
            get {
                return ResourceManager.GetString("SpecifyCultureInfoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an overload exists that takes an IFormatProvider argument, it should always be called in favor of an overload that does not. Some methods in the runtime convert a value to or from a string representation and take a string parameter that contains one or more characters, called format specifiers, which indicate how the value is to be converted. If the meaning of the format specifier varies by culture, a formatting object supplies the actual characters used in the string representation. In scenarios where s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpecifyIFormatProviderDescription {
            get {
                return ResourceManager.GetString("SpecifyIFormatProviderDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Because the behavior of &apos;{0}&apos; could vary based on the current user&apos;s locale settings, replace this call in &apos;{1}&apos; with a call to &apos;{2}&apos;. If the result of &apos;{2}&apos; will be based on input from the user, specify &apos;CultureInfo.CurrentCulture&apos; as the &apos;IFormatProvider&apos; parameter. Otherwise, if the result will based on input stored and accessed by software, such as when it is loaded from disk or from a database, specify &apos;CultureInfo.InvariantCulture&apos;..
        /// </summary>
        internal static string SpecifyIFormatProviderDiagnosisAlternate {
            get {
                return ResourceManager.GetString("SpecifyIFormatProviderDiagnosisAlternate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Because the behavior of &apos;{0}&apos; could vary based on the current user&apos;s locale settings, replace this call in &apos;{1}&apos; with a call to &apos;{2}&apos;. If the result of &apos;{2}&apos; will be displayed to the user, specify &apos;CultureInfo.CurrentCulture&apos; as the &apos;IFormatProvider&apos; parameter. Otherwise, if the result will be stored and accessed by software, such as when it is persisted to disk or to a database, specify &apos;CultureInfo.InvariantCulture&apos;..
        /// </summary>
        internal static string SpecifyIFormatProviderDiagnosisAlternateString {
            get {
                return ResourceManager.GetString("SpecifyIFormatProviderDiagnosisAlternateString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; passes &apos;{1}&apos; as the &apos;IFormatProvider&apos; parameter to &apos;{2}&apos;. This property returns a culture that is inappropriate for formatting methods. If the result of &apos;{2}&apos; will be based on input from the user, specify &apos;CultureInfo.CurrentCulture&apos; as the &apos;IFormatProvider&apos; parameter. Otherwise, if the result will based on input stored and accessed by software, such as when it is loaded from disk or from a database, specify &apos;CultureInfo.InvariantCulture&apos;..
        /// </summary>
        internal static string SpecifyIFormatProviderDiagnosisUICulture {
            get {
                return ResourceManager.GetString("SpecifyIFormatProviderDiagnosisUICulture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; passes &apos;{1}&apos; as the &apos;IFormatProvider&apos; parameter to &apos;{2}&apos;. This property returns a culture that is inappropriate for formatting methods. If the result of &apos;{2}&apos; will be displayed to the user, specify &apos;CultureInfo.CurrentCulture&apos; as the &apos;IFormatProvider&apos; parameter. Otherwise, if the result will be stored and accessed by software, such as when it is persisted to disk or to a database, specify &apos;CultureInfo.InvariantCulture&apos;..
        /// </summary>
        internal static string SpecifyIFormatProviderDiagnosisUICultureString {
            get {
                return ResourceManager.GetString("SpecifyIFormatProviderDiagnosisUICultureString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify IFormatProvider.
        /// </summary>
        internal static string SpecifyIFormatProviderTitle {
            get {
                return ResourceManager.GetString("SpecifyIFormatProviderTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an overload exists that takes a StringComparison argument, it should always be called in favor of an overload that does not..
        /// </summary>
        internal static string SpecifyStringComparisonDescription {
            get {
                return ResourceManager.GetString("SpecifyStringComparisonDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Because the behavior of &apos;{0}&apos; could vary based on the current user&apos;s locale settings, replace this call in &apos;{1}&apos; with a call to &apos;{2}&apos;. If the result of &apos;{2}&apos; will be displayed to the user, such as when sorting a list of items for display in a list box, specify &apos;StringComparison.CurrentCulture&apos; or &apos;StringComparison.CurrentCultureIgnoreCase&apos; as the &apos;StringComparison&apos; parameter. If comparing case-insensitive identifiers, such as file paths, environment variables, or registry keys and values, specify &apos;StringCom [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpecifyStringComparisonDiagnosis {
            get {
                return ResourceManager.GetString("SpecifyStringComparisonDiagnosis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify StringComparison.
        /// </summary>
        internal static string SpecifyStringComparisonTitle {
            get {
                return ResourceManager.GetString("SpecifyStringComparisonTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; passes &apos;{1}&apos; as the &apos;StringComparer&apos; parameter to &apos;{2}&apos;. To perform a non-linguistic comparison, specify &apos;StringComparer.Ordinal&apos; or &apos;StringComparer.OrdinalIgnoreCase&apos; instead..
        /// </summary>
        internal static string UseOrdinalStringComparerDiagnosis {
            get {
                return ResourceManager.GetString("UseOrdinalStringComparerDiagnosis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; uses &apos;{1}&apos; as the default argument corresponding to the optional &apos;StringComparison&apos; parameter. To perform a non-linguistic comparison, specify &apos;StringComparison.Ordinal&apos; or &apos;StringComparison.OrdinalIgnoreCase&apos; instead..
        /// </summary>
        internal static string UseOrdinalStringComparisonDefaultDiagnosis {
            get {
                return ResourceManager.GetString("UseOrdinalStringComparisonDefaultDiagnosis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For non-linguistic comparisons, StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase should be used instead of the linguistically-sensitive StringComparison.InvariantCulture..
        /// </summary>
        internal static string UseOrdinalStringComparisonDescription {
            get {
                return ResourceManager.GetString("UseOrdinalStringComparisonDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; passes &apos;{1}&apos; as the &apos;StringComparison&apos; parameter to &apos;{2}&apos;. To perform a non-linguistic comparison, specify &apos;StringComparison.Ordinal&apos; or &apos;StringComparison.OrdinalIgnoreCase&apos; instead..
        /// </summary>
        internal static string UseOrdinalStringComparisonDiagnosis {
            get {
                return ResourceManager.GetString("UseOrdinalStringComparisonDiagnosis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use ordinal StringComparison.
        /// </summary>
        internal static string UseOrdinalStringComparisonTitle {
            get {
                return ResourceManager.GetString("UseOrdinalStringComparisonTitle", resourceCulture);
            }
        }
    }
}
