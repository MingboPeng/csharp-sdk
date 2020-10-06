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
    /// A searchable index for a Queenbee Operator and Recipe repository
    /// </summary>
    [DataContract]
    public partial class RepositoryIndex :  IEquatable<RepositoryIndex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryIndex" /> class.
        /// </summary>
        /// <param name="generated">The timestamp at which the index was generated.</param>
        /// <param name="metadata">Extra information about the repository.</param>
        /// <param name="_operator">A dict of operators accessible by name. Each name key points to a list of operator versions.</param>
        /// <param name="recipe">A dict of recipes accessible by name. Each name key points to a list of recipesversions.</param>
        public RepositoryIndex
        (
           // Required parameters
           DateTime generated= default, RepositoryMetadata metadata= default, Dictionary<string, List<PackageVersion>> _operator= default, Dictionary<string, List<PackageVersion>> recipe= default// Optional parameters
        )// BaseClass
        {
            this.Generated = generated;
            this.Metadata = metadata;
            this.Operator = _operator;
            this.Recipe = recipe;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The timestamp at which the index was generated
        /// </summary>
        /// <value>The timestamp at which the index was generated</value>
        [DataMember(Name="generated", EmitDefaultValue=false)]
        [JsonProperty("generated")]
        public DateTime Generated { get; set; } 
        /// <summary>
        /// Extra information about the repository
        /// </summary>
        /// <value>Extra information about the repository</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty("metadata")]
        public RepositoryMetadata Metadata { get; set; } 
        /// <summary>
        /// A dict of operators accessible by name. Each name key points to a list of operator versions
        /// </summary>
        /// <value>A dict of operators accessible by name. Each name key points to a list of operator versions</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        [JsonProperty("operator")]
        public Dictionary<string, List<PackageVersion>> Operator { get; set; } 
        /// <summary>
        /// A dict of recipes accessible by name. Each name key points to a list of recipesversions
        /// </summary>
        /// <value>A dict of recipes accessible by name. Each name key points to a list of recipesversions</value>
        [DataMember(Name="recipe", EmitDefaultValue=false)]
        [JsonProperty("recipe")]
        public Dictionary<string, List<PackageVersion>> Recipe { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryIndex {\n");
            sb.Append("  Generated: ").Append(Generated).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
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
        /// <returns>RepositoryIndex object</returns>
        public static RepositoryIndex FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryIndex>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryIndex object</returns>
        public RepositoryIndex DuplicateRepositoryIndex()
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
            return this.Equals(input as RepositoryIndex);
        }

        /// <summary>
        /// Returns true if RepositoryIndex instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryIndex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryIndex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Generated == input.Generated ||
                    (this.Generated != null &&
                    this.Generated.Equals(input.Generated))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator != null &&
                    input.Operator != null &&
                    this.Operator.SequenceEqual(input.Operator)
                ) && 
                (
                    this.Recipe == input.Recipe ||
                    this.Recipe != null &&
                    input.Recipe != null &&
                    this.Recipe.SequenceEqual(input.Recipe)
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
                if (this.Generated != null)
                    hashCode = hashCode * 59 + this.Generated.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
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
