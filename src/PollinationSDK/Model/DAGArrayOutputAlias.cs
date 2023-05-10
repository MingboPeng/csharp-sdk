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
    /// DAG alias array output.  This output loads the content from a JSON file which must be a JSON Array.
    /// </summary>
    [DataContract(Name = "DAGArrayOutputAlias")]
    public partial class DAGArrayOutputAlias : DAGArtifactOutputAlias, IEquatable<DAGArrayOutputAlias>, IValidatableObject
    {
        /// <summary>
        /// Type of items in this array. All the items in an array must be from the same type.
        /// </summary>
        /// <value>Type of items in this array. All the items in an array must be from the same type.</value>
        [DataMember(Name="items_type", EmitDefaultValue=false)]
        public ItemType ItemsType { get; set; } = ItemType.String;
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGArrayOutputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGArrayOutputAlias() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGArrayOutputAlias";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGArrayOutputAlias" /> class.
        /// </summary>
        /// <param name="from">Reference to a file or a task output. Task output must be file. (required).</param>
        /// <param name="itemsType">Type of items in this array. All the items in an array must be from the same type..</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="required">A boolean to indicate if an artifact output is required. A False value makes the artifact optional. (default to true).</param>
        public DAGArrayOutputAlias
        (
            string name, List<string> platform, List<IOAliasHandler> handler, AnyOf<TaskReference,FileReference> from, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, bool required = true, ItemType itemsType= ItemType.String // Optional parameters
        ) : base(name: name, annotations: annotations, description: description, platform: platform, handler: handler, required: required)// BaseClass
        {
            // to ensure "from" is required (not null)
            this.From = from ?? throw new ArgumentNullException("from is a required property for DAGArrayOutputAlias and cannot be null");
            this.ItemsType = itemsType;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGArrayOutputAlias";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "DAGArrayOutputAlias";

        /// <summary>
        /// Reference to a file or a task output. Task output must be file.
        /// </summary>
        /// <value>Reference to a file or a task output. Task output must be file.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<TaskReference,FileReference> From { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGArrayOutputAlias";
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
            sb.Append("DAGArrayOutputAlias:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ItemsType: ").Append(ItemsType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGArrayOutputAlias object</returns>
        public static DAGArrayOutputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGArrayOutputAlias>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGArrayOutputAlias object</returns>
        public virtual DAGArrayOutputAlias DuplicateDAGArrayOutputAlias()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGArrayOutputAlias();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override DAGArtifactOutputAlias DuplicateDAGArtifactOutputAlias()
        {
            return DuplicateDAGArrayOutputAlias();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAGArrayOutputAlias);
        }

        /// <summary>
        /// Returns true if DAGArrayOutputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGArrayOutputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGArrayOutputAlias input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.ItemsType == input.ItemsType ||
                    (this.ItemsType != null &&
                    this.ItemsType.Equals(input.ItemsType))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.ItemsType != null)
                    hashCode = hashCode * 59 + this.ItemsType.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGArrayOutputAlias$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
