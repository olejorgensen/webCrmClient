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
using System.Linq;
using System.Runtime.Serialization;

namespace WebCrm.Rest.Model
{
    /// <summary>
    /// ObjectDto
    /// </summary>
    [DataContract]
    public partial class ObjectDto : BaseObject, IEquatable<ObjectDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDto" /> class.
        /// </summary>
        /// <param name="_Object">_Object.</param>
        public ObjectDto(Dictionary<string, object> _Object = default(Dictionary<string, object>))
        {
            this._Object = _Object;
        }
        
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="Object", EmitDefaultValue=false)]
        public Dictionary<string, object> _Object { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectDto);
        }

        /// <summary>
        /// Returns true if ObjectDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Object == input._Object ||
                    this._Object != null &&
                    this._Object.SequenceEqual(input._Object)
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
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
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