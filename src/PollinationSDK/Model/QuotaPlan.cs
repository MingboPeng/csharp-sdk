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
    /// QuotaPlan
    /// </summary>
    [DataContract(Name = "QuotaPlan")]
    public partial class QuotaPlan : OpenAPIGenBaseModel, IEquatable<QuotaPlan>, IValidatableObject
    {
        /// <summary>
        /// The name of the quota
        /// </summary>
        /// <value>The name of the quota</value>
        [DataMember(Name="quota_type")]
        public QuotaType QuotaType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaPlan() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPlan" /> class.
        /// </summary>
        /// <param name="resets">Whether consumption is reset to 0 every month (default to false).</param>
        /// <param name="limit">The maximum amount of a resource that a subscription allows.</param>
        /// <param name="enforced">Whether the limit is triggers a blocking response from the server (default to false).</param>
        /// <param name="maxLimit">The maximum amount of a resource that a subscription allows.</param>
        /// <param name="displayName">The human-readable name.</param>
        /// <param name="description">The description.</param>
        /// <param name="unit">The unit in which the usage and limit are measured.</param>
        public QuotaPlan
        (
           // Required parameters
           bool resets = false, double limit= default, bool enforced = false, double maxLimit= default, string displayName= default, string description= default, string unit= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Resets = resets;
            this.Limit = limit;
            this.Enforced = enforced;
            this.MaxLimit = maxLimit;
            this.DisplayName = displayName;
            this.Description = description;
            this.Unit = unit;

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// Whether consumption is reset to 0 every month
        /// </summary>
        /// <value>Whether consumption is reset to 0 every month</value>
        [DataMember(Name = "resets")]
        public bool Resets { get; set; }  = false;
        /// <summary>
        /// The maximum amount of a resource that a subscription allows
        /// </summary>
        /// <value>The maximum amount of a resource that a subscription allows</value>
        [DataMember(Name = "limit")]
        public double Limit { get; set; } 
        /// <summary>
        /// Whether the limit is triggers a blocking response from the server
        /// </summary>
        /// <value>Whether the limit is triggers a blocking response from the server</value>
        [DataMember(Name = "enforced")]
        public bool Enforced { get; set; }  = false;
        /// <summary>
        /// The maximum amount of a resource that a subscription allows
        /// </summary>
        /// <value>The maximum amount of a resource that a subscription allows</value>
        [DataMember(Name = "max_limit")]
        public double MaxLimit { get; set; } 
        /// <summary>
        /// The human-readable name
        /// </summary>
        /// <value>The human-readable name</value>
        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; } 
        /// <summary>
        /// The description
        /// </summary>
        /// <value>The description</value>
        [DataMember(Name = "description")]
        public string Description { get; set; } 
        /// <summary>
        /// The unit in which the usage and limit are measured
        /// </summary>
        /// <value>The unit in which the usage and limit are measured</value>
        [DataMember(Name = "unit")]
        public string Unit { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "QuotaPlan";
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
            sb.Append("QuotaPlan:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Resets: ").Append(this.Resets).Append("\n");
            sb.Append("  Limit: ").Append(this.Limit).Append("\n");
            sb.Append("  Enforced: ").Append(this.Enforced).Append("\n");
            sb.Append("  MaxLimit: ").Append(this.MaxLimit).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Unit: ").Append(this.Unit).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>QuotaPlan object</returns>
        public static QuotaPlan FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<QuotaPlan>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>QuotaPlan object</returns>
        public virtual QuotaPlan DuplicateQuotaPlan()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateQuotaPlan();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateQuotaPlan();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as QuotaPlan);
        }

        /// <summary>
        /// Returns true if QuotaPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaPlan input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.Resets, input.Resets) && 
                    Extension.Equals(this.Limit, input.Limit) && 
                    Extension.Equals(this.Enforced, input.Enforced) && 
                    Extension.Equals(this.MaxLimit, input.MaxLimit) && 
                    Extension.Equals(this.DisplayName, input.DisplayName) && 
                    Extension.Equals(this.Description, input.Description) && 
                    Extension.Equals(this.Unit, input.Unit);
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
                if (this.Resets != null)
                    hashCode = hashCode * 59 + this.Resets.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Enforced != null)
                    hashCode = hashCode * 59 + this.Enforced.GetHashCode();
                if (this.MaxLimit != null)
                    hashCode = hashCode * 59 + this.MaxLimit.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
            yield break;
        }
    }
}
