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
    /// Quota
    /// </summary>
    [DataContract(Name = "Quota")]
    public partial class Quota : OpenAPIGenBaseModel, IEquatable<Quota>, IValidatableObject
    {
        /// <summary>
        /// The type of resource
        /// </summary>
        /// <value>The type of resource</value>
        [DataMember(Name= "quota_type")]
        public QuotaType QuotaType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Quota" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Quota() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Quota" /> class.
        /// </summary>
        /// <param name="owner">The quota owner (required).</param>
        /// <param name="id">The unique ID for this Quota.</param>
        /// <param name="periodStart">The start of the quota usage tracking period.</param>
        /// <param name="limit">The maximum amount of a resource the account can consume.</param>
        /// <param name="usage">The current amount of a resource allocated to the account linked to the subscription.</param>
        /// <param name="resets">Whether consumption is reset to 0 every billing period (default to false).</param>
        /// <param name="enforced">Whether the limit triggers a blocking response from the server (default to false).</param>
        /// <param name="exceeded">Whether the resource usage is greater than or equal to the limit (default to false).</param>
        /// <param name="displayName">The human-readable name.</param>
        /// <param name="description">The description.</param>
        /// <param name="unit">The unit in which the usage and limit are measured.</param>
        public Quota
        (
           AccountPublic owner, // Required parameters
           Guid id= default, DateTime periodStart= default, double limit= default, double usage= default, bool resets = false, bool enforced = false, bool exceeded = false, string displayName= default, string description= default, string unit= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "owner" is required (not null)
            this.Owner = owner ?? throw new ArgumentNullException("owner is a required property for Quota and cannot be null");
            this.Id = id;
            this.PeriodStart = periodStart;
            this.Limit = limit;
            this.Usage = usage;
            this.Resets = resets;
            this.Enforced = enforced;
            this.Exceeded = exceeded;
            this.DisplayName = displayName;
            this.Description = description;
            this.Unit = unit;

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// The quota owner
        /// </summary>
        /// <value>The quota owner</value>
        [DataMember(Name = "owner", IsRequired = true)]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// The unique ID for this Quota
        /// </summary>
        /// <value>The unique ID for this Quota</value>
        [DataMember(Name = "id")]
        public Guid Id { get; set; } 
        /// <summary>
        /// The start of the quota usage tracking period
        /// </summary>
        /// <value>The start of the quota usage tracking period</value>
        [DataMember(Name = "period_start")]
        public DateTime PeriodStart { get; set; } 
        /// <summary>
        /// The maximum amount of a resource the account can consume
        /// </summary>
        /// <value>The maximum amount of a resource the account can consume</value>
        [DataMember(Name = "limit")]
        public double Limit { get; set; } 
        /// <summary>
        /// The current amount of a resource allocated to the account linked to the subscription
        /// </summary>
        /// <value>The current amount of a resource allocated to the account linked to the subscription</value>
        [DataMember(Name = "usage")]
        public double Usage { get; set; } 
        /// <summary>
        /// Whether consumption is reset to 0 every billing period
        /// </summary>
        /// <value>Whether consumption is reset to 0 every billing period</value>
        [DataMember(Name = "resets")]
        public bool Resets { get; set; }  = false;
        /// <summary>
        /// Whether the limit triggers a blocking response from the server
        /// </summary>
        /// <value>Whether the limit triggers a blocking response from the server</value>
        [DataMember(Name = "enforced")]
        public bool Enforced { get; set; }  = false;
        /// <summary>
        /// Whether the resource usage is greater than or equal to the limit
        /// </summary>
        /// <value>Whether the resource usage is greater than or equal to the limit</value>
        [DataMember(Name = "exceeded")]
        public bool Exceeded { get; set; }  = false;
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
            return "Quota";
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
            sb.Append("Quota:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Owner: ").Append(this.Owner).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  PeriodStart: ").Append(this.PeriodStart).Append("\n");
            sb.Append("  Limit: ").Append(this.Limit).Append("\n");
            sb.Append("  Usage: ").Append(this.Usage).Append("\n");
            sb.Append("  Resets: ").Append(this.Resets).Append("\n");
            sb.Append("  Enforced: ").Append(this.Enforced).Append("\n");
            sb.Append("  Exceeded: ").Append(this.Exceeded).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Unit: ").Append(this.Unit).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Quota object</returns>
        public static Quota FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Quota>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Quota object</returns>
        public virtual Quota DuplicateQuota()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateQuota();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateQuota();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Quota);
        }

        /// <summary>
        /// Returns true if Quota instances are equal
        /// </summary>
        /// <param name="input">Instance of Quota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quota input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.Owner, input.Owner) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.PeriodStart, input.PeriodStart) && 
                    Extension.Equals(this.Limit, input.Limit) && 
                    Extension.Equals(this.Usage, input.Usage) && 
                    Extension.Equals(this.Resets, input.Resets) && 
                    Extension.Equals(this.Enforced, input.Enforced) && 
                    Extension.Equals(this.Exceeded, input.Exceeded) && 
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
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.Resets != null)
                    hashCode = hashCode * 59 + this.Resets.GetHashCode();
                if (this.Enforced != null)
                    hashCode = hashCode * 59 + this.Enforced.GetHashCode();
                if (this.Exceeded != null)
                    hashCode = hashCode * 59 + this.Exceeded.GetHashCode();
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

            
            // Usage (double) minimum
            if(this.Usage < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Usage, must be a value greater than or equal to 0.", new [] { "Usage" });
            }

            yield break;
        }
    }
}
