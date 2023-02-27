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
    /// LicensePublic
    /// </summary>
    [DataContract(Name = "LicensePublic")]
    public partial class LicensePublic : License, IEquatable<LicensePublic>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LicenseType LicenseType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePublic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicensePublic() 
        { 
            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePublic" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="key">The key used to activate this license. Treat this like a password. (required).</param>
        /// <param name="revoked">revoked (required).</param>
        /// <param name="suspended">suspended (required).</param>
        /// <param name="totalActivations">totalActivations (required).</param>
        /// <param name="totalDeactivations">totalDeactivations (required).</param>
        /// <param name="validity">validity (required).</param>
        /// <param name="allowedActivations">allowedActivations (required).</param>
        /// <param name="serverSyncGracePeriod">serverSyncGracePeriod (required).</param>
        /// <param name="serverSyncInterval">serverSyncInterval (required).</param>
        /// <param name="leaseDuration">leaseDuration (required).</param>
        /// <param name="productId">productId (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="type">type (required) (default to &quot;LicensePublic&quot;).</param>
        /// <param name="notes">notes.</param>
        /// <param name="name">The license name used for the package. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="url">A URL to the license used for the package..</param>
        public LicensePublic
        (
            string id, DateTime createdAt, DateTime updatedAt, string key, bool revoked, bool suspended, int totalActivations, int totalDeactivations, int validity, int allowedActivations, int serverSyncGracePeriod, int serverSyncInterval, int leaseDuration, string productId, List<LicenseMetadata> metadata, LicenseType type, // Required parameters
            Dictionary<string, string> annotations= default, string url= default, string notes= default// Optional parameters
        ) : base(annotations: annotations, url: url)// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for LicensePublic and cannot be null");
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            // to ensure "key" is required (not null)
            this.Key = key ?? throw new ArgumentNullException("key is a required property for LicensePublic and cannot be null");
            this.Revoked = revoked;
            this.Suspended = suspended;
            this.TotalActivations = totalActivations;
            this.TotalDeactivations = totalDeactivations;
            this.Validity = validity;
            this.AllowedActivations = allowedActivations;
            this.ServerSyncGracePeriod = serverSyncGracePeriod;
            this.ServerSyncInterval = serverSyncInterval;
            this.LeaseDuration = leaseDuration;
            // to ensure "productId" is required (not null)
            this.ProductId = productId ?? throw new ArgumentNullException("productId is a required property for LicensePublic and cannot be null");
            // to ensure "metadata" is required (not null)
            this.Metadata = metadata ?? throw new ArgumentNullException("metadata is a required property for LicensePublic and cannot be null");
            this.LicenseType = type;
            this.Notes = notes;

            // Set non-required readonly properties with defaultValue
        }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; } 
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; } 
        /// <summary>
        /// The key used to activate this license. Treat this like a password.
        /// </summary>
        /// <value>The key used to activate this license. Treat this like a password.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; } 
        /// <summary>
        /// Gets or Sets Revoked
        /// </summary>
        [DataMember(Name = "revoked", IsRequired = true, EmitDefaultValue = false)]
        public bool Revoked { get; set; } 
        /// <summary>
        /// Gets or Sets Suspended
        /// </summary>
        [DataMember(Name = "suspended", IsRequired = true, EmitDefaultValue = false)]
        public bool Suspended { get; set; } 
        /// <summary>
        /// Gets or Sets TotalActivations
        /// </summary>
        [DataMember(Name = "total_activations", IsRequired = true, EmitDefaultValue = false)]
        public int TotalActivations { get; set; } 
        /// <summary>
        /// Gets or Sets TotalDeactivations
        /// </summary>
        [DataMember(Name = "total_deactivations", IsRequired = true, EmitDefaultValue = false)]
        public int TotalDeactivations { get; set; } 
        /// <summary>
        /// Gets or Sets Validity
        /// </summary>
        [DataMember(Name = "validity", IsRequired = true, EmitDefaultValue = false)]
        public int Validity { get; set; } 
        /// <summary>
        /// Gets or Sets AllowedActivations
        /// </summary>
        [DataMember(Name = "allowed_activations", IsRequired = true, EmitDefaultValue = false)]
        public int AllowedActivations { get; set; } 
        /// <summary>
        /// Gets or Sets ServerSyncGracePeriod
        /// </summary>
        [DataMember(Name = "server_sync_grace_period", IsRequired = true, EmitDefaultValue = false)]
        public int ServerSyncGracePeriod { get; set; } 
        /// <summary>
        /// Gets or Sets ServerSyncInterval
        /// </summary>
        [DataMember(Name = "server_sync_interval", IsRequired = true, EmitDefaultValue = false)]
        public int ServerSyncInterval { get; set; } 
        /// <summary>
        /// Gets or Sets LeaseDuration
        /// </summary>
        [DataMember(Name = "lease_duration", IsRequired = true, EmitDefaultValue = false)]
        public int LeaseDuration { get; set; } 
        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name = "product_id", IsRequired = true, EmitDefaultValue = false)]
        public string ProductId { get; set; } 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = false)]
        public List<LicenseMetadata> Metadata { get; set; } 
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "LicensePublic";
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
            sb.Append("LicensePublic:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Revoked: ").Append(Revoked).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  TotalActivations: ").Append(TotalActivations).Append("\n");
            sb.Append("  TotalDeactivations: ").Append(TotalDeactivations).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  AllowedActivations: ").Append(AllowedActivations).Append("\n");
            sb.Append("  ServerSyncGracePeriod: ").Append(ServerSyncGracePeriod).Append("\n");
            sb.Append("  ServerSyncInterval: ").Append(ServerSyncInterval).Append("\n");
            sb.Append("  LeaseDuration: ").Append(LeaseDuration).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>LicensePublic object</returns>
        public static LicensePublic FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LicensePublic>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LicensePublic object</returns>
        public virtual LicensePublic DuplicateLicensePublic()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateLicensePublic();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override License DuplicateLicense()
        {
            return DuplicateLicensePublic();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as LicensePublic);
        }

        /// <summary>
        /// Returns true if LicensePublic instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePublic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePublic input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && base.Equals(input) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && base.Equals(input) && 
                (
                    this.Revoked == input.Revoked ||
                    (this.Revoked != null &&
                    this.Revoked.Equals(input.Revoked))
                ) && base.Equals(input) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && base.Equals(input) && 
                (
                    this.TotalActivations == input.TotalActivations ||
                    (this.TotalActivations != null &&
                    this.TotalActivations.Equals(input.TotalActivations))
                ) && base.Equals(input) && 
                (
                    this.TotalDeactivations == input.TotalDeactivations ||
                    (this.TotalDeactivations != null &&
                    this.TotalDeactivations.Equals(input.TotalDeactivations))
                ) && base.Equals(input) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
                ) && base.Equals(input) && 
                (
                    this.AllowedActivations == input.AllowedActivations ||
                    (this.AllowedActivations != null &&
                    this.AllowedActivations.Equals(input.AllowedActivations))
                ) && base.Equals(input) && 
                (
                    this.ServerSyncGracePeriod == input.ServerSyncGracePeriod ||
                    (this.ServerSyncGracePeriod != null &&
                    this.ServerSyncGracePeriod.Equals(input.ServerSyncGracePeriod))
                ) && base.Equals(input) && 
                (
                    this.ServerSyncInterval == input.ServerSyncInterval ||
                    (this.ServerSyncInterval != null &&
                    this.ServerSyncInterval.Equals(input.ServerSyncInterval))
                ) && base.Equals(input) && 
                (
                    this.LeaseDuration == input.LeaseDuration ||
                    (this.LeaseDuration != null &&
                    this.LeaseDuration.Equals(input.LeaseDuration))
                ) && base.Equals(input) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && base.Equals(input) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Revoked != null)
                    hashCode = hashCode * 59 + this.Revoked.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.TotalActivations != null)
                    hashCode = hashCode * 59 + this.TotalActivations.GetHashCode();
                if (this.TotalDeactivations != null)
                    hashCode = hashCode * 59 + this.TotalDeactivations.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
                if (this.AllowedActivations != null)
                    hashCode = hashCode * 59 + this.AllowedActivations.GetHashCode();
                if (this.ServerSyncGracePeriod != null)
                    hashCode = hashCode * 59 + this.ServerSyncGracePeriod.GetHashCode();
                if (this.ServerSyncInterval != null)
                    hashCode = hashCode * 59 + this.ServerSyncInterval.GetHashCode();
                if (this.LeaseDuration != null)
                    hashCode = hashCode * 59 + this.LeaseDuration.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
            yield break;
        }
    }
}