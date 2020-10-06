/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.0.0
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


namespace PollinationSDK.Model
{
    /// <summary>
    /// UserPublic
    /// </summary>
    [DataContract]
    public partial class UserPublic :  IEquatable<UserPublic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublic" /> class.
        /// </summary>
        /// <param name="name">The display name for this user.</param>
        /// <param name="username">The lowercase account name for this user.</param>
        /// <param name="picture">URL to the picture associated with this user.</param>
        public UserPublic
        (
           // Required parameters
           string name= default, string username= default, string picture= default// Optional parameters
        )// BaseClass
        {
            this.Name = name;
            this.Username = username;
            this.Picture = picture;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The display name for this user
        /// </summary>
        /// <value>The display name for this user</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The lowercase account name for this user
        /// </summary>
        /// <value>The lowercase account name for this user</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        [JsonProperty("username")]
        public string Username { get; set; } 
        /// <summary>
        /// URL to the picture associated with this user
        /// </summary>
        /// <value>URL to the picture associated with this user</value>
        [DataMember(Name="picture", EmitDefaultValue=false)]
        [JsonProperty("picture")]
        public string Picture { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPublic {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
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
        /// <returns>UserPublic object</returns>
        public static UserPublic FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<UserPublic>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>UserPublic object</returns>
        public UserPublic DuplicateUserPublic()
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
            return this.Equals(input as UserPublic);
        }

        /// <summary>
        /// Returns true if UserPublic instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPublic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPublic input)
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Picture != null)
                    hashCode = hashCode * 59 + this.Picture.GetHashCode();
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
