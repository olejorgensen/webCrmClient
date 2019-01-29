/* 
 * webCRM REST API
 *
 * Version: 1.0.0.0.<br>Note that you can access live data through this web site, so be careful when updating or deleting things.
 *
 * OpenAPI spec version: v1
 * Contact: api@webcrm.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace WebCrm.Rest.Model
{
    /// <summary>
    /// DocumentHookDto
    /// </summary>
    [DataContract]
    public partial class DocumentHookDto : BaseObject, IEquatable<DocumentHookDto>, IValidatableObject
    {
        /// <summary>
        /// Defines Filter
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FilterEnum
        {
            
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 1,
            
            /// <summary>
            /// Enum OrganisationOwner for value: OrganisationOwner
            /// </summary>
            [EnumMember(Value = "OrganisationOwner")]
            OrganisationOwner = 2,
            
            /// <summary>
            /// Enum OrganisationOwner2 for value: OrganisationOwner2
            /// </summary>
            [EnumMember(Value = "OrganisationOwner2")]
            OrganisationOwner2 = 3
        }


        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="Filter", EmitDefaultValue=false)]
        public List<FilterEnum> Filter { get; set; }
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum Create for value: Create
            /// </summary>
            [EnumMember(Value = "Create")]
            Create = 1,
            
            /// <summary>
            /// Enum Update for value: Update
            /// </summary>
            [EnumMember(Value = "Update")]
            Update = 2,
            
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 3
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="EventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentHookDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected DocumentHookDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentHookDto" /> class.
        /// </summary>
        /// <param name="Filter">Filter (required).</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="IsEnabled">IsEnabled (required).</param>
        /// <param name="TargetUrl">TargetUrl (required).</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="UpdatedBy">UpdatedBy.</param>
        public DocumentHookDto(List<FilterEnum> Filter = default(List<FilterEnum>), DateTime? CreatedAt = default(DateTime?), string CreatedBy = default(string), EventTypeEnum? EventType = default(EventTypeEnum?), long? Id = default(long?), bool? IsEnabled = default(bool?), string TargetUrl = default(string), DateTime? UpdatedAt = default(DateTime?), string UpdatedBy = default(string))
        {
            // to ensure "Filter" is required (not null)
            if (Filter == null)
            {
                throw new InvalidDataException("Filter is a required property for DocumentHookDto and cannot be null");
            }
            else
            {
                this.Filter = Filter;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for DocumentHookDto and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IsEnabled" is required (not null)
            if (IsEnabled == null)
            {
                throw new InvalidDataException("IsEnabled is a required property for DocumentHookDto and cannot be null");
            }
            else
            {
                this.IsEnabled = IsEnabled;
            }
            // to ensure "TargetUrl" is required (not null)
            if (TargetUrl == null)
            {
                throw new InvalidDataException("TargetUrl is a required property for DocumentHookDto and cannot be null");
            }
            else
            {
                this.TargetUrl = TargetUrl;
            }
            this.CreatedAt = CreatedAt;
            this.CreatedBy = CreatedBy;
            this.EventType = EventType;
            this.UpdatedAt = UpdatedAt;
            this.UpdatedBy = UpdatedBy;
        }
        

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets TargetUrl
        /// </summary>
        [DataMember(Name="TargetUrl", EmitDefaultValue=false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="UpdatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentHookDto);
        }

        /// <summary>
        /// Returns true if DocumentHookDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentHookDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentHookDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    this.Filter != null &&
                    this.Filter.SequenceEqual(input.Filter)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.TargetUrl == input.TargetUrl ||
                    (this.TargetUrl != null &&
                    this.TargetUrl.Equals(input.TargetUrl))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.TargetUrl != null)
                    hashCode = hashCode * 59 + this.TargetUrl.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
