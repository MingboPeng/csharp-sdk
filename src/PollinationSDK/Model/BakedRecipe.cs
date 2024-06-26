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
    /// Baked Recipe.  A Baked Recipe contains all the templates referred to in the DAG within a templates list.
    /// </summary>
    [DataContract(Name = "BakedRecipe")]
    public partial class BakedRecipe : OpenAPIGenBaseModel, IEquatable<BakedRecipe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BakedRecipe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BakedRecipe() 
        { 
            // Set non-required readonly properties with defaultValue
            this.ApiVersion = "v1beta1";
            this.Type = "BakedRecipe";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BakedRecipe" /> class.
        /// </summary>
        /// <param name="flow">A list of tasks to create a DAG recipe. (required).</param>
        /// <param name="digest">digest (required).</param>
        /// <param name="templates">A list of templates. Templates can be Function or a DAG. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="metadata">Recipe metadata information..</param>
        /// <param name="dependencies">A list of plugins and other recipes this recipe depends on..</param>
        public BakedRecipe
        (
           List<DAG> flow, string digest, List<AnyOf<TemplateFunction,DAG>> templates, // Required parameters
           Dictionary<string, string> annotations= default, MetaData metadata= default, List<Dependency> dependencies= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "flow" is required (not null)
            this.Flow = flow ?? throw new ArgumentNullException("flow is a required property for BakedRecipe and cannot be null");
            // to ensure "digest" is required (not null)
            this.Digest = digest ?? throw new ArgumentNullException("digest is a required property for BakedRecipe and cannot be null");
            // to ensure "templates" is required (not null)
            this.Templates = templates ?? throw new ArgumentNullException("templates is a required property for BakedRecipe and cannot be null");
            this.Annotations = annotations;
            this.Metadata = metadata;
            this.Dependencies = dependencies;

            // Set non-required readonly properties with defaultValue
            this.ApiVersion = "v1beta1";
            this.Type = "BakedRecipe";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "api_version")]
        public string ApiVersion { get; protected set; }  = "v1beta1";
        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "BakedRecipe";

        /// <summary>
        /// A list of tasks to create a DAG recipe.
        /// </summary>
        /// <value>A list of tasks to create a DAG recipe.</value>
        [DataMember(Name = "flow", IsRequired = true)]
        public List<DAG> Flow { get; set; } 
        /// <summary>
        /// Gets or Sets Digest
        /// </summary>
        [DataMember(Name = "digest", IsRequired = true)]
        public string Digest { get; set; } 
        /// <summary>
        /// A list of templates. Templates can be Function or a DAG.
        /// </summary>
        /// <value>A list of templates. Templates can be Function or a DAG.</value>
        [DataMember(Name = "templates", IsRequired = true)]
        public List<AnyOf<TemplateFunction,DAG>> Templates { get; set; } 
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
            return "BakedRecipe";
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
            sb.Append("BakedRecipe:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Flow: ").Append(this.Flow).Append("\n");
            sb.Append("  Digest: ").Append(this.Digest).Append("\n");
            sb.Append("  Templates: ").Append(this.Templates).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(this.ApiVersion).Append("\n");
            sb.Append("  Metadata: ").Append(this.Metadata).Append("\n");
            sb.Append("  Dependencies: ").Append(this.Dependencies).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BakedRecipe object</returns>
        public static BakedRecipe FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BakedRecipe>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BakedRecipe object</returns>
        public virtual BakedRecipe DuplicateBakedRecipe()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateBakedRecipe();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateBakedRecipe();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as BakedRecipe);
        }

        /// <summary>
        /// Returns true if BakedRecipe instances are equal
        /// </summary>
        /// <param name="input">Instance of BakedRecipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BakedRecipe input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Flow == input.Flow ||
                    Extension.AllEquals(this.Flow, input.Flow)
                ) && 
                    Extension.Equals(this.Digest, input.Digest) && 
                (
                    this.Templates == input.Templates ||
                    Extension.AllEquals(this.Templates, input.Templates)
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
                ) && 
                    Extension.Equals(this.ApiVersion, input.ApiVersion) && 
                    Extension.Equals(this.Metadata, input.Metadata) && 
                (
                    this.Dependencies == input.Dependencies ||
                    Extension.AllEquals(this.Dependencies, input.Dependencies)
                ) && 
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
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
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

            
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (this.ApiVersion != null && false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^BakedRecipe$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
