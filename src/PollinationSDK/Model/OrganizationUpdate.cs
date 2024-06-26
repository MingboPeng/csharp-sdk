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
    /// OrganizationUpdate
    /// </summary>
    [DataContract(Name = "OrganizationUpdate")]
    public partial class OrganizationUpdate : OpenAPIGenBaseModel, IEquatable<OrganizationUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        /// <param name="accountName">The unique name of the org in small case without spaces.</param>
        /// <param name="name">The display name for this org.</param>
        /// <param name="pictureUrl">URL to the picture associated with this org.</param>
        /// <param name="contactEmail">The contact email for the Organization.</param>
        /// <param name="description">A description of the org.</param>
        public OrganizationUpdate
        (
            // Required parameters
           string accountName= default, string name= default, string pictureUrl= default, string contactEmail= default, string description= default // Optional parameters
        ) : base()// BaseClass
        {
            this.AccountName = accountName;
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.ContactEmail = contactEmail;
            this.Description = description;

            // Set non-required readonly properties with defaultValue
            this.Type = "OrganizationUpdate";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "OrganizationUpdate";

        /// <summary>
        /// The unique name of the org in small case without spaces
        /// </summary>
        /// <value>The unique name of the org in small case without spaces</value>
        [DataMember(Name = "account_name")]
        public string AccountName { get; set; } 
        /// <summary>
        /// The display name for this org
        /// </summary>
        /// <value>The display name for this org</value>
        [DataMember(Name = "name")]
        public string Name { get; set; } 
        /// <summary>
        /// URL to the picture associated with this org
        /// </summary>
        /// <value>URL to the picture associated with this org</value>
        [DataMember(Name = "picture_url")]
        public string PictureUrl { get; set; } 
        /// <summary>
        /// The contact email for the Organization
        /// </summary>
        /// <value>The contact email for the Organization</value>
        [DataMember(Name = "contact_email")]
        public string ContactEmail { get; set; } 
        /// <summary>
        /// A description of the org
        /// </summary>
        /// <value>A description of the org</value>
        [DataMember(Name = "description")]
        public string Description { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "OrganizationUpdate";
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
            sb.Append("OrganizationUpdate:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  AccountName: ").Append(this.AccountName).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  PictureUrl: ").Append(this.PictureUrl).Append("\n");
            sb.Append("  ContactEmail: ").Append(this.ContactEmail).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>OrganizationUpdate object</returns>
        public static OrganizationUpdate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OrganizationUpdate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OrganizationUpdate object</returns>
        public virtual OrganizationUpdate DuplicateOrganizationUpdate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateOrganizationUpdate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateOrganizationUpdate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as OrganizationUpdate);
        }

        /// <summary>
        /// Returns true if OrganizationUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationUpdate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.AccountName, input.AccountName) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.PictureUrl, input.PictureUrl) && 
                    Extension.Equals(this.ContactEmail, input.ContactEmail) && 
                    Extension.Equals(this.Description, input.Description) && 
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PictureUrl != null)
                    hashCode = hashCode * 59 + this.PictureUrl.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
            Regex regexType = new Regex(@"^OrganizationUpdate$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
