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
    /// A Queenbee Recipe
    /// </summary>
    [DataContract(Name = "Recipe")]
    public partial class Recipe : OpenAPIGenBaseModel, IEquatable<Recipe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Recipe() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Recipe";
            this.ApiVersion = "v1beta1";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipe" /> class.
        /// </summary>
        /// <param name="flow">A list of tasks to create a DAG recipe. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="metadata">Recipe metadata information..</param>
        /// <param name="dependencies">A list of plugins and other recipes this recipe depends on..</param>
        public Recipe
        (
           List<DAG> flow, // Required parameters
           Dictionary<string, string> annotations= default, MetaData metadata= default, List<Dependency> dependencies= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "flow" is required (not null)
            this.Flow = flow ?? throw new ArgumentNullException("flow is a required property for Recipe and cannot be null");
            this.Annotations = annotations;
            this.Metadata = metadata;
            this.Dependencies = dependencies;

            // Set non-required readonly properties with defaultValue
            this.Type = "Recipe";
            this.ApiVersion = "v1beta1";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Recipe";
        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "api_version")]
        public string ApiVersion { get; protected set; }  = "v1beta1";

        /// <summary>
        /// A list of tasks to create a DAG recipe.
        /// </summary>
        /// <value>A list of tasks to create a DAG recipe.</value>
        [DataMember(Name = "flow", IsRequired = true)]
        public List<DAG> Flow { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Recipe metadata information.
        /// </summary>
        /// <value>Recipe metadata information.</value>
        [DataMember(Name = "metadata")]
        public MetaData Metadata { get; set; } 
        /// <summary>
        /// A list of plugins and other recipes this recipe depends on.
        /// </summary>
        /// <value>A list of plugins and other recipes this recipe depends on.</value>
        [DataMember(Name = "dependencies")]
        public List<Dependency> Dependencies { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Recipe";
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
            sb.Append("Recipe:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Flow: ").Append(this.Flow).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(this.ApiVersion).Append("\n");
            sb.Append("  Metadata: ").Append(this.Metadata).Append("\n");
            sb.Append("  Dependencies: ").Append(this.Dependencies).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Recipe object</returns>
        public static Recipe FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Recipe>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Recipe object</returns>
        public virtual Recipe DuplicateRecipe()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRecipe();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRecipe();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Recipe);
        }

        /// <summary>
        /// Returns true if Recipe instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recipe input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Flow == input.Flow ||
                    Extension.AllEquals(this.Flow, input.Flow)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
                ) && 
                    Extension.Equals(this.ApiVersion, input.ApiVersion) && 
                    Extension.Equals(this.Metadata, input.Metadata) && 
                (
                    this.Dependencies == input.Dependencies ||
                    Extension.AllEquals(this.Dependencies, input.Dependencies)
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
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
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
            Regex regexType = new Regex(@"^Recipe$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (this.ApiVersion != null && false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }

            yield break;
        }
    }
}
