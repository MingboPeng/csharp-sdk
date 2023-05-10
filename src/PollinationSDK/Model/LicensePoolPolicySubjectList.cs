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
    /// LicensePoolPolicySubjectList
    /// </summary>
    [DataContract(Name = "LicensePoolPolicySubjectList")]
    public partial class LicensePoolPolicySubjectList : OpenAPIGenBaseModel, IEquatable<LicensePoolPolicySubjectList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePoolPolicySubjectList" /> class.
        /// </summary>
        /// <param name="resources">The list of subjects which currently have access to the pool.</param>
        public LicensePoolPolicySubjectList
        (
           // Required parameters
           List<LicensePoolPolicySubject> resources= default // Optional parameters
        ) : base()// BaseClass
        {
            this.Resources = resources;

            // Set non-required readonly properties with defaultValue
            this.Type = "LicensePoolPolicySubjectList";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "LicensePoolPolicySubjectList";

        /// <summary>
        /// The list of subjects which currently have access to the pool
        /// </summary>
        /// <value>The list of subjects which currently have access to the pool</value>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public List<LicensePoolPolicySubject> Resources { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "LicensePoolPolicySubjectList";
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
            sb.Append("LicensePoolPolicySubjectList:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>LicensePoolPolicySubjectList object</returns>
        public static LicensePoolPolicySubjectList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePoolPolicySubjectList>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePoolPolicySubjectList object</returns>
        public virtual LicensePoolPolicySubjectList DuplicateLicensePoolPolicySubjectList()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateLicensePoolPolicySubjectList();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateLicensePoolPolicySubjectList();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as LicensePoolPolicySubjectList);
        }

        /// <summary>
        /// Returns true if LicensePoolPolicySubjectList instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePoolPolicySubjectList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePoolPolicySubjectList input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
            Regex regexType = new Regex(@"^LicensePoolPolicySubjectList$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
