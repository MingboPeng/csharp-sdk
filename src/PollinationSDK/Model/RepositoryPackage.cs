/* 
 * Pollination Server
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
using QueenbeeSDK;

namespace PollinationSDK
{
    /// <summary>
    /// RepositoryPackage
    /// </summary>
    [DataContract(Name = "RepositoryPackage")]
    public partial class RepositoryPackage : OpenAPIGenBaseModel, IEquatable<RepositoryPackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepositoryPackage() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryPackage";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPackage" /> class.
        /// </summary>
        /// <param name="digest">The new package digest (required).</param>
        /// <param name="tag">The new package tag (required).</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="description">description.</param>
        /// <param name="icon">icon.</param>
        /// <param name="createdAt">Creation Timestamp.</param>
        /// <param name="readme">The Repository Readme.</param>
        public RepositoryPackage
        (
           string digest, string tag, // Required parameters
           List<string> keywords= default, string description= default, string icon= default, DateTime createdAt= default, string readme= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "digest" is required (not null)
            this.Digest = digest ?? throw new ArgumentNullException("digest is a required property for RepositoryPackage and cannot be null");
            // to ensure "tag" is required (not null)
            this.Tag = tag ?? throw new ArgumentNullException("tag is a required property for RepositoryPackage and cannot be null");
            this.Keywords = keywords;
            this.Description = description;
            this.Icon = icon;
            this.CreatedAt = createdAt;
            this.Readme = readme;

            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryPackage";
        }

        /// <summary>
        /// The new package digest
        /// </summary>
        /// <value>The new package digest</value>
        [DataMember(Name = "digest", IsRequired = true, EmitDefaultValue = false)]
        public string Digest { get; set; } 
        /// <summary>
        /// The new package tag
        /// </summary>
        /// <value>The new package tag</value>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = false)]
        public string Tag { get; set; } 
        /// <summary>
        /// keywords
        /// </summary>
        /// <value>keywords</value>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public List<string> Keywords { get; set; } 
        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } 
        /// <summary>
        /// icon
        /// </summary>
        /// <value>icon</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; } 
        /// <summary>
        /// Creation Timestamp
        /// </summary>
        /// <value>Creation Timestamp</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; } 
        /// <summary>
        /// The Repository Readme
        /// </summary>
        /// <value>The Repository Readme</value>
        [DataMember(Name = "readme", EmitDefaultValue = false)]
        public string Readme { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RepositoryPackage";
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
            sb.Append("RepositoryPackage:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Readme: ").Append(Readme).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RepositoryPackage object</returns>
        public static RepositoryPackage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryPackage>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryPackage object</returns>
        public virtual RepositoryPackage DuplicateRepositoryPackage()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRepositoryPackage();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRepositoryPackage();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryPackage);
        }

        /// <summary>
        /// Returns true if RepositoryPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryPackage input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && base.Equals(input) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && base.Equals(input) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.Readme == input.Readme ||
                    (this.Readme != null &&
                    this.Readme.Equals(input.Readme))
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
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Readme != null)
                    hashCode = hashCode * 59 + this.Readme.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^RepositoryPackage$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}