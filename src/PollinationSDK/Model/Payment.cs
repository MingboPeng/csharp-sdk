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
    /// Payment
    /// </summary>
    [DataContract(Name = "Payment")]
    public partial class Payment : OpenAPIGenBaseModel, IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Payment";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="subscriptionId">subscriptionId (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="payoutDate">payoutDate (required).</param>
        /// <param name="isPaid">isPaid (required).</param>
        /// <param name="isOneOffCharge">isOneOffCharge (required).</param>
        /// <param name="receiptUrl">receiptUrl.</param>
        public Payment
        (
           int id, int subscriptionId, int amount, string currency, DateTime payoutDate, bool isPaid, bool isOneOffCharge, // Required parameters
           string receiptUrl= default // Optional parameters
        ) : base()// BaseClass
        {
            this.Id = id;
            this.SubscriptionId = subscriptionId;
            this.Amount = amount;
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency is a required property for Payment and cannot be null");
            this.PayoutDate = payoutDate;
            this.IsPaid = isPaid;
            this.IsOneOffCharge = isOneOffCharge;
            this.ReceiptUrl = receiptUrl;

            // Set non-required readonly properties with defaultValue
            this.Type = "Payment";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Payment";

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true)]
        public int Id { get; set; } 
        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscription_id", IsRequired = true)]
        public int SubscriptionId { get; set; } 
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true)]
        public int Amount { get; set; } 
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true)]
        public string Currency { get; set; } 
        /// <summary>
        /// Gets or Sets PayoutDate
        /// </summary>
        [DataMember(Name = "payout_date", IsRequired = true)]
        public DateTime PayoutDate { get; set; } 
        /// <summary>
        /// Gets or Sets IsPaid
        /// </summary>
        [DataMember(Name = "is_paid", IsRequired = true)]
        public bool IsPaid { get; set; } 
        /// <summary>
        /// Gets or Sets IsOneOffCharge
        /// </summary>
        [DataMember(Name = "is_one_off_charge", IsRequired = true)]
        public bool IsOneOffCharge { get; set; } 
        /// <summary>
        /// Gets or Sets ReceiptUrl
        /// </summary>
        [DataMember(Name = "receipt_url")]
        public string ReceiptUrl { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Payment";
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
            sb.Append("Payment:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  SubscriptionId: ").Append(this.SubscriptionId).Append("\n");
            sb.Append("  Amount: ").Append(this.Amount).Append("\n");
            sb.Append("  Currency: ").Append(this.Currency).Append("\n");
            sb.Append("  PayoutDate: ").Append(this.PayoutDate).Append("\n");
            sb.Append("  IsPaid: ").Append(this.IsPaid).Append("\n");
            sb.Append("  IsOneOffCharge: ").Append(this.IsOneOffCharge).Append("\n");
            sb.Append("  ReceiptUrl: ").Append(this.ReceiptUrl).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Payment object</returns>
        public static Payment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Payment>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Payment object</returns>
        public virtual Payment DuplicatePayment()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePayment();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicatePayment();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.SubscriptionId, input.SubscriptionId) && 
                    Extension.Equals(this.Amount, input.Amount) && 
                    Extension.Equals(this.Currency, input.Currency) && 
                    Extension.Equals(this.PayoutDate, input.PayoutDate) && 
                    Extension.Equals(this.IsPaid, input.IsPaid) && 
                    Extension.Equals(this.IsOneOffCharge, input.IsOneOffCharge) && 
                    Extension.Equals(this.ReceiptUrl, input.ReceiptUrl) && 
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.PayoutDate != null)
                    hashCode = hashCode * 59 + this.PayoutDate.GetHashCode();
                if (this.IsPaid != null)
                    hashCode = hashCode * 59 + this.IsPaid.GetHashCode();
                if (this.IsOneOffCharge != null)
                    hashCode = hashCode * 59 + this.IsOneOffCharge.GetHashCode();
                if (this.ReceiptUrl != null)
                    hashCode = hashCode * 59 + this.ReceiptUrl.GetHashCode();
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
            Regex regexType = new Regex(@"^Payment$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}