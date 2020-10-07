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
    /// BaseModel with functionality to return the object as a yaml string      
    /// </summary>
    [DataContract]
    public partial class RepositoryMetadata :  IEquatable<RepositoryMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryMetadata" /> class.
        /// </summary>
        /// <param name="description">A short description of the repository (default to &quot;A Queenbee package repository&quot;).</param>
        /// <param name="name">The name of the repository.</param>
        /// <param name="operatorCount">The number of operators hosted by the repository (default to 0).</param>
        /// <param name="recipeCount">The number of recipes hosted by the repository (default to 0).</param>
        /// <param name="source">The source path (url or local) to the repository.</param>
        public RepositoryMetadata
        (
           // Required parameters
           string description = "A Queenbee package repository", string name= default, int operatorCount = 0, int recipeCount = 0, string source= default// Optional parameters
        )// BaseClass
        {
            // use default value if no "description" provided
            if (description == null)
            {
                this.Description ="A Queenbee package repository";
            }
            else
            {
                this.Description = description;
            }
            this.Name = name;
            // use default value if no "operatorCount" provided
            if (operatorCount == null)
            {
                this.OperatorCount =0;
            }
            else
            {
                this.OperatorCount = operatorCount;
            }
            // use default value if no "recipeCount" provided
            if (recipeCount == null)
            {
                this.RecipeCount =0;
            }
            else
            {
                this.RecipeCount = recipeCount;
            }
            this.Source = source;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A short description of the repository
        /// </summary>
        /// <value>A short description of the repository</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; }  = "A Queenbee package repository";
        /// <summary>
        /// The name of the repository
        /// </summary>
        /// <value>The name of the repository</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The number of operators hosted by the repository
        /// </summary>
        /// <value>The number of operators hosted by the repository</value>
        [DataMember(Name="operator_count", EmitDefaultValue=false)]
        [JsonProperty("operator_count")]
        public int OperatorCount { get; set; }  = 0;
        /// <summary>
        /// The number of recipes hosted by the repository
        /// </summary>
        /// <value>The number of recipes hosted by the repository</value>
        [DataMember(Name="recipe_count", EmitDefaultValue=false)]
        [JsonProperty("recipe_count")]
        public int RecipeCount { get; set; }  = 0;
        /// <summary>
        /// The source path (url or local) to the repository
        /// </summary>
        /// <value>The source path (url or local) to the repository</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        [JsonProperty("source")]
        public string Source { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryMetadata {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OperatorCount: ").Append(OperatorCount).Append("\n");
            sb.Append("  RecipeCount: ").Append(RecipeCount).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
        /// <returns>RepositoryMetadata object</returns>
        public static RepositoryMetadata FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryMetadata>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryMetadata object</returns>
        public RepositoryMetadata DuplicateRepositoryMetadata()
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
            return this.Equals(input as RepositoryMetadata);
        }

        /// <summary>
        /// Returns true if RepositoryMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryMetadata input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OperatorCount == input.OperatorCount ||
                    (this.OperatorCount != null &&
                    this.OperatorCount.Equals(input.OperatorCount))
                ) && 
                (
                    this.RecipeCount == input.RecipeCount ||
                    (this.RecipeCount != null &&
                    this.RecipeCount.Equals(input.RecipeCount))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OperatorCount != null)
                    hashCode = hashCode * 59 + this.OperatorCount.GetHashCode();
                if (this.RecipeCount != null)
                    hashCode = hashCode * 59 + this.RecipeCount.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
