/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PollinationSDK
{
    /// <summary>
    /// RepositoryUserPermissions
    /// </summary>
    [DataContract(Name = "RepositoryUserPermissions")]
    public partial class RepositoryUserPermissions : UserPermission, IEquatable<RepositoryUserPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryUserPermissions" /> class.
        /// </summary>
        /// <param name="admin">The user has admin permission to this resource (default to false).</param>
        /// <param name="write">The user has write permission on this resource (default to false).</param>
        /// <param name="read">The user has read permission on this resource (default to false).</param>
        public RepositoryUserPermissions
        (
            // Required parameters
            bool admin = false, bool write = false, bool read = false // Optional parameters
        ) : base(admin: admin, write: write, read: read )// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryUserPermissions";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "RepositoryUserPermissions";


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RepositoryUserPermissions";
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
            sb.Append("RepositoryUserPermissions:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Admin: ").Append(this.Admin).Append("\n");
            sb.Append("  Write: ").Append(this.Write).Append("\n");
            sb.Append("  Read: ").Append(this.Read).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RepositoryUserPermissions object</returns>
        public static RepositoryUserPermissions FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryUserPermissions>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryUserPermissions object</returns>
        public virtual RepositoryUserPermissions DuplicateRepositoryUserPermissions()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRepositoryUserPermissions();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override UserPermission DuplicateUserPermission()
        {
            return DuplicateRepositoryUserPermissions();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RepositoryUserPermissions);
        }

        /// <summary>
        /// Returns true if RepositoryUserPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryUserPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryUserPermissions input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type);
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
            Regex regexType = new Regex(@"^RepositoryUserPermissions$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
