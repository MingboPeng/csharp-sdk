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
    /// Parametric Job Status.
    /// </summary>
    [DataContract(Name = "JobStatus")]
    public partial class JobStatus : OpenAPIGenBaseModel, IEquatable<JobStatus>, IValidatableObject
    {
        /// <summary>
        /// The status of this job.
        /// </summary>
        /// <value>The status of this job.</value>
        [DataMember(Name="status")]
        public JobStatusEnum Status { get; set; } = JobStatusEnum.Unknown;
        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobStatus() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "JobStatus";
            this.ApiVersion = "v1beta1";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatus" /> class.
        /// </summary>
        /// <param name="id">The ID of the individual job. (required).</param>
        /// <param name="startedAt">The time at which the job was started (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="status">The status of this job..</param>
        /// <param name="message">Any message produced by the job. Usually error/debugging hints..</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="source">Source url for the status object. It can be a recipe or a function..</param>
        /// <param name="runsPending">The count of runs that are pending (default to 0).</param>
        /// <param name="runsRunning">The count of runs that are running (default to 0).</param>
        /// <param name="runsCompleted">The count of runs that have completed (default to 0).</param>
        /// <param name="runsFailed">The count of runs that have failed (default to 0).</param>
        /// <param name="runsCancelled">The count of runs that have been cancelled (default to 0).</param>
        public JobStatus
        (
           string id, DateTime startedAt, // Required parameters
           Dictionary<string, string> annotations= default, JobStatusEnum status= JobStatusEnum.Unknown, string message= default, DateTime finishedAt= default, string source= default, int runsPending = 0, int runsRunning = 0, int runsCompleted = 0, int runsFailed = 0, int runsCancelled = 0// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for JobStatus and cannot be null");
            this.StartedAt = startedAt;
            this.Annotations = annotations;
            this.Status = status;
            this.Message = message;
            this.FinishedAt = finishedAt;
            this.Source = source;
            this.RunsPending = runsPending;
            this.RunsRunning = runsRunning;
            this.RunsCompleted = runsCompleted;
            this.RunsFailed = runsFailed;
            this.RunsCancelled = runsCancelled;

            // Set non-required readonly properties with defaultValue
            this.Type = "JobStatus";
            this.ApiVersion = "v1beta1";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "JobStatus";
        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "api_version")]
        public string ApiVersion { get; protected set; }  = "v1beta1";

        /// <summary>
        /// The ID of the individual job.
        /// </summary>
        /// <value>The ID of the individual job.</value>
        [DataMember(Name = "id", IsRequired = true)]
        public string Id { get; set; } 
        /// <summary>
        /// The time at which the job was started
        /// </summary>
        /// <value>The time at which the job was started</value>
        [DataMember(Name = "started_at", IsRequired = true)]
        public DateTime StartedAt { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations")]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Any message produced by the job. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the job. Usually error/debugging hints.</value>
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
        /// The count of runs that are pending
        /// </summary>
        /// <value>The count of runs that are pending</value>
        [DataMember(Name = "runs_pending")]
        public int RunsPending { get; set; }  = 0;
        /// <summary>
        /// The count of runs that are running
        /// </summary>
        /// <value>The count of runs that are running</value>
        [DataMember(Name = "runs_running")]
        public int RunsRunning { get; set; }  = 0;
        /// <summary>
        /// The count of runs that have completed
        /// </summary>
        /// <value>The count of runs that have completed</value>
        [DataMember(Name = "runs_completed")]
        public int RunsCompleted { get; set; }  = 0;
        /// <summary>
        /// The count of runs that have failed
        /// </summary>
        /// <value>The count of runs that have failed</value>
        [DataMember(Name = "runs_failed")]
        public int RunsFailed { get; set; }  = 0;
        /// <summary>
        /// The count of runs that have been cancelled
        /// </summary>
        /// <value>The count of runs that have been cancelled</value>
        [DataMember(Name = "runs_cancelled")]
        public int RunsCancelled { get; set; }  = 0;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "JobStatus";
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
            sb.Append("JobStatus:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  StartedAt: ").Append(this.StartedAt).Append("\n");
            sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(this.ApiVersion).Append("\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            sb.Append("  FinishedAt: ").Append(this.FinishedAt).Append("\n");
            sb.Append("  Source: ").Append(this.Source).Append("\n");
            sb.Append("  RunsPending: ").Append(this.RunsPending).Append("\n");
            sb.Append("  RunsRunning: ").Append(this.RunsRunning).Append("\n");
            sb.Append("  RunsCompleted: ").Append(this.RunsCompleted).Append("\n");
            sb.Append("  RunsFailed: ").Append(this.RunsFailed).Append("\n");
            sb.Append("  RunsCancelled: ").Append(this.RunsCancelled).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>JobStatus object</returns>
        public static JobStatus FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<JobStatus>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>JobStatus object</returns>
        public virtual JobStatus DuplicateJobStatus()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateJobStatus();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateJobStatus();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as JobStatus);
        }

        /// <summary>
        /// Returns true if JobStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of JobStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobStatus input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.StartedAt, input.StartedAt) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Annotations == input.Annotations ||
                    Extension.AllEquals(this.Annotations, input.Annotations)
                ) && 
                    Extension.Equals(this.ApiVersion, input.ApiVersion) && 
                    Extension.Equals(this.Status, input.Status) && 
                    Extension.Equals(this.Message, input.Message) && 
                    Extension.Equals(this.FinishedAt, input.FinishedAt) && 
                    Extension.Equals(this.Source, input.Source) && 
                    Extension.Equals(this.RunsPending, input.RunsPending) && 
                    Extension.Equals(this.RunsRunning, input.RunsRunning) && 
                    Extension.Equals(this.RunsCompleted, input.RunsCompleted) && 
                    Extension.Equals(this.RunsFailed, input.RunsFailed) && 
                    Extension.Equals(this.RunsCancelled, input.RunsCancelled);
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.RunsPending != null)
                    hashCode = hashCode * 59 + this.RunsPending.GetHashCode();
                if (this.RunsRunning != null)
                    hashCode = hashCode * 59 + this.RunsRunning.GetHashCode();
                if (this.RunsCompleted != null)
                    hashCode = hashCode * 59 + this.RunsCompleted.GetHashCode();
                if (this.RunsFailed != null)
                    hashCode = hashCode * 59 + this.RunsFailed.GetHashCode();
                if (this.RunsCancelled != null)
                    hashCode = hashCode * 59 + this.RunsCancelled.GetHashCode();
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
            Regex regexType = new Regex(@"^JobStatus$", RegexOptions.CultureInvariant);
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
