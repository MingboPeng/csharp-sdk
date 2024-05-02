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
    /// Input and output alias handler object.
    /// </summary>
    [DataContract(Name = "IOAliasHandler")]
    public partial class IOAliasHandler : OpenAPIGenBaseModel, IEquatable<IOAliasHandler>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IOAliasHandler" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IOAliasHandler() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "IOAliasHandler";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="IOAliasHandler" /> class.
        /// </summary>
        /// <param name="language">Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages. (required).</param>
        /// <param name="module">Target module or namespace to load the alias function. (required).</param>
        /// <param name="function">Name of the function. The input value will be passed to this function as the first argument. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="index">An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained. (default to 0).</param>
        public IOAliasHandler
        (
           string language, string module, string function, // Required parameters
           Dictionary<string, string> annotations= default, int index = 0// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "language" is required (not null)
            this.Language = language ?? throw new ArgumentNullException("language is a required property for IOAliasHandler and cannot be null");
            // to ensure "module" is required (not null)
            this.Module = module ?? throw new ArgumentNullException("module is a required property for IOAliasHandler and cannot be null");
            // to ensure "function" is required (not null)
            this.Function = function ?? throw new ArgumentNullException("function is a required property for IOAliasHandler and cannot be null");
            this.Annotations = annotations;
            this.Index = index;

            // Set non-required readonly properties with defaultValue
            this.Type = "IOAliasHandler";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "IOAliasHandler";

        /// <summary>
        /// Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages.
        /// </summary>
        /// <value>Declare the language (e.g. python, csharp, etc.). This option allows the recipe to be flexible on handling different programming languages.</value>
        [DataMember(Name = "language", IsRequired = true)]
        public string Language { get; set; } 
        /// <summary>
        /// Target module or namespace to load the alias function.
        /// </summary>
        /// <value>Target module or namespace to load the alias function.</value>
        [DataMember(Name = "module", IsRequired = true)]
        public string Module { get; set; } 
        /// <summary>
        /// Name of the function. The input value will be passed to this function as the first argument.
        /// </summary>
        /// <value>Name of the function. The input value will be passed to this function as the first argument.</value>
        [DataMember(Name = "function", IsRequired = true)]
        public string Function { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained.
        /// </summary>
        /// <value>An integer to set the index for the order of execution. This input is only useful when there are more than one handler for the same platform and the output of one handler should be passed to another handler. This is also called chained handlers. By default all the handlers are indexed as 0 assuming they are not chained.</value>
        [DataMember(Name = "index")]
        public int Index { get; set; }  = 0;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "IOAliasHandler";
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
            sb.Append("IOAliasHandler:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Language: ").Append(this.Language).Append("\n");
            sb.Append("  Module: ").Append(this.Module).Append("\n");
            sb.Append("  Function: ").Append(this.Function).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>IOAliasHandler object</returns>
        public static IOAliasHandler FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<IOAliasHandler>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IOAliasHandler object</returns>
        public virtual IOAliasHandler DuplicateIOAliasHandler()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateIOAliasHandler();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateIOAliasHandler();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as IOAliasHandler);
        }

        /// <summary>
        /// Returns true if IOAliasHandler instances are equal
        /// </summary>
        /// <param name="input">Instance of IOAliasHandler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IOAliasHandler input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Language, input.Language) && 
                    Extension.Equals(this.Module, input.Module) && 
                    Extension.Equals(this.Function, input.Function) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
                ) && 
                    Extension.Equals(this.Index, input.Index);
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
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
            Regex regexType = new Regex(@"^IOAliasHandler$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
