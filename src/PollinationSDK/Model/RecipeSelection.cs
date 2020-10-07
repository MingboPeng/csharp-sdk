/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
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
using OpenAPIDateConverter = PollinationSDK.Client.OpenAPIDateConverter;

namespace PollinationSDK.Model
{
    /// <summary>
    /// RecipeSelection
    /// </summary>
    [DataContract]
    public partial class RecipeSelection :  IEquatable<RecipeSelection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecipeSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeSelection" /> class.
        /// </summary>
        /// <param name="name">Name of the recipe (required).</param>
        /// <param name="owner">Name of the owner of the recipe (required).</param>
        /// <param name="tag">The specific tag of the recipe to use (default to &quot;latest&quot;).</param>
        public RecipeSelection
        (
           string name, string owner, // Required parameters
           string tag = "latest"// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RecipeSelection and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for RecipeSelection and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            
            // use default value if no "tag" provided
            if (tag == null)
            {
                this.Tag ="latest";
            }
            else
            {
                this.Tag = tag;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Name of the recipe
        /// </summary>
        /// <value>Name of the recipe</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Name of the owner of the recipe
        /// </summary>
        /// <value>Name of the owner of the recipe</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        [JsonProperty("owner")]
        public string Owner { get; set; } 
        /// <summary>
        /// The specific tag of the recipe to use
        /// </summary>
        /// <value>The specific tag of the recipe to use</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        [JsonProperty("tag")]
        public string Tag { get; set; }  = "latest";
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipeSelection {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
        /// <returns>RecipeSelection object</returns>
        public static RecipeSelection FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RecipeSelection>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RecipeSelection object</returns>
        public RecipeSelection DuplicateRecipeSelection()
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
            return this.Equals(input as RecipeSelection);
        }

        /// <summary>
        /// Returns true if RecipeSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipeSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipeSelection input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
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
