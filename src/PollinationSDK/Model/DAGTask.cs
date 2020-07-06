/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.5.31
 * 
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
    /// The instance of a function template matched with DAG inputs and outputs.
    /// </summary>
    [DataContract]
    public partial class DAGTask :  IEquatable<DAGTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTask" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGTask() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTask" /> class.
        /// </summary>
        /// <param name="name">Name for this step. It must be unique in DAG. (required).</param>
        /// <param name="template">Template name. (required).</param>
        /// <param name="arguments">The input arguments for this task.</param>
        /// <param name="dependencies">Dependencies are name of other DAG steps which this depends on..</param>
        /// <param name="loop">List of inputs to loop over..</param>
        /// <param name="subFolder">A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific folder..</param>
        /// <param name="outputs">The outputs of this task.</param>
        public DAGTask
        (
           string name, string template, // Required parameters
           DAGTaskArgument arguments= default, List<string> dependencies= default, DAGTaskLoop loop= default, string subFolder= default, DAGTaskOutputs outputs= default// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGTask and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "template" is required (not null)
            if (template == null)
            {
                throw new InvalidDataException("template is a required property for DAGTask and cannot be null");
            }
            else
            {
                this.Template = template;
            }
            
            this.Arguments = arguments;
            this.Dependencies = dependencies;
            this.Loop = loop;
            this.SubFolder = subFolder;
            this.Outputs = outputs;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Name for this step. It must be unique in DAG.
        /// </summary>
        /// <value>Name for this step. It must be unique in DAG.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Template name.
        /// </summary>
        /// <value>Template name.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        [JsonProperty("template")]
        public string Template { get; set; } 
        /// <summary>
        /// The input arguments for this task
        /// </summary>
        /// <value>The input arguments for this task</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        [JsonProperty("arguments")]
        public DAGTaskArgument Arguments { get; set; } 
        /// <summary>
        /// Dependencies are name of other DAG steps which this depends on.
        /// </summary>
        /// <value>Dependencies are name of other DAG steps which this depends on.</value>
        [DataMember(Name="dependencies", EmitDefaultValue=false)]
        [JsonProperty("dependencies")]
        public List<string> Dependencies { get; set; } 
        /// <summary>
        /// List of inputs to loop over.
        /// </summary>
        /// <value>List of inputs to loop over.</value>
        [DataMember(Name="loop", EmitDefaultValue=false)]
        [JsonProperty("loop")]
        public DAGTaskLoop Loop { get; set; } 
        /// <summary>
        /// A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific folder.
        /// </summary>
        /// <value>A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific folder.</value>
        [DataMember(Name="sub_folder", EmitDefaultValue=false)]
        [JsonProperty("sub_folder")]
        public string SubFolder { get; set; } 
        /// <summary>
        /// The outputs of this task
        /// </summary>
        /// <value>The outputs of this task</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        [JsonProperty("outputs")]
        public DAGTaskOutputs Outputs { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTask {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  Loop: ").Append(Loop).Append("\n");
            sb.Append("  SubFolder: ").Append(SubFolder).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DAGTask);
        }

        /// <summary>
        /// Returns true if DAGTask instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTask input)
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
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
                ) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                ) && 
                (
                    this.Loop == input.Loop ||
                    (this.Loop != null &&
                    this.Loop.Equals(input.Loop))
                ) && 
                (
                    this.SubFolder == input.SubFolder ||
                    (this.SubFolder != null &&
                    this.SubFolder.Equals(input.SubFolder))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    (this.Outputs != null &&
                    this.Outputs.Equals(input.Outputs))
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
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                if (this.Loop != null)
                    hashCode = hashCode * 59 + this.Loop.GetHashCode();
                if (this.SubFolder != null)
                    hashCode = hashCode * 59 + this.SubFolder.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
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