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
    /// The boolean type matches only two special values: True and False.  Note that values that evaluate to true or false, such as 1 and 0, are not accepted.  You can add additional validation by defining a JSONSchema specification.  See http://json-schema.org/understanding-json-schema/reference/boolean.html for more information.
    /// </summary>
    [DataContract(Name = "DAGBooleanInputAlias")]
    public partial class DAGBooleanInputAlias : GenericInput, IEquatable<DAGBooleanInputAlias>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGBooleanInputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGBooleanInputAlias() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGBooleanInputAlias";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGBooleanInputAlias" /> class.
        /// </summary>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="_default">Default value to use for an input if a value was not supplied..</param>
        /// <param name="required">A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. (default to false).</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        /// <param name="name">Input name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for input..</param>
        public DAGBooleanInputAlias
        (
            string name, List<string> platform, List<IOAliasHandler> handler, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, bool _default= default, bool required = false, Object spec= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description )// BaseClass
        {
            // to ensure "platform" is required (not null)
            this.Platform = platform ?? throw new ArgumentNullException("platform is a required property for DAGBooleanInputAlias and cannot be null");
            // to ensure "handler" is required (not null)
            this.Handler = handler ?? throw new ArgumentNullException("handler is a required property for DAGBooleanInputAlias and cannot be null");
            this.Default = _default;
            this.Required = required;
            this.Spec = spec;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGBooleanInputAlias";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DAGBooleanInputAlias";

        /// <summary>
        /// Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.
        /// </summary>
        /// <value>Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.</value>
        [DataMember(Name = "platform", IsRequired = true)]
        public List<string> Platform { get; set; } 
        /// <summary>
        /// List of process actions to process the input or output value.
        /// </summary>
        /// <value>List of process actions to process the input or output value.</value>
        [DataMember(Name = "handler", IsRequired = true)]
        public List<IOAliasHandler> Handler { get; set; } 
        /// <summary>
        /// Default value to use for an input if a value was not supplied.
        /// </summary>
        /// <value>Default value to use for an input if a value was not supplied.</value>
        [DataMember(Name = "default")]
        public bool Default { get; set; } 
        /// <summary>
        /// A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.
        /// </summary>
        /// <value>A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.</value>
        [DataMember(Name = "required")]
        public bool Required { get; set; }  = false;
        /// <summary>
        /// An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.
        /// </summary>
        /// <value>An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.</value>
        [DataMember(Name = "spec")]
        public Object Spec { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGBooleanInputAlias";
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
            sb.Append("DAGBooleanInputAlias:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Platform: ").Append(this.Platform).Append("\n");
            sb.Append("  Handler: ").Append(this.Handler).Append("\n");
            sb.Append("  Default: ").Append(this.Default).Append("\n");
            sb.Append("  Required: ").Append(this.Required).Append("\n");
            sb.Append("  Spec: ").Append(this.Spec).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGBooleanInputAlias object</returns>
        public static DAGBooleanInputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGBooleanInputAlias>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGBooleanInputAlias object</returns>
        public virtual DAGBooleanInputAlias DuplicateDAGBooleanInputAlias()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGBooleanInputAlias();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericInput DuplicateGenericInput()
        {
            return DuplicateDAGBooleanInputAlias();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAGBooleanInputAlias);
        }

        /// <summary>
        /// Returns true if DAGBooleanInputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGBooleanInputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGBooleanInputAlias input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Platform == input.Platform ||
                    Extension.AllEquals(this.Platform, input.Platform)
                ) && 
                (
                    this.Handler == input.Handler ||
                    Extension.AllEquals(this.Handler, input.Handler)
                ) && 
                    Extension.Equals(this.Default, input.Default) && 
                    Extension.Equals(this.Required, input.Required) && 
                    Extension.Equals(this.Spec, input.Spec) && 
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
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGBooleanInputAlias$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
