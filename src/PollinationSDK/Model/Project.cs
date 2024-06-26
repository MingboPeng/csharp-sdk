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
    /// Project
    /// </summary>
    [DataContract(Name = "Project")]
    public partial class Project : ProjectCreate, IEquatable<Project>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Project() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Project";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">The project ID (required).</param>
        /// <param name="owner">The project owner (required).</param>
        /// <param name="permissions">permissions (required).</param>
        /// <param name="slug">The project name in slug format (required).</param>
        /// <param name="usage">The resource consumption of this project.</param>
        /// <param name="name">The name of the project. Must be unique to a given owner (required).</param>
        /// <param name="description">A description of the project (default to &quot;&quot;).</param>
        /// <param name="_public">Whether or not a project is publicly viewable (default to true).</param>
        public Project
        (
            string name, string id, AccountPublic owner, UserPermission permissions, string slug, // Required parameters
            string description = "", bool _public = true, Usage usage= default // Optional parameters
        ) : base(name: name, description: description, _public: _public )// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Project and cannot be null");
            // to ensure "owner" is required (not null)
            this.Owner = owner ?? throw new ArgumentNullException("owner is a required property for Project and cannot be null");
            // to ensure "permissions" is required (not null)
            this.Permissions = permissions ?? throw new ArgumentNullException("permissions is a required property for Project and cannot be null");
            // to ensure "slug" is required (not null)
            this.Slug = slug ?? throw new ArgumentNullException("slug is a required property for Project and cannot be null");
            this.Usage = usage;

            // Set non-required readonly properties with defaultValue
            this.Type = "Project";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Project";

        /// <summary>
        /// The project ID
        /// </summary>
        /// <value>The project ID</value>
        [DataMember(Name = "id", IsRequired = true)]
        public string Id { get; set; } 
        /// <summary>
        /// The project owner
        /// </summary>
        /// <value>The project owner</value>
        [DataMember(Name = "owner", IsRequired = true)]
        public AccountPublic Owner { get; set; } 
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", IsRequired = true)]
        public UserPermission Permissions { get; set; } 
        /// <summary>
        /// The project name in slug format
        /// </summary>
        /// <value>The project name in slug format</value>
        [DataMember(Name = "slug", IsRequired = true)]
        public string Slug { get; set; } 
        /// <summary>
        /// The resource consumption of this project
        /// </summary>
        /// <value>The resource consumption of this project</value>
        [DataMember(Name = "usage")]
        public Usage Usage { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Project";
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
            sb.Append("Project:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Public: ").Append(this.Public).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Owner: ").Append(this.Owner).Append("\n");
            sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
            sb.Append("  Slug: ").Append(this.Slug).Append("\n");
            sb.Append("  Usage: ").Append(this.Usage).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Project object</returns>
        public static Project FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Project>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Project object</returns>
        public virtual Project DuplicateProject()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateProject();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override ProjectCreate DuplicateProjectCreate()
        {
            return DuplicateProject();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="input">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.Owner, input.Owner) && 
                    Extension.Equals(this.Permissions, input.Permissions) && 
                    Extension.Equals(this.Slug, input.Slug) && 
                    Extension.Equals(this.Usage, input.Usage) && 
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
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
            Regex regexType = new Regex(@"^Project$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
