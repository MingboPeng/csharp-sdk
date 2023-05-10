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
    /// InvoicePreview
    /// </summary>
    [DataContract(Name = "InvoicePreview")]
    public partial class InvoicePreview : OpenAPIGenBaseModel, IEquatable<InvoicePreview>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public InvoiceStatus Status { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoicePreview() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "InvoicePreview";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePreview" /> class.
        /// </summary>
        /// <param name="collectionMethod">collectionMethod (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="periodStart">periodStart (required).</param>
        /// <param name="periodEnd">periodEnd (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusTransitions">statusTransitions (required).</param>
        /// <param name="subtotal">subtotal (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="autoAdvance">autoAdvance.</param>
        /// <param name="description">description.</param>
        /// <param name="hostedInvoiceUrl">hostedInvoiceUrl.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="discount">discount.</param>
        /// <param name="totalDiscountAmounts">totalDiscountAmounts.</param>
        /// <param name="paymentMethod">The payment method that will be billed when this invoice is due..</param>
        public InvoicePreview
        (
           string collectionMethod, string currency, string customer, LineItemList lines, DateTime periodStart, DateTime periodEnd, InvoiceStatus status, InvoiceStatusTransitions statusTransitions, int subtotal, int total, // Required parameters
           bool autoAdvance= default, string description= default, string hostedInvoiceUrl= default, string subscription= default, Discount discount= default, List<DiscountAmount> totalDiscountAmounts= default, CardPublic paymentMethod= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "collectionMethod" is required (not null)
            this.CollectionMethod = collectionMethod ?? throw new ArgumentNullException("collectionMethod is a required property for InvoicePreview and cannot be null");
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency is a required property for InvoicePreview and cannot be null");
            // to ensure "customer" is required (not null)
            this.Customer = customer ?? throw new ArgumentNullException("customer is a required property for InvoicePreview and cannot be null");
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for InvoicePreview and cannot be null");
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.Status = status;
            // to ensure "statusTransitions" is required (not null)
            this.StatusTransitions = statusTransitions ?? throw new ArgumentNullException("statusTransitions is a required property for InvoicePreview and cannot be null");
            this.Subtotal = subtotal;
            this.Total = total;
            this.AutoAdvance = autoAdvance;
            this.Description = description;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
            this.Subscription = subscription;
            this.Discount = discount;
            this.TotalDiscountAmounts = totalDiscountAmounts;
            this.PaymentMethod = paymentMethod;

            // Set non-required readonly properties with defaultValue
            this.Type = "InvoicePreview";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "InvoicePreview";

        /// <summary>
        /// Gets or Sets CollectionMethod
        /// </summary>
        [DataMember(Name = "collection_method", IsRequired = true, EmitDefaultValue = false)]
        public string CollectionMethod { get; set; } 
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = false)]
        public string Currency { get; set; } 
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", IsRequired = true, EmitDefaultValue = false)]
        public string Customer { get; set; } 
        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", IsRequired = true, EmitDefaultValue = false)]
        public LineItemList Lines { get; set; } 
        /// <summary>
        /// Gets or Sets PeriodStart
        /// </summary>
        [DataMember(Name = "period_start", IsRequired = true, EmitDefaultValue = false)]
        public DateTime PeriodStart { get; set; } 
        /// <summary>
        /// Gets or Sets PeriodEnd
        /// </summary>
        [DataMember(Name = "period_end", IsRequired = true, EmitDefaultValue = false)]
        public DateTime PeriodEnd { get; set; } 
        /// <summary>
        /// Gets or Sets StatusTransitions
        /// </summary>
        [DataMember(Name = "status_transitions", IsRequired = true, EmitDefaultValue = false)]
        public InvoiceStatusTransitions StatusTransitions { get; set; } 
        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name = "subtotal", IsRequired = true, EmitDefaultValue = false)]
        public int Subtotal { get; set; } 
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; } 
        /// <summary>
        /// Gets or Sets AutoAdvance
        /// </summary>
        [DataMember(Name = "auto_advance", EmitDefaultValue = false)]
        public bool AutoAdvance { get; set; } 
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; } 
        /// <summary>
        /// Gets or Sets HostedInvoiceUrl
        /// </summary>
        [DataMember(Name = "hosted_invoice_url", EmitDefaultValue = false)]
        public string HostedInvoiceUrl { get; set; } 
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public string Subscription { get; set; } 
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public Discount Discount { get; set; } 
        /// <summary>
        /// Gets or Sets TotalDiscountAmounts
        /// </summary>
        [DataMember(Name = "total_discount_amounts", EmitDefaultValue = false)]
        public List<DiscountAmount> TotalDiscountAmounts { get; set; } 
        /// <summary>
        /// The payment method that will be billed when this invoice is due.
        /// </summary>
        /// <value>The payment method that will be billed when this invoice is due.</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public CardPublic PaymentMethod { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "InvoicePreview";
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
            sb.Append("InvoicePreview:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CollectionMethod: ").Append(CollectionMethod).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusTransitions: ").Append(StatusTransitions).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  AutoAdvance: ").Append(AutoAdvance).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HostedInvoiceUrl: ").Append(HostedInvoiceUrl).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  TotalDiscountAmounts: ").Append(TotalDiscountAmounts).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>InvoicePreview object</returns>
        public static InvoicePreview FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InvoicePreview>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InvoicePreview object</returns>
        public virtual InvoicePreview DuplicateInvoicePreview()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateInvoicePreview();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateInvoicePreview();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as InvoicePreview);
        }

        /// <summary>
        /// Returns true if InvoicePreview instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicePreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicePreview input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.CollectionMethod == input.CollectionMethod ||
                    (this.CollectionMethod != null &&
                    this.CollectionMethod.Equals(input.CollectionMethod))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && base.Equals(input) && 
                (
                    this.Lines == input.Lines ||
                    (this.Lines != null &&
                    this.Lines.Equals(input.Lines))
                ) && base.Equals(input) && 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && base.Equals(input) && 
                (
                    this.PeriodEnd == input.PeriodEnd ||
                    (this.PeriodEnd != null &&
                    this.PeriodEnd.Equals(input.PeriodEnd))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.StatusTransitions == input.StatusTransitions ||
                    (this.StatusTransitions != null &&
                    this.StatusTransitions.Equals(input.StatusTransitions))
                ) && base.Equals(input) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && base.Equals(input) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && base.Equals(input) && 
                (
                    this.AutoAdvance == input.AutoAdvance ||
                    (this.AutoAdvance != null &&
                    this.AutoAdvance.Equals(input.AutoAdvance))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.HostedInvoiceUrl == input.HostedInvoiceUrl ||
                    (this.HostedInvoiceUrl != null &&
                    this.HostedInvoiceUrl.Equals(input.HostedInvoiceUrl))
                ) && base.Equals(input) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && base.Equals(input) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && base.Equals(input) && 
                (
                    this.TotalDiscountAmounts == input.TotalDiscountAmounts ||
                    this.TotalDiscountAmounts != null &&
                    input.TotalDiscountAmounts != null &&
                    this.TotalDiscountAmounts.SequenceEqual(input.TotalDiscountAmounts)
                ) && base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
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
                if (this.CollectionMethod != null)
                    hashCode = hashCode * 59 + this.CollectionMethod.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.PeriodEnd != null)
                    hashCode = hashCode * 59 + this.PeriodEnd.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusTransitions != null)
                    hashCode = hashCode * 59 + this.StatusTransitions.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.AutoAdvance != null)
                    hashCode = hashCode * 59 + this.AutoAdvance.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HostedInvoiceUrl != null)
                    hashCode = hashCode * 59 + this.HostedInvoiceUrl.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.TotalDiscountAmounts != null)
                    hashCode = hashCode * 59 + this.TotalDiscountAmounts.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
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
            Regex regexType = new Regex(@"^InvoicePreview$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
