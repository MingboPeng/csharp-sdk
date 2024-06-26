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
    /// ApplicationDeployment
    /// </summary>
    [DataContract(Name = "ApplicationDeployment")]
    public partial class ApplicationDeployment : OpenAPIGenBaseModel, IEquatable<ApplicationDeployment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDeployment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationDeployment() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ApplicationDeployment";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDeployment" /> class.
        /// </summary>
        /// <param name="ready">Indicates whether the application deployment is ready. (required).</param>
        /// <param name="url">The URL of the application deployment. (required).</param>
        /// <param name="author">The user who deployed this app (required).</param>
        /// <param name="version">The version deployed (required).</param>
        public ApplicationDeployment
        (
           bool ready, string url, AccountPublic author, ApplicationVersion version// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            this.Ready = ready;
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for ApplicationDeployment and cannot be null");
            // to ensure "author" is required (not null)
            this.Author = author ?? throw new ArgumentNullException("author is a required property for ApplicationDeployment and cannot be null");
            // to ensure "version" is required (not null)
            this.Version = version ?? throw new ArgumentNullException("version is a required property for ApplicationDeployment and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "ApplicationDeployment";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ApplicationDeployment";

        /// <summary>
        /// Indicates whether the application deployment is ready.
        /// </summary>
        /// <value>Indicates whether the application deployment is ready.</value>
        [DataMember(Name = "ready", IsRequired = true)]
        public bool Ready { get; set; } 
        /// <summary>
        /// The URL of the application deployment.
        /// </summary>
        /// <value>The URL of the application deployment.</value>
        [DataMember(Name = "url", IsRequired = true)]
        public string Url { get; set; } 
        /// <summary>
        /// The user who deployed this app
        /// </summary>
        /// <value>The user who deployed this app</value>
        [DataMember(Name = "author", IsRequired = true)]
        public AccountPublic Author { get; set; } 
        /// <summary>
        /// The version deployed
        /// </summary>
        /// <value>The version deployed</value>
        [DataMember(Name = "version", IsRequired = true)]
        public ApplicationVersion Version { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ApplicationDeployment";
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
            sb.Append("ApplicationDeployment:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Ready: ").Append(this.Ready).Append("\n");
            sb.Append("  Url: ").Append(this.Url).Append("\n");
            sb.Append("  Author: ").Append(this.Author).Append("\n");
            sb.Append("  Version: ").Append(this.Version).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApplicationDeployment object</returns>
        public static ApplicationDeployment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApplicationDeployment>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApplicationDeployment object</returns>
        public virtual ApplicationDeployment DuplicateApplicationDeployment()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateApplicationDeployment();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateApplicationDeployment();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ApplicationDeployment);
        }

        /// <summary>
        /// Returns true if ApplicationDeployment instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationDeployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationDeployment input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Ready, input.Ready) && 
                    Extension.Equals(this.Url, input.Url) && 
                    Extension.Equals(this.Author, input.Author) && 
                    Extension.Equals(this.Version, input.Version) && 
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
                if (this.Ready != null)
                    hashCode = hashCode * 59 + this.Ready.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
            Regex regexType = new Regex(@"^ApplicationDeployment$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
