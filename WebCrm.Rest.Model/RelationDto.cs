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
using System.Runtime.Serialization;

namespace WebCrm.Rest.Model
{
    /// <summary>
    /// RelationDto
    /// </summary>
    [DataContract]
    public partial class RelationDto : BaseObject, IEquatable<RelationDto>, IValidatableObject
    {
        /// <summary>
        /// Defines RelationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelationTypeEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum PersonToPerson for value: PersonToPerson
            /// </summary>
            [EnumMember(Value = "PersonToPerson")]
            PersonToPerson = 2,
            
            /// <summary>
            /// Enum OrganisationToPerson for value: OrganisationToPerson
            /// </summary>
            [EnumMember(Value = "OrganisationToPerson")]
            OrganisationToPerson = 3,
            
            /// <summary>
            /// Enum OrganisationToOrganisation for value: OrganisationToOrganisation
            /// </summary>
            [EnumMember(Value = "OrganisationToOrganisation")]
            OrganisationToOrganisation = 4,
            
            /// <summary>
            /// Enum LinkedOrganisations for value: LinkedOrganisations
            /// </summary>
            [EnumMember(Value = "LinkedOrganisations")]
            LinkedOrganisations = 5
        }

        /// <summary>
        /// Gets or Sets RelationType
        /// </summary>
        [DataMember(Name="RelationType", EmitDefaultValue=false)]
        public RelationTypeEnum? RelationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected RelationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationDto" /> class.
        /// </summary>
        /// <param name="RelationCode">RelationCode.</param>
        /// <param name="RelationComment">RelationComment.</param>
        /// <param name="RelationCreatedAt">RelationCreatedAt.</param>
        /// <param name="RelationCreatedBy">RelationCreatedBy.</param>
        /// <param name="RelationId">RelationId (required).</param>
        /// <param name="RelationOrganisation1Id">RelationOrganisation1Id.</param>
        /// <param name="RelationOrganisation2Id">RelationOrganisation2Id.</param>
        /// <param name="RelationPerson1Id">RelationPerson1Id.</param>
        /// <param name="RelationPerson2Id">RelationPerson2Id.</param>
        /// <param name="RelationType">RelationType.</param>
        /// <param name="RelationUpdatedAt">RelationUpdatedAt.</param>
        /// <param name="RelationUpdatedBy">RelationUpdatedBy.</param>
        public RelationDto(int? RelationCode = default(int?), string RelationComment = default(string), DateTime? RelationCreatedAt = default(DateTime?), string RelationCreatedBy = default(string), int? RelationId = default(int?), int? RelationOrganisation1Id = default(int?), int? RelationOrganisation2Id = default(int?), int? RelationPerson1Id = default(int?), int? RelationPerson2Id = default(int?), RelationTypeEnum? RelationType = default(RelationTypeEnum?), DateTime? RelationUpdatedAt = default(DateTime?), string RelationUpdatedBy = default(string))
        {
            // to ensure "RelationId" is required (not null)
            if (RelationId == null)
            {
                throw new InvalidDataException("RelationId is a required property for RelationDto and cannot be null");
            }
            else
            {
                this.RelationId = RelationId;
            }
            this.RelationCode = RelationCode;
            this.RelationComment = RelationComment;
            this.RelationCreatedAt = RelationCreatedAt;
            this.RelationCreatedBy = RelationCreatedBy;
            this.RelationOrganisation1Id = RelationOrganisation1Id;
            this.RelationOrganisation2Id = RelationOrganisation2Id;
            this.RelationPerson1Id = RelationPerson1Id;
            this.RelationPerson2Id = RelationPerson2Id;
            this.RelationType = RelationType;
            this.RelationUpdatedAt = RelationUpdatedAt;
            this.RelationUpdatedBy = RelationUpdatedBy;
        }
        
        /// <summary>
        /// Gets or Sets RelationCode
        /// </summary>
        [DataMember(Name="RelationCode", EmitDefaultValue=false)]
        public int? RelationCode { get; set; }

        /// <summary>
        /// Gets or Sets RelationComment
        /// </summary>
        [DataMember(Name="RelationComment", EmitDefaultValue=false)]
        public string RelationComment { get; set; }

        /// <summary>
        /// Gets or Sets RelationCreatedAt
        /// </summary>
        [DataMember(Name="RelationCreatedAt", EmitDefaultValue=false)]
        public DateTime? RelationCreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets RelationCreatedBy
        /// </summary>
        [DataMember(Name="RelationCreatedBy", EmitDefaultValue=false)]
        public string RelationCreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets RelationId
        /// </summary>
        [DataMember(Name="RelationId", EmitDefaultValue=false)]
        public int? RelationId { get; set; }

        /// <summary>
        /// Gets or Sets RelationOrganisation1Id
        /// </summary>
        [DataMember(Name="RelationOrganisation1Id", EmitDefaultValue=false)]
        public int? RelationOrganisation1Id { get; set; }

        /// <summary>
        /// Gets or Sets RelationOrganisation2Id
        /// </summary>
        [DataMember(Name="RelationOrganisation2Id", EmitDefaultValue=false)]
        public int? RelationOrganisation2Id { get; set; }

        /// <summary>
        /// Gets or Sets RelationPerson1Id
        /// </summary>
        [DataMember(Name="RelationPerson1Id", EmitDefaultValue=false)]
        public int? RelationPerson1Id { get; set; }

        /// <summary>
        /// Gets or Sets RelationPerson2Id
        /// </summary>
        [DataMember(Name="RelationPerson2Id", EmitDefaultValue=false)]
        public int? RelationPerson2Id { get; set; }


        /// <summary>
        /// Gets or Sets RelationUpdatedAt
        /// </summary>
        [DataMember(Name="RelationUpdatedAt", EmitDefaultValue=false)]
        public DateTime? RelationUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets RelationUpdatedBy
        /// </summary>
        [DataMember(Name="RelationUpdatedBy", EmitDefaultValue=false)]
        public string RelationUpdatedBy { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationDto);
        }

        /// <summary>
        /// Returns true if RelationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RelationCode == input.RelationCode ||
                    (this.RelationCode != null &&
                    this.RelationCode.Equals(input.RelationCode))
                ) && 
                (
                    this.RelationComment == input.RelationComment ||
                    (this.RelationComment != null &&
                    this.RelationComment.Equals(input.RelationComment))
                ) && 
                (
                    this.RelationCreatedAt == input.RelationCreatedAt ||
                    (this.RelationCreatedAt != null &&
                    this.RelationCreatedAt.Equals(input.RelationCreatedAt))
                ) && 
                (
                    this.RelationCreatedBy == input.RelationCreatedBy ||
                    (this.RelationCreatedBy != null &&
                    this.RelationCreatedBy.Equals(input.RelationCreatedBy))
                ) && 
                (
                    this.RelationId == input.RelationId ||
                    (this.RelationId != null &&
                    this.RelationId.Equals(input.RelationId))
                ) && 
                (
                    this.RelationOrganisation1Id == input.RelationOrganisation1Id ||
                    (this.RelationOrganisation1Id != null &&
                    this.RelationOrganisation1Id.Equals(input.RelationOrganisation1Id))
                ) && 
                (
                    this.RelationOrganisation2Id == input.RelationOrganisation2Id ||
                    (this.RelationOrganisation2Id != null &&
                    this.RelationOrganisation2Id.Equals(input.RelationOrganisation2Id))
                ) && 
                (
                    this.RelationPerson1Id == input.RelationPerson1Id ||
                    (this.RelationPerson1Id != null &&
                    this.RelationPerson1Id.Equals(input.RelationPerson1Id))
                ) && 
                (
                    this.RelationPerson2Id == input.RelationPerson2Id ||
                    (this.RelationPerson2Id != null &&
                    this.RelationPerson2Id.Equals(input.RelationPerson2Id))
                ) && 
                (
                    this.RelationType == input.RelationType ||
                    (this.RelationType != null &&
                    this.RelationType.Equals(input.RelationType))
                ) && 
                (
                    this.RelationUpdatedAt == input.RelationUpdatedAt ||
                    (this.RelationUpdatedAt != null &&
                    this.RelationUpdatedAt.Equals(input.RelationUpdatedAt))
                ) && 
                (
                    this.RelationUpdatedBy == input.RelationUpdatedBy ||
                    (this.RelationUpdatedBy != null &&
                    this.RelationUpdatedBy.Equals(input.RelationUpdatedBy))
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
                if (this.RelationCode != null)
                    hashCode = hashCode * 59 + this.RelationCode.GetHashCode();
                if (this.RelationComment != null)
                    hashCode = hashCode * 59 + this.RelationComment.GetHashCode();
                if (this.RelationCreatedAt != null)
                    hashCode = hashCode * 59 + this.RelationCreatedAt.GetHashCode();
                if (this.RelationCreatedBy != null)
                    hashCode = hashCode * 59 + this.RelationCreatedBy.GetHashCode();
                if (this.RelationId != null)
                    hashCode = hashCode * 59 + this.RelationId.GetHashCode();
                if (this.RelationOrganisation1Id != null)
                    hashCode = hashCode * 59 + this.RelationOrganisation1Id.GetHashCode();
                if (this.RelationOrganisation2Id != null)
                    hashCode = hashCode * 59 + this.RelationOrganisation2Id.GetHashCode();
                if (this.RelationPerson1Id != null)
                    hashCode = hashCode * 59 + this.RelationPerson1Id.GetHashCode();
                if (this.RelationPerson2Id != null)
                    hashCode = hashCode * 59 + this.RelationPerson2Id.GetHashCode();
                if (this.RelationType != null)
                    hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RelationUpdatedAt != null)
                    hashCode = hashCode * 59 + this.RelationUpdatedAt.GetHashCode();
                if (this.RelationUpdatedBy != null)
                    hashCode = hashCode * 59 + this.RelationUpdatedBy.GetHashCode();
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