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
    /// SubscriptionItemList
    /// </summary>
    [DataContract(Name = "SubscriptionItemList")]
    public partial class SubscriptionItemList : OpenAPIGenBaseModel, IEquatable<SubscriptionItemList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionItemList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionItemList() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "SubscriptionItemList";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionItemList" /> class.
        /// </summary>
        /// <param name="hasMore">hasMore (required).</param>
        /// <param name="data">data (required).</param>
        public SubscriptionItemList
        (
           bool hasMore, List<AnyOf<SubscriptionItem,DeleteSubscriptionItem>> data// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            this.HasMore = hasMore;
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for SubscriptionItemList and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "SubscriptionItemList";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "SubscriptionItemList";

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name = "has_more", IsRequired = true, EmitDefaultValue = false)]
        public bool HasMore { get; set; } 
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public List<AnyOf<SubscriptionItem,DeleteSubscriptionItem>> Data { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SubscriptionItemList";
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
            sb.Append("SubscriptionItemList:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SubscriptionItemList object</returns>
        public static SubscriptionItemList FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionItemList>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionItemList object</returns>
        public virtual SubscriptionItemList DuplicateSubscriptionItemList()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSubscriptionItemList();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSubscriptionItemList();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SubscriptionItemList);
        }

        /// <summary>
        /// Returns true if SubscriptionItemList instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionItemList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionItemList input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
                ) && base.Equals(input) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
            Regex regexType = new Regex(@"^SubscriptionItemList$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}