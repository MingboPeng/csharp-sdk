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
    /// ProjectCreate
    /// </summary>
    [DataContract(Name = "ProjectCreate")]
    public partial class ProjectCreate : OpenAPIGenBaseModel, IEquatable<ProjectCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectCreate() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ProjectCreate";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreate" /> class.
        /// </summary>
        /// <param name="name">The name of the project. Must be unique to a given owner (required).</param>
        /// <param name="description">A description of the project (default to &quot;&quot;).</param>
        /// <param name="_public">Whether or not a project is publicly viewable (default to true).</param>
        public ProjectCreate
        (
           string name, // Required parameters
           string description = "", bool _public = true // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ProjectCreate and cannot be null");
            // use default value if no "description" provided
            this.Description = description ?? "";
            this.Public = _public;

            // Set non-required readonly properties with defaultValue
            this.Type = "ProjectCreate";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ProjectCreate";

        /// <summary>
        /// The name of the project. Must be unique to a given owner
        /// </summary>
        /// <value>The name of the project. Must be unique to a given owner</value>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; } 
        /// <summary>
        /// A description of the project
        /// </summary>
        /// <value>A description of the project</value>
        [DataMember(Name = "description")]
        public string Description { get; set; }  = "";
        /// <summary>
        /// Whether or not a project is publicly viewable
        /// </summary>
        /// <value>Whether or not a project is publicly viewable</value>
        [DataMember(Name = "public")]
        public bool Public { get; set; }  = true;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ProjectCreate";
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
            sb.Append("ProjectCreate:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Public: ").Append(this.Public).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ProjectCreate object</returns>
        public static ProjectCreate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectCreate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectCreate object</returns>
        public virtual ProjectCreate DuplicateProjectCreate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateProjectCreate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateProjectCreate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ProjectCreate);
        }

        /// <summary>
        /// Returns true if ProjectCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCreate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.Description, input.Description) && 
                    Extension.Equals(this.Public, input.Public) && 
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
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
            Regex regexType = new Regex(@"^ProjectCreate$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
