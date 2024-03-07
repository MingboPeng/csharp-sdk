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
    /// SubscriptionPayment
    /// </summary>
    [DataContract(Name = "SubscriptionPayment")]
    public partial class SubscriptionPayment : OpenAPIGenBaseModel, IEquatable<SubscriptionPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPayment() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "SubscriptionPayment";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPayment" /> class.
        /// </summary>
        /// <param name="date">date (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="amount">amount (required).</param>
        public SubscriptionPayment
        (
           DateTime date, string currency, double amount// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            this.Date = date;
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency is a required property for SubscriptionPayment and cannot be null");
            this.Amount = amount;

            // Set non-required readonly properties with defaultValue
            this.Type = "SubscriptionPayment";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "SubscriptionPayment";

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", IsRequired = true)]
        public DateTime Date { get; set; } 
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true)]
        public string Currency { get; set; } 
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true)]
        public double Amount { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SubscriptionPayment";
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
            sb.Append("SubscriptionPayment:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Date: ").Append(this.Date).Append("\n");
            sb.Append("  Currency: ").Append(this.Currency).Append("\n");
            sb.Append("  Amount: ").Append(this.Amount).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SubscriptionPayment object</returns>
        public static SubscriptionPayment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionPayment>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionPayment object</returns>
        public virtual SubscriptionPayment DuplicateSubscriptionPayment()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSubscriptionPayment();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSubscriptionPayment();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SubscriptionPayment);
        }

        /// <summary>
        /// Returns true if SubscriptionPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPayment input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Date, input.Date) && 
                    Extension.Equals(this.Currency, input.Currency) && 
                    Extension.Equals(this.Amount, input.Amount) && 
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
            Regex regexType = new Regex(@"^SubscriptionPayment$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}