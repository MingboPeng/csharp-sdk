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
    /// SubscriptionUpdate
    /// </summary>
    [DataContract(Name = "SubscriptionUpdate")]
    public partial class SubscriptionUpdate : OpenAPIGenBaseModel, IEquatable<SubscriptionUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        /// <param name="toSubscribe">The Pollination plan to subscribe to.</param>
        /// <param name="toAdd">The items to add.</param>
        /// <param name="toUpdate">The items to update.</param>
        /// <param name="toDelete">The items to delete.</param>
        /// <param name="promotionCode">A promotion code to apply a discount to the subscription.</param>
        public SubscriptionUpdate
        (
           // Required parameters
           Price toSubscribe= default, List<NewSubscriptionItem> toAdd= default, List<SubscriptionItem> toUpdate= default, List<SubscriptionItem> toDelete= default, string promotionCode= default // Optional parameters
        ) : base()// BaseClass
        {
            this.ToSubscribe = toSubscribe;
            this.ToAdd = toAdd;
            this.ToUpdate = toUpdate;
            this.ToDelete = toDelete;
            this.PromotionCode = promotionCode;

            // Set non-required readonly properties with defaultValue
            this.Type = "SubscriptionUpdate";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; protected internal set; }  = "SubscriptionUpdate";

        /// <summary>
        /// The Pollination plan to subscribe to
        /// </summary>
        /// <value>The Pollination plan to subscribe to</value>
        [DataMember(Name = "to_subscribe", EmitDefaultValue = false)]
        public Price ToSubscribe { get; set; } 
        /// <summary>
        /// The items to add
        /// </summary>
        /// <value>The items to add</value>
        [DataMember(Name = "to_add", EmitDefaultValue = false)]
        public List<NewSubscriptionItem> ToAdd { get; set; } 
        /// <summary>
        /// The items to update
        /// </summary>
        /// <value>The items to update</value>
        [DataMember(Name = "to_update", EmitDefaultValue = false)]
        public List<SubscriptionItem> ToUpdate { get; set; } 
        /// <summary>
        /// The items to delete
        /// </summary>
        /// <value>The items to delete</value>
        [DataMember(Name = "to_delete", EmitDefaultValue = false)]
        public List<SubscriptionItem> ToDelete { get; set; } 
        /// <summary>
        /// A promotion code to apply a discount to the subscription
        /// </summary>
        /// <value>A promotion code to apply a discount to the subscription</value>
        [DataMember(Name = "promotion_code", EmitDefaultValue = false)]
        public string PromotionCode { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SubscriptionUpdate";
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
            sb.Append("SubscriptionUpdate:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ToSubscribe: ").Append(ToSubscribe).Append("\n");
            sb.Append("  ToAdd: ").Append(ToAdd).Append("\n");
            sb.Append("  ToUpdate: ").Append(ToUpdate).Append("\n");
            sb.Append("  ToDelete: ").Append(ToDelete).Append("\n");
            sb.Append("  PromotionCode: ").Append(PromotionCode).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SubscriptionUpdate object</returns>
        public static SubscriptionUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SubscriptionUpdate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SubscriptionUpdate object</returns>
        public virtual SubscriptionUpdate DuplicateSubscriptionUpdate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSubscriptionUpdate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSubscriptionUpdate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SubscriptionUpdate);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.ToSubscribe == input.ToSubscribe ||
                    (this.ToSubscribe != null &&
                    this.ToSubscribe.Equals(input.ToSubscribe))
                ) && base.Equals(input) && 
                (
                    this.ToAdd == input.ToAdd ||
                    this.ToAdd != null &&
                    input.ToAdd != null &&
                    this.ToAdd.SequenceEqual(input.ToAdd)
                ) && base.Equals(input) && 
                (
                    this.ToUpdate == input.ToUpdate ||
                    this.ToUpdate != null &&
                    input.ToUpdate != null &&
                    this.ToUpdate.SequenceEqual(input.ToUpdate)
                ) && base.Equals(input) && 
                (
                    this.ToDelete == input.ToDelete ||
                    this.ToDelete != null &&
                    input.ToDelete != null &&
                    this.ToDelete.SequenceEqual(input.ToDelete)
                ) && base.Equals(input) && 
                (
                    this.PromotionCode == input.PromotionCode ||
                    (this.PromotionCode != null &&
                    this.PromotionCode.Equals(input.PromotionCode))
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
                if (this.ToSubscribe != null)
                    hashCode = hashCode * 59 + this.ToSubscribe.GetHashCode();
                if (this.ToAdd != null)
                    hashCode = hashCode * 59 + this.ToAdd.GetHashCode();
                if (this.ToUpdate != null)
                    hashCode = hashCode * 59 + this.ToUpdate.GetHashCode();
                if (this.ToDelete != null)
                    hashCode = hashCode * 59 + this.ToDelete.GetHashCode();
                if (this.PromotionCode != null)
                    hashCode = hashCode * 59 + this.PromotionCode.GetHashCode();
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
            Regex regexType = new Regex(@"^SubscriptionUpdate$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}