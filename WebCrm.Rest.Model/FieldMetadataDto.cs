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
using System.Linq;
using System.Runtime.Serialization;

namespace WebCrm.Rest.Model
{
    /// <summary>
    /// FieldMetadataDto
    /// </summary>
    [DataContract]
    public partial class FieldMetadataDto : BaseObject, IEquatable<FieldMetadataDto>, IValidatableObject
    {
        /// <summary>
        /// Defines FieldMetadataDisplayType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldMetadataDisplayTypeEnum
        {
            
            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 1,
            
            /// <summary>
            /// Enum CPL for value: CPL
            /// </summary>
            [EnumMember(Value = "CPL")]
            CPL = 2,
            
            /// <summary>
            /// Enum D for value: D
            /// </summary>
            [EnumMember(Value = "D")]
            D = 3,
            
            /// <summary>
            /// Enum DA for value: DA
            /// </summary>
            [EnumMember(Value = "DA")]
            DA = 4,
            
            /// <summary>
            /// Enum DAT for value: DAT
            /// </summary>
            [EnumMember(Value = "DAT")]
            DAT = 5,
            
            /// <summary>
            /// Enum DI for value: DI
            /// </summary>
            [EnumMember(Value = "DI")]
            DI = 6,
            
            /// <summary>
            /// Enum DT for value: DT
            /// </summary>
            [EnumMember(Value = "DT")]
            DT = 7,
            
            /// <summary>
            /// Enum DTGMT for value: DTGMT
            /// </summary>
            [EnumMember(Value = "DTGMT")]
            DTGMT = 8,
            
            /// <summary>
            /// Enum EMA for value: EMA
            /// </summary>
            [EnumMember(Value = "EMA")]
            EMA = 9,
            
            /// <summary>
            /// Enum GM for value: GM
            /// </summary>
            [EnumMember(Value = "GM")]
            GM = 10,
            
            /// <summary>
            /// Enum HM for value: HM
            /// </summary>
            [EnumMember(Value = "HM")]
            HM = 11,
            
            /// <summary>
            /// Enum HTML for value: HTML
            /// </summary>
            [EnumMember(Value = "HTML")]
            HTML = 12,
            
            /// <summary>
            /// Enum HX for value: HX
            /// </summary>
            [EnumMember(Value = "HX")]
            HX = 13,
            
            /// <summary>
            /// Enum I for value: I
            /// </summary>
            [EnumMember(Value = "I")]
            I = 14,
            
            /// <summary>
            /// Enum IC for value: IC
            /// </summary>
            [EnumMember(Value = "IC")]
            IC = 15,
            
            /// <summary>
            /// Enum IS for value: IS
            /// </summary>
            [EnumMember(Value = "IS")]
            IS = 16,
            
            /// <summary>
            /// Enum L for value: L
            /// </summary>
            [EnumMember(Value = "L")]
            L = 17,
            
            /// <summary>
            /// Enum LOGA for value: LOGA
            /// </summary>
            [EnumMember(Value = "LOGA")]
            LOGA = 18,
            
            /// <summary>
            /// Enum LOGP for value: LOGP
            /// </summary>
            [EnumMember(Value = "LOGP")]
            LOGP = 19,
            
            /// <summary>
            /// Enum M for value: M
            /// </summary>
            [EnumMember(Value = "M")]
            M = 20,
            
            /// <summary>
            /// Enum ML for value: ML
            /// </summary>
            [EnumMember(Value = "ML")]
            ML = 21,
            
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 22,
            
            /// <summary>
            /// Enum PI for value: PI
            /// </summary>
            [EnumMember(Value = "PI")]
            PI = 23,
            
            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 24,
            
            /// <summary>
            /// Enum REV for value: REV
            /// </summary>
            [EnumMember(Value = "REV")]
            REV = 25,
            
            /// <summary>
            /// Enum SD for value: SD
            /// </summary>
            [EnumMember(Value = "SD")]
            SD = 26,
            
            /// <summary>
            /// Enum SDI for value: SDI
            /// </summary>
            [EnumMember(Value = "SDI")]
            SDI = 27,
            
            /// <summary>
            /// Enum T for value: T
            /// </summary>
            [EnumMember(Value = "T")]
            T = 28,
            
            /// <summary>
            /// Enum TELE for value: TELE
            /// </summary>
            [EnumMember(Value = "TELE")]
            TELE = 29,
            
            /// <summary>
            /// Enum TM for value: TM
            /// </summary>
            [EnumMember(Value = "TM")]
            TM = 30,
            
            /// <summary>
            /// Enum UI for value: UI
            /// </summary>
            [EnumMember(Value = "UI")]
            UI = 31,
            
            /// <summary>
            /// Enum KPI for value: KPI
            /// </summary>
            [EnumMember(Value = "KPI")]
            KPI = 32
        }

        /// <summary>
        /// Gets or Sets FieldMetadataDisplayType
        /// </summary>
        [DataMember(Name="FieldMetadataDisplayType", EmitDefaultValue=false)]
        public FieldMetadataDisplayTypeEnum? FieldMetadataDisplayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldMetadataDto" /> class.
        /// </summary>
        /// <param name="FieldMetadataDbFieldName">FieldMetadataDbFieldName.</param>
        /// <param name="FieldMetadataFriendlyFieldName">FieldMetadataFriendlyFieldName.</param>
        /// <param name="FieldMetadataId">FieldMetadataId.</param>
        /// <param name="FieldMetadataLabel">FieldMetadataLabel.</param>
        /// <param name="FieldMetadataSortOrder">FieldMetadataSortOrder.</param>
        /// <param name="FieldMetadataDisplayType">FieldMetadataDisplayType.</param>
        /// <param name="FieldMetadataTextFieldMaxLength">FieldMetadataTextFieldMaxLength.</param>
        /// <param name="FieldMetadataDropdownListData">FieldMetadataDropdownListData.</param>
        public FieldMetadataDto(string FieldMetadataDbFieldName = default(string), string FieldMetadataFriendlyFieldName = default(string), int? FieldMetadataId = default(int?), string FieldMetadataLabel = default(string), int? FieldMetadataSortOrder = default(int?), FieldMetadataDisplayTypeEnum? FieldMetadataDisplayType = default(FieldMetadataDisplayTypeEnum?), int? FieldMetadataTextFieldMaxLength = default(int?), List<FieldMetadataDropdownListDto> FieldMetadataDropdownListData = default(List<FieldMetadataDropdownListDto>))
        {
            this.FieldMetadataDbFieldName = FieldMetadataDbFieldName;
            this.FieldMetadataFriendlyFieldName = FieldMetadataFriendlyFieldName;
            this.FieldMetadataId = FieldMetadataId;
            this.FieldMetadataLabel = FieldMetadataLabel;
            this.FieldMetadataSortOrder = FieldMetadataSortOrder;
            this.FieldMetadataDisplayType = FieldMetadataDisplayType;
            this.FieldMetadataTextFieldMaxLength = FieldMetadataTextFieldMaxLength;
            this.FieldMetadataDropdownListData = FieldMetadataDropdownListData;
        }
        
        /// <summary>
        /// Gets or Sets FieldMetadataDbFieldName
        /// </summary>
        [DataMember(Name="FieldMetadataDbFieldName", EmitDefaultValue=false)]
        public string FieldMetadataDbFieldName { get; set; }

        /// <summary>
        /// Gets or Sets FieldMetadataFriendlyFieldName
        /// </summary>
        [DataMember(Name="FieldMetadataFriendlyFieldName", EmitDefaultValue=false)]
        public string FieldMetadataFriendlyFieldName { get; set; }

        /// <summary>
        /// Gets or Sets FieldMetadataId
        /// </summary>
        [DataMember(Name="FieldMetadataId", EmitDefaultValue=false)]
        public int? FieldMetadataId { get; set; }

        /// <summary>
        /// Gets or Sets FieldMetadataLabel
        /// </summary>
        [DataMember(Name="FieldMetadataLabel", EmitDefaultValue=false)]
        public string FieldMetadataLabel { get; set; }

        /// <summary>
        /// Gets or Sets FieldMetadataSortOrder
        /// </summary>
        [DataMember(Name="FieldMetadataSortOrder", EmitDefaultValue=false)]
        public int? FieldMetadataSortOrder { get; set; }


        /// <summary>
        /// Gets or Sets FieldMetadataTextFieldMaxLength
        /// </summary>
        [DataMember(Name="FieldMetadataTextFieldMaxLength", EmitDefaultValue=false)]
        public int? FieldMetadataTextFieldMaxLength { get; set; }

        /// <summary>
        /// Gets or Sets FieldMetadataDropdownListData
        /// </summary>
        [DataMember(Name="FieldMetadataDropdownListData", EmitDefaultValue=false)]
        public List<FieldMetadataDropdownListDto> FieldMetadataDropdownListData { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FieldMetadataDto);
        }

        /// <summary>
        /// Returns true if FieldMetadataDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldMetadataDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldMetadataDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldMetadataDbFieldName == input.FieldMetadataDbFieldName ||
                    (this.FieldMetadataDbFieldName != null &&
                    this.FieldMetadataDbFieldName.Equals(input.FieldMetadataDbFieldName))
                ) && 
                (
                    this.FieldMetadataFriendlyFieldName == input.FieldMetadataFriendlyFieldName ||
                    (this.FieldMetadataFriendlyFieldName != null &&
                    this.FieldMetadataFriendlyFieldName.Equals(input.FieldMetadataFriendlyFieldName))
                ) && 
                (
                    this.FieldMetadataId == input.FieldMetadataId ||
                    (this.FieldMetadataId != null &&
                    this.FieldMetadataId.Equals(input.FieldMetadataId))
                ) && 
                (
                    this.FieldMetadataLabel == input.FieldMetadataLabel ||
                    (this.FieldMetadataLabel != null &&
                    this.FieldMetadataLabel.Equals(input.FieldMetadataLabel))
                ) && 
                (
                    this.FieldMetadataSortOrder == input.FieldMetadataSortOrder ||
                    (this.FieldMetadataSortOrder != null &&
                    this.FieldMetadataSortOrder.Equals(input.FieldMetadataSortOrder))
                ) && 
                (
                    this.FieldMetadataDisplayType == input.FieldMetadataDisplayType ||
                    (this.FieldMetadataDisplayType != null &&
                    this.FieldMetadataDisplayType.Equals(input.FieldMetadataDisplayType))
                ) && 
                (
                    this.FieldMetadataTextFieldMaxLength == input.FieldMetadataTextFieldMaxLength ||
                    (this.FieldMetadataTextFieldMaxLength != null &&
                    this.FieldMetadataTextFieldMaxLength.Equals(input.FieldMetadataTextFieldMaxLength))
                ) && 
                (
                    this.FieldMetadataDropdownListData == input.FieldMetadataDropdownListData ||
                    this.FieldMetadataDropdownListData != null &&
                    this.FieldMetadataDropdownListData.SequenceEqual(input.FieldMetadataDropdownListData)
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
                if (this.FieldMetadataDbFieldName != null)
                    hashCode = hashCode * 59 + this.FieldMetadataDbFieldName.GetHashCode();
                if (this.FieldMetadataFriendlyFieldName != null)
                    hashCode = hashCode * 59 + this.FieldMetadataFriendlyFieldName.GetHashCode();
                if (this.FieldMetadataId != null)
                    hashCode = hashCode * 59 + this.FieldMetadataId.GetHashCode();
                if (this.FieldMetadataLabel != null)
                    hashCode = hashCode * 59 + this.FieldMetadataLabel.GetHashCode();
                if (this.FieldMetadataSortOrder != null)
                    hashCode = hashCode * 59 + this.FieldMetadataSortOrder.GetHashCode();
                if (this.FieldMetadataDisplayType != null)
                    hashCode = hashCode * 59 + this.FieldMetadataDisplayType.GetHashCode();
                if (this.FieldMetadataTextFieldMaxLength != null)
                    hashCode = hashCode * 59 + this.FieldMetadataTextFieldMaxLength.GetHashCode();
                if (this.FieldMetadataDropdownListData != null)
                    hashCode = hashCode * 59 + this.FieldMetadataDropdownListData.GetHashCode();
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