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
    /// UserPrivate
    /// </summary>
    [DataContract(Name = "UserPrivate")]
    public partial class UserPrivate : OpenAPIGenBaseModel, IEquatable<UserPrivate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPrivate() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "UserPrivate";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivate" /> class.
        /// </summary>
        /// <param name="id">The unique ID for that user (required).</param>
        /// <param name="email">The email associated with that user (required).</param>
        /// <param name="username">The lowercase account name for this user (required).</param>
        /// <param name="name">The display name for this user.</param>
        /// <param name="description">A short description of the user.</param>
        /// <param name="picture">URL to the picture associated with this user.</param>
        public UserPrivate
        (
           string id, string email, string username, // Required parameters
           string name= default, string description= default, string picture= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for UserPrivate and cannot be null");
            // to ensure "email" is required (not null)
            this.Email = email ?? throw new ArgumentNullException("email is a required property for UserPrivate and cannot be null");
            // to ensure "username" is required (not null)
            this.Username = username ?? throw new ArgumentNullException("username is a required property for UserPrivate and cannot be null");
            this.Name = name;
            this.Description = description;
            this.Picture = picture;

            // Set non-required readonly properties with defaultValue
            this.Type = "UserPrivate";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "UserPrivate";

        /// <summary>
        /// The unique ID for that user
        /// </summary>
        /// <value>The unique ID for that user</value>
        [DataMember(Name = "id", IsRequired = true)]
        public string Id { get; set; } 
        /// <summary>
        /// The email associated with that user
        /// </summary>
        /// <value>The email associated with that user</value>
        [DataMember(Name = "email", IsRequired = true)]
        public string Email { get; set; } 
        /// <summary>
        /// The lowercase account name for this user
        /// </summary>
        /// <value>The lowercase account name for this user</value>
        [DataMember(Name = "username", IsRequired = true)]
        public string Username { get; set; } 
        /// <summary>
        /// The display name for this user
        /// </summary>
        /// <value>The display name for this user</value>
        [DataMember(Name = "name")]
        public string Name { get; set; } 
        /// <summary>
        /// A short description of the user
        /// </summary>
        /// <value>A short description of the user</value>
        [DataMember(Name = "description")]
        public string Description { get; set; } 
        /// <summary>
        /// URL to the picture associated with this user
        /// </summary>
        /// <value>URL to the picture associated with this user</value>
        [DataMember(Name = "picture")]
        public string Picture { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "UserPrivate";
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
            sb.Append("UserPrivate:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Email: ").Append(this.Email).Append("\n");
            sb.Append("  Username: ").Append(this.Username).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Picture: ").Append(this.Picture).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>UserPrivate object</returns>
        public static UserPrivate FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserPrivate>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserPrivate object</returns>
        public virtual UserPrivate DuplicateUserPrivate()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateUserPrivate();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateUserPrivate();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as UserPrivate);
        }

        /// <summary>
        /// Returns true if UserPrivate instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPrivate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPrivate input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Id, input.Id) && 
                    Extension.Equals(this.Email, input.Email) && 
                    Extension.Equals(this.Username, input.Username) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.Description, input.Description) && 
                    Extension.Equals(this.Picture, input.Picture) && 
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Picture != null)
                    hashCode = hashCode * 59 + this.Picture.GetHashCode();
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
            Regex regexType = new Regex(@"^UserPrivate$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
