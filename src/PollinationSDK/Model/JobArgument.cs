/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
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


namespace PollinationSDK
{
    /// <summary>
    /// Job argument is an argument input for arguments which are not files or folders.
    /// </summary>
    [DataContract(Name = "JobArgument")]
    public partial class JobArgument : OpenAPIGenBaseModel, IEquatable<JobArgument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobArgument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobArgument() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "JobArgument";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="JobArgument" /> class.
        /// </summary>
        /// <param name="name">Argument name. The name must match one of the input names from Job&#39;s DAG template. (required).</param>
        /// <param name="value">The value of the job argument. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        public JobArgument
        (
           string name, object value, // Required parameters
           Dictionary<string, string> annotations= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for JobArgument and cannot be null");
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for JobArgument and cannot be null");
            this.Annotations = annotations;

            // Set non-required readonly properties with defaultValue
            this.Type = "JobArgument";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "JobArgument";

        /// <summary>
        /// Argument name. The name must match one of the input names from Job&#39;s DAG template.
        /// </summary>
        /// <value>Argument name. The name must match one of the input names from Job&#39;s DAG template.</value>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; } 
        /// <summary>
        /// The value of the job argument.
        /// </summary>
        /// <value>The value of the job argument.</value>
        [DataMember(Name = "value", IsRequired = true)]
        public object Value { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations")]
        public Dictionary<string, string> Annotations { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "JobArgument";
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
            sb.Append("JobArgument:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>JobArgument object</returns>
        public static JobArgument FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<JobArgument>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>JobArgument object</returns>
        public virtual JobArgument DuplicateJobArgument()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateJobArgument();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateJobArgument();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as JobArgument);
        }

        /// <summary>
        /// Returns true if JobArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of JobArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobArgument input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.Value, input.Value) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
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
            Regex regexType = new Regex(@"^JobArgument$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
