/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PollinationSDK
{
    /// <summary>
    /// LicensePoolAccessPolicy
    /// </summary>
    [DataContract(Name = "LicensePoolAccessPolicy")]
    public partial class LicensePoolAccessPolicy : OpenAPIGenBaseModel, IEquatable<LicensePoolAccessPolicy>, IValidatableObject
    {
        /// <summary>
        /// Accessors may only have read access
        /// </summary>
        /// <value>Accessors may only have read access</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public Permission Permission { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolAccessPolicy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicensePoolAccessPolicy() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "LicensePoolAccessPolicy";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolAccessPolicy" /> class.
        /// </summary>
        /// <param name="subject">The subject of the access policy (required).</param>
        /// <param name="permission">Accessors may only have read access.</param>
        public LicensePoolAccessPolicy
        (
           PolicySubject subject, // Required parameters
           Permission permission= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "subject" is required (not null)
            this.Subject = subject ?? throw new ArgumentNullException("subject is a required property for LicensePoolAccessPolicy and cannot be null");
            this.Permission = permission;

            // Set non-required readonly properties with defaultValue
            this.Type = "LicensePoolAccessPolicy";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "LicensePoolAccessPolicy";

        /// <summary>
        /// The subject of the access policy
        /// </summary>
        /// <value>The subject of the access policy</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public PolicySubject Subject { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "LicensePoolAccessPolicy";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("LicensePoolAccessPolicy:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>LicensePoolAccessPolicy object</returns>
        public static LicensePoolAccessPolicy FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolAccessPolicy>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolAccessPolicy object</returns>
        public virtual LicensePoolAccessPolicy DuplicateLicensePoolAccessPolicy()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateLicensePoolAccessPolicy();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateLicensePoolAccessPolicy();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as LicensePoolAccessPolicy);
        }

        /// <summary>
        /// Returns true if LicensePoolAccessPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolAccessPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolAccessPolicy input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && base.Equals(input) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^LicensePoolAccessPolicy$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}