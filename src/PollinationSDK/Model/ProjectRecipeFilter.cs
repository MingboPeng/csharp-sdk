/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.0.0
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


namespace PollinationSDK.Model
{
    /// <summary>
    /// ProjectRecipeFilter
    /// </summary>
    [DataContract]
    public partial class ProjectRecipeFilter :  IEquatable<ProjectRecipeFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRecipeFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectRecipeFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRecipeFilter" /> class.
        /// </summary>
        /// <param name="owner">The name of the account the recipe belongs to (required).</param>
        /// <param name="name">The name of the recipe (required).</param>
        /// <param name="tag">The specific recipe tag.</param>
        public ProjectRecipeFilter
        (
           string owner, string name, // Required parameters
           string tag= default// Optional parameters
        )// BaseClass
        {
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for ProjectRecipeFilter and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProjectRecipeFilter and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Tag = tag;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the account the recipe belongs to
        /// </summary>
        /// <value>The name of the account the recipe belongs to</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public string Owner { get; set; } 
        /// <summary>
        /// The name of the recipe
        /// </summary>
        /// <value>The name of the recipe</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The specific recipe tag
        /// </summary>
        /// <value>The specific recipe tag</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        [JsonProperty("tag")]
        public string Tag { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectRecipeFilter {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.ConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ProjectRecipeFilter object</returns>
        public static ProjectRecipeFilter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectRecipeFilter>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectRecipeFilter object</returns>
        public ProjectRecipeFilter DuplicateProjectRecipeFilter()
        {
            return FromJson(this.ToJson());
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectRecipeFilter);
        }

        /// <summary>
        /// Returns true if ProjectRecipeFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectRecipeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectRecipeFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                int hashCode = 41;
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
            yield break;
        }
    }
}