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
    /// Base Status model
    /// </summary>
    [DataContract(Name = "BaseStatus")]
    public partial class BaseStatus : IOBase, IEquatable<BaseStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BaseStatus() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "BaseStatus";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStatus" /> class.
        /// </summary>
        /// <param name="startedAt">The time at which the task was started (required).</param>
        /// <param name="message">Any message produced by the task. Usually error/debugging hints..</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="source">Source url for the status object. It can be a recipe or a function..</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="inputs">Place-holder. Overwrite this!.</param>
        /// <param name="outputs">Place-holder. Overwrite this!.</param>
        public BaseStatus
        (
           DateTime startedAt, // Required parameters
            Dictionary<string, string> annotations= default, List<object> inputs= default, List<object> outputs= default, string message= default, DateTime finishedAt= default, string source= default // Optional parameters
        ) : base(annotations: annotations, inputs: inputs, outputs: outputs )// BaseClass
        {
            this.StartedAt = startedAt;
            this.Message = message;
            this.FinishedAt = finishedAt;
            this.Source = source;

            // Set non-required readonly properties with defaultValue
            this.Type = "BaseStatus";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "BaseStatus";

        /// <summary>
        /// The time at which the task was started
        /// </summary>
        /// <value>The time at which the task was started</value>
        [DataMember(Name = "started_at", IsRequired = true)]
        public DateTime StartedAt { get; set; } 
        /// <summary>
        /// Any message produced by the task. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the task. Usually error/debugging hints.</value>
        [DataMember(Name = "message")]
        public string Message { get; set; } 
        /// <summary>
        /// The time at which the task was completed
        /// </summary>
        /// <value>The time at which the task was completed</value>
        [DataMember(Name = "finished_at")]
        public DateTime FinishedAt { get; set; } 
        /// <summary>
        /// Source url for the status object. It can be a recipe or a function.
        /// </summary>
        /// <value>Source url for the status object. It can be a recipe or a function.</value>
        [DataMember(Name = "source")]
        public string Source { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "BaseStatus";
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
            sb.Append("BaseStatus:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Inputs: ").Append(this.Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(this.Outputs).Append("\n");
            sb.Append("  StartedAt: ").Append(this.StartedAt).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            sb.Append("  FinishedAt: ").Append(this.FinishedAt).Append("\n");
            sb.Append("  Source: ").Append(this.Source).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BaseStatus object</returns>
        public static BaseStatus FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BaseStatus>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BaseStatus object</returns>
        public virtual BaseStatus DuplicateBaseStatus()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateBaseStatus();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IOBase DuplicateIOBase()
        {
            return DuplicateBaseStatus();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as BaseStatus);
        }

        /// <summary>
        /// Returns true if BaseStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseStatus input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.StartedAt, input.StartedAt) && 
                    Extension.Equals(this.Message, input.Message) && 
                    Extension.Equals(this.FinishedAt, input.FinishedAt) && 
                    Extension.Equals(this.Source, input.Source) && 
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
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
            Regex regexType = new Regex(@"^BaseStatus$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
