﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroLite {
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
    internal class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MicroLite.ExceptionMessages", typeof(ExceptionMessages).Assembly);
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
        ///   Looks up a localized string similar to The Encryption algorithm is missing, please add the following value to app.settings: &lt;add key=&quot;MicroLite.DbEncryptedString.SymmetricAlgorithm&quot; value=&quot;AesManaged&quot; /&gt; (see http://msdn.microsoft.com/en-us/library/System.Security.Cryptography.SymmetricAlgorithm(v=vs.110).aspx for the fully supported list of values).
        /// </summary>
        internal static string AppSettingSymmetricAlgorithmProvider_MissingAlgorithm {
            get {
                return ResourceManager.GetString("AppSettingSymmetricAlgorithmProvider_MissingAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Encryption key is missing, please add the following value to app.settings: &lt;add key=&quot;MicroLite.DbEncryptedString.EncryptionKey&quot; value=&quot;replace-with-your-encryption-key&quot; /&gt;.
        /// </summary>
        internal static string AppSettingSymmetricAlgorithmProvider_MissingKey {
            get {
                return ResourceManager.GetString("AppSettingSymmetricAlgorithmProvider_MissingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be used by MicroLite as is not decorated with a TableAttribute for further information about using the Attribute base Mapping, see the wiki or blog.
        /// </summary>
        internal static string AttributeMappingConvention_NoTableAttribute {
            get {
                return ResourceManager.GetString("AttributeMappingConvention_NoTableAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of parameters in the SQL statement and the number of specified parameter arguments should match. However &apos;{0}&apos; parameters used in the SQL statement and &apos;{1}&apos; parameter arguments were specified..
        /// </summary>
        internal static string DbDriver_ArgumentsCountMismatch {
            get {
                return ResourceManager.GetString("DbDriver_ArgumentsCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cipher text is invalid, it should contain 2 parts separated by an &apos;@&apos;.
        /// </summary>
        internal static string DbEncryptedStringTypeConverter_CipherTextInvalid {
            get {
                return ResourceManager.GetString("DbEncryptedStringTypeConverter_CipherTextInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;dynamic&apos; type can only be used for queries where an SqlQuery is supplied, it cannot be used for select by identifier, insert, update or delete..
        /// </summary>
        internal static string ExpandoObjectInfo_NotSupportedReason {
            get {
                return ResourceManager.GetString("ExpandoObjectInfo_NotSupportedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection string was found in the &lt;connectionStrings&gt; section of the app/web.config with the name &apos;{0}&apos;..
        /// </summary>
        internal static string FluentConfiguration_ConnectionNotFound {
            get {
                return ResourceManager.GetString("FluentConfiguration_ConnectionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple records have been returned by the query, the query should return a single row only..
        /// </summary>
        internal static string Include_SingleRecordExpected {
            get {
                return ResourceManager.GetString("Include_SingleRecordExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scalar query should return a single row with a single column.
        /// </summary>
        internal static string IncludeScalar_MultipleColumns {
            get {
                return ResourceManager.GetString("IncludeScalar_MultipleColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object cannot be inserted as it does not have an identifier value set and the identifier strategy specifies that it should be assigned before being inserted..
        /// </summary>
        internal static string ObjectInfo_IdentifierNotSetForInsert {
            get {
                return ResourceManager.GetString("ObjectInfo_IdentifierNotSetForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object already has an identifier value so it cannot be inserted.
        /// </summary>
        internal static string ObjectInfo_IdentifierSetForInsert {
            get {
                return ResourceManager.GetString("ObjectInfo_IdentifierSetForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of the object {0} does not match the type for the ObjectInfo {1}.
        /// </summary>
        internal static string ObjectInfo_TypeMismatch {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not a class and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustBeClass {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustBeClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be used by the MicroLite ORM Framework unless it is declared &apos;public&apos;.
        /// </summary>
        internal static string ObjectInfo_TypeMustBePublic {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustBePublic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; has no default (parameterless) constructor and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustHaveDefaultConstructor {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustHaveDefaultConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is abstract and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustNotBeAbstract {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustNotBeAbstract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first page which can be requested is page 1.
        /// </summary>
        internal static string PagingOptions_PagesMustBeAtleastOne {
            get {
                return ResourceManager.GetString("PagingOptions_PagesMustBeAtleastOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There must be at least 1 result per page.
        /// </summary>
        internal static string PagingOptions_ResultsPerPageMustBeAtLeast1 {
            get {
                return ResourceManager.GetString("PagingOptions_ResultsPerPageMustBeAtLeast1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to skip less than 0 results.
        /// </summary>
        internal static string PagingOptions_SkipMustBeZeroOrAbove {
            get {
                return ResourceManager.GetString("PagingOptions_SkipMustBeZeroOrAbove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least 1 result must be returned.
        /// </summary>
        internal static string PagingOptions_TakeMustBeZeroOrAbove {
            get {
                return ResourceManager.GetString("PagingOptions_TakeMustBeZeroOrAbove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object does not have an identifier value set so it cannot be deleted.
        /// </summary>
        internal static string Session_IdentifierNotSetForDelete {
            get {
                return ResourceManager.GetString("Session_IdentifierNotSetForDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object does not have an identifier value set so it cannot be updated.
        /// </summary>
        internal static string Session_IdentifierNotSetForUpdate {
            get {
                return ResourceManager.GetString("Session_IdentifierNotSetForUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The paging options must contain a count and offset, use the PagingOptions.ForPage or PagingOptions.SkipTake methods to specify the values.
        /// </summary>
        internal static string Session_PagingOptionsMustNotBeNone {
            get {
                return ResourceManager.GetString("Session_PagingOptionsMustNotBeNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column &apos;{0}&apos; has been mapped multiple times, this usually occurs if multiple properties have the same column name specified in the column attribute.
        /// </summary>
        internal static string TableInfo_ColumnMappedMultipleTimes {
            get {
                return ResourceManager.GetString("TableInfo_ColumnMappedMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple columns have been mapped as the identifier for the table &apos;{0}.{1}&apos;.
        /// </summary>
        internal static string TableInfo_MultipleIdentifierColumns {
            get {
                return ResourceManager.GetString("TableInfo_MultipleIdentifierColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No column has been mapped as the identifier for the table &apos;{0}.{1}&apos;.
        /// </summary>
        internal static string TableInfo_NoIdentifierColumn {
            get {
                return ResourceManager.GetString("TableInfo_NoIdentifierColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction has been completed.
        /// </summary>
        internal static string Transaction_AlreadyCompleted {
            get {
                return ResourceManager.GetString("Transaction_AlreadyCompleted", resourceCulture);
            }
        }
    }
}