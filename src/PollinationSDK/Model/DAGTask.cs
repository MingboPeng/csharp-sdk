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
    /// A single task in a DAG flow.
    /// </summary>
    [DataContract(Name = "DAGTask")]
    public partial class DAGTask : OpenAPIGenBaseModel, IEquatable<DAGTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTask" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGTask() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGTask";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTask" /> class.
        /// </summary>
        /// <param name="name">Name for this task. It must be unique in a DAG. (required).</param>
        /// <param name="template">Template name. A template is a Function or a DAG. This template must be available in the dependencies. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="needs">List of DAG tasks that this task depends on and needs to be executed before this task..</param>
        /// <param name="arguments">The input arguments for this task..</param>
        /// <param name="loop">Loop configuration for this task..</param>
        /// <param name="subFolder">A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific sub_folder..</param>
        /// <param name="returns">List of task returns..</param>
        public DAGTask
        (
           string name, string template, // Required parameters
           Dictionary<string, string> annotations= default, List<string> needs= default, List<AnyOf<TaskArgument,TaskPathArgument>> arguments= default, DAGTaskLoop loop= default, string subFolder= default, List<AnyOf<TaskReturn,TaskPathReturn>> returns= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DAGTask and cannot be null");
            // to ensure "template" is required (not null)
            this.Template = template ?? throw new ArgumentNullException("template is a required property for DAGTask and cannot be null");
            this.Annotations = annotations;
            this.Needs = needs;
            this.Arguments = arguments;
            this.Loop = loop;
            this.SubFolder = subFolder;
            this.Returns = returns;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGTask";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DAGTask";

        /// <summary>
        /// Name for this task. It must be unique in a DAG.
        /// </summary>
        /// <value>Name for this task. It must be unique in a DAG.</value>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; } 
        /// <summary>
        /// Template name. A template is a Function or a DAG. This template must be available in the dependencies.
        /// </summary>
        /// <value>Template name. A template is a Function or a DAG. This template must be available in the dependencies.</value>
        [DataMember(Name = "template", IsRequired = true)]
        public string Template { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// List of DAG tasks that this task depends on and needs to be executed before this task.
        /// </summary>
        /// <value>List of DAG tasks that this task depends on and needs to be executed before this task.</value>
        [DataMember(Name = "needs")]
        public List<string> Needs { get; set; } 
        /// <summary>
        /// The input arguments for this task.
        /// </summary>
        /// <value>The input arguments for this task.</value>
        [DataMember(Name = "arguments")]
        public List<AnyOf<TaskArgument,TaskPathArgument>> Arguments { get; set; } 
        /// <summary>
        /// Loop configuration for this task.
        /// </summary>
        /// <value>Loop configuration for this task.</value>
        [DataMember(Name = "loop")]
        public DAGTaskLoop Loop { get; set; } 
        /// <summary>
        /// A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific sub_folder.
        /// </summary>
        /// <value>A path relative to the current folder context where artifacts should be saved. This is useful when performing a loop or invoking another workflow and wanting to save results in a specific sub_folder.</value>
        [DataMember(Name = "sub_folder")]
        public string SubFolder { get; set; } 
        /// <summary>
        /// List of task returns.
        /// </summary>
        /// <value>List of task returns.</value>
        [DataMember(Name = "returns")]
        public List<AnyOf<TaskReturn,TaskPathReturn>> Returns { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGTask";
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
            sb.Append("DAGTask:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Template: ").Append(this.Template).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  Needs: ").Append(this.Needs).Append("\n");
            sb.Append("  Arguments: ").Append(this.Arguments).Append("\n");
            sb.Append("  Loop: ").Append(this.Loop).Append("\n");
            sb.Append("  SubFolder: ").Append(this.SubFolder).Append("\n");
            sb.Append("  Returns: ").Append(this.Returns).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGTask object</returns>
        public static DAGTask FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTask>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTask object</returns>
        public virtual DAGTask DuplicateDAGTask()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGTask();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDAGTask();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.Template, input.Template) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
                ) && 
                (
                    this.Needs == input.Needs ||
                    Extension.AllEquals(this.Needs, input.Needs)
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    Extension.AllEquals(this.Arguments, input.Arguments)
                ) && 
                    Extension.Equals(this.Loop, input.Loop) && 
                    Extension.Equals(this.SubFolder, input.SubFolder) && 
                (
                    this.Returns == input.Returns ||
                    Extension.AllEquals(this.Returns, input.Returns)
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
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Needs != null)
                    hashCode = hashCode * 59 + this.Needs.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Loop != null)
                    hashCode = hashCode * 59 + this.Loop.GetHashCode();
                if (this.SubFolder != null)
                    hashCode = hashCode * 59 + this.SubFolder.GetHashCode();
                if (this.Returns != null)
                    hashCode = hashCode * 59 + this.Returns.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGTask$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
