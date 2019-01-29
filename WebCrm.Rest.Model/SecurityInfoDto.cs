/* 
 * webCRM REST API
 *
 * Version: 1.0.0.0.<br>Note that you can access live data through this web site, so be careful when updating or deleting things.
 *
 * OpenAPI spec version: v1
 * Contact: api@webcrm.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebCrm.Rest.Model
{
    /// <summary>
    /// SecurityInfoDto
    /// </summary>
    [DataContract]
    public partial class SecurityInfoDto : BaseObject, IEquatable<SecurityInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityInfoDto" /> class.
        /// </summary>
        /// <param name="CanEdit">CanEdit.</param>
        public SecurityInfoDto(bool? CanEdit = default(bool?))
        {
            this.CanEdit = CanEdit;
        }
        
        /// <summary>
        /// Gets or Sets CanEdit
        /// </summary>
        [DataMember(Name="CanEdit", EmitDefaultValue=false)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityInfoDto);
        }

        /// <summary>
        /// Returns true if SecurityInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanEdit == input.CanEdit ||
                    (this.CanEdit != null &&
                    this.CanEdit.Equals(input.CanEdit))
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
                if (this.CanEdit != null)
                    hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
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