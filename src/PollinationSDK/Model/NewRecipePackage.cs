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
    /// NewRecipePackage
    /// </summary>
    [DataContract(Name = "NewRecipePackage")]
    public partial class NewRecipePackage : OpenAPIGenBaseModel, IEquatable<NewRecipePackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRecipePackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewRecipePackage() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "NewRecipePackage";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRecipePackage" /> class.
        /// </summary>
        /// <param name="manifest">The Recipe manifest to be created (required).</param>
        /// <param name="readme">The README file to attach to this package (default to &quot;&quot;).</param>
        public NewRecipePackage
        (
           Recipe manifest, // Required parameters
           string readme = "" // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "manifest" is required (not null)
            this.Manifest = manifest ?? throw new ArgumentNullException("manifest is a required property for NewRecipePackage and cannot be null");
            // use default value if no "readme" provided
            this.Readme = readme ?? "";

            // Set non-required readonly properties with defaultValue
            this.Type = "NewRecipePackage";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "NewRecipePackage";

        /// <summary>
        /// The Recipe manifest to be created
        /// </summary>
        /// <value>The Recipe manifest to be created</value>
        [DataMember(Name = "manifest", IsRequired = true)]
        public Recipe Manifest { get; set; } 
        /// <summary>
        /// The README file to attach to this package
        /// </summary>
        /// <value>The README file to attach to this package</value>
        [DataMember(Name = "readme")]
        public string Readme { get; set; }  = "";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "NewRecipePackage";
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
            sb.Append("NewRecipePackage:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Manifest: ").Append(this.Manifest).Append("\n");
            sb.Append("  Readme: ").Append(this.Readme).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>NewRecipePackage object</returns>
        public static NewRecipePackage FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<NewRecipePackage>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>NewRecipePackage object</returns>
        public virtual NewRecipePackage DuplicateNewRecipePackage()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateNewRecipePackage();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateNewRecipePackage();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as NewRecipePackage);
        }

        /// <summary>
        /// Returns true if NewRecipePackage instances are equal
        /// </summary>
        /// <param name="input">Instance of NewRecipePackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewRecipePackage input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Manifest, input.Manifest) && 
                    Extension.Equals(this.Readme, input.Readme) && 
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
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^NewRecipePackage$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
