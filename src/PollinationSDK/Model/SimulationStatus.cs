/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.7.1
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
    /// Workflow Status
    /// </summary>
    [DataContract]
    public partial class SimulationStatus :  IEquatable<SimulationStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimulationStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationStatus" /> class.
        /// </summary>
        /// <param name="status">The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot; (required).</param>
        /// <param name="message">Any message produced by the task. Usually error/debugging hints..</param>
        /// <param name="startedAt">The time at which the task was started (required).</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="id">The ID of the individual workflow run. (required).</param>
        /// <param name="entrypoint">The ID of the first task in the workflow.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="ownerId">ID of the account the simulation is running for. (required).</param>
        /// <param name="projectId">ID of the project the simulation belongs to (required).</param>
        /// <param name="recipeId">ID of the recipe repository used to create the workflow (required).</param>
        /// <param name="recipeOwnerId">ID of the recipe owner (required).</param>
        /// <param name="recipePackageId">ID of the specific recipe package used to create the workflow (required).</param>
        /// <param name="parallelism">The max number of parallel tasks running for this simulation.</param>
        public SimulationStatus
        (
           string status, DateTime startedAt, string id, string ownerId, string projectId, string recipeId, string recipeOwnerId, string recipePackageId, // Required parameters
           string message= default, DateTime finishedAt= default, string entrypoint= default, Dictionary<string, TaskStatus> tasks= default, int parallelism= default// Optional parameters
        )// BaseClass
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new InvalidDataException("startedAt is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.StartedAt = startedAt;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "ownerId" is required (not null)
            if (ownerId == null)
            {
                throw new InvalidDataException("ownerId is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.OwnerId = ownerId;
            }
            
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new InvalidDataException("projectId is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.ProjectId = projectId;
            }
            
            // to ensure "recipeId" is required (not null)
            if (recipeId == null)
            {
                throw new InvalidDataException("recipeId is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.RecipeId = recipeId;
            }
            
            // to ensure "recipeOwnerId" is required (not null)
            if (recipeOwnerId == null)
            {
                throw new InvalidDataException("recipeOwnerId is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.RecipeOwnerId = recipeOwnerId;
            }
            
            // to ensure "recipePackageId" is required (not null)
            if (recipePackageId == null)
            {
                throw new InvalidDataException("recipePackageId is a required property for SimulationStatus and cannot be null");
            }
            else
            {
                this.RecipePackageId = recipePackageId;
            }
            
            this.Message = message;
            this.FinishedAt = finishedAt;
            this.Entrypoint = entrypoint;
            this.Tasks = tasks;
            this.Parallelism = parallelism;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot;
        /// </summary>
        /// <value>The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        [JsonProperty("status")]
        public string Status { get; set; } 
        /// <summary>
        /// Any message produced by the task. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the task. Usually error/debugging hints.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty("message")]
        public string Message { get; set; } 
        /// <summary>
        /// The time at which the task was started
        /// </summary>
        /// <value>The time at which the task was started</value>
        [DataMember(Name="started_at", EmitDefaultValue=false)]
        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; } 
        /// <summary>
        /// The time at which the task was completed
        /// </summary>
        /// <value>The time at which the task was completed</value>
        [DataMember(Name="finished_at", EmitDefaultValue=false)]
        [JsonProperty("finished_at")]
        public DateTime FinishedAt { get; set; } 
        /// <summary>
        /// The ID of the individual workflow run.
        /// </summary>
        /// <value>The ID of the individual workflow run.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// The ID of the first task in the workflow
        /// </summary>
        /// <value>The ID of the first task in the workflow</value>
        [DataMember(Name="entrypoint", EmitDefaultValue=false)]
        [JsonProperty("entrypoint")]
        public string Entrypoint { get; set; } 
        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        [JsonProperty("tasks")]
        public Dictionary<string, TaskStatus> Tasks { get; set; } 
        /// <summary>
        /// ID of the account the simulation is running for.
        /// </summary>
        /// <value>ID of the account the simulation is running for.</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; } 
        /// <summary>
        /// ID of the project the simulation belongs to
        /// </summary>
        /// <value>ID of the project the simulation belongs to</value>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        [JsonProperty("project_id")]
        public string ProjectId { get; set; } 
        /// <summary>
        /// ID of the recipe repository used to create the workflow
        /// </summary>
        /// <value>ID of the recipe repository used to create the workflow</value>
        [DataMember(Name="recipe_id", EmitDefaultValue=false)]
        [JsonProperty("recipe_id")]
        public string RecipeId { get; set; } 
        /// <summary>
        /// ID of the recipe owner
        /// </summary>
        /// <value>ID of the recipe owner</value>
        [DataMember(Name="recipe_owner_id", EmitDefaultValue=false)]
        [JsonProperty("recipe_owner_id")]
        public string RecipeOwnerId { get; set; } 
        /// <summary>
        /// ID of the specific recipe package used to create the workflow
        /// </summary>
        /// <value>ID of the specific recipe package used to create the workflow</value>
        [DataMember(Name="recipe_package_id", EmitDefaultValue=false)]
        [JsonProperty("recipe_package_id")]
        public string RecipePackageId { get; set; } 
        /// <summary>
        /// The max number of parallel tasks running for this simulation
        /// </summary>
        /// <value>The max number of parallel tasks running for this simulation</value>
        [DataMember(Name="parallelism", EmitDefaultValue=false)]
        [JsonProperty("parallelism")]
        public int Parallelism { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Entrypoint: ").Append(Entrypoint).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  RecipeOwnerId: ").Append(RecipeOwnerId).Append("\n");
            sb.Append("  RecipePackageId: ").Append(RecipePackageId).Append("\n");
            sb.Append("  Parallelism: ").Append(Parallelism).Append("\n");
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
        /// <returns>SimulationStatus object</returns>
        public static SimulationStatus FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimulationStatus>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimulationStatus object</returns>
        public SimulationStatus DuplicateSimulationStatus()
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
            return this.Equals(input as SimulationStatus);
        }

        /// <summary>
        /// Returns true if SimulationStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Entrypoint == input.Entrypoint ||
                    (this.Entrypoint != null &&
                    this.Entrypoint.Equals(input.Entrypoint))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.RecipeOwnerId == input.RecipeOwnerId ||
                    (this.RecipeOwnerId != null &&
                    this.RecipeOwnerId.Equals(input.RecipeOwnerId))
                ) && 
                (
                    this.RecipePackageId == input.RecipePackageId ||
                    (this.RecipePackageId != null &&
                    this.RecipePackageId.Equals(input.RecipePackageId))
                ) && 
                (
                    this.Parallelism == input.Parallelism ||
                    (this.Parallelism != null &&
                    this.Parallelism.Equals(input.Parallelism))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Entrypoint != null)
                    hashCode = hashCode * 59 + this.Entrypoint.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RecipeId != null)
                    hashCode = hashCode * 59 + this.RecipeId.GetHashCode();
                if (this.RecipeOwnerId != null)
                    hashCode = hashCode * 59 + this.RecipeOwnerId.GetHashCode();
                if (this.RecipePackageId != null)
                    hashCode = hashCode * 59 + this.RecipePackageId.GetHashCode();
                if (this.Parallelism != null)
                    hashCode = hashCode * 59 + this.Parallelism.GetHashCode();
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
