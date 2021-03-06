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
    /// LinkedSetupDto
    /// </summary>
    [DataContract]
    public partial class LinkedSetupDto : BaseObject, IEquatable<LinkedSetupDto>, IValidatableObject
    {
        /// <summary>
        /// Defines LinkedSetupEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinkedSetupEntityTypeEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum Organisation for value: Organisation
            /// </summary>
            [EnumMember(Value = "Organisation")]
            Organisation = 2,
            
            /// <summary>
            /// Enum Person for value: Person
            /// </summary>
            [EnumMember(Value = "Person")]
            Person = 3,
            
            /// <summary>
            /// Enum Activity for value: Activity
            /// </summary>
            [EnumMember(Value = "Activity")]
            Activity = 4,
            
            /// <summary>
            /// Enum Meeting for value: Meeting
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting = 5,
            
            /// <summary>
            /// Enum Opportunity for value: Opportunity
            /// </summary>
            [EnumMember(Value = "Opportunity")]
            Opportunity = 6,
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 7,
            
            /// <summary>
            /// Enum Product for value: Product
            /// </summary>
            [EnumMember(Value = "Product")]
            Product = 8,
            
            /// <summary>
            /// Enum SupportCase for value: SupportCase
            /// </summary>
            [EnumMember(Value = "SupportCase")]
            SupportCase = 9,
            
            /// <summary>
            /// Enum SupportFaq for value: SupportFaq
            /// </summary>
            [EnumMember(Value = "SupportFaq")]
            SupportFaq = 10
        }

        /// <summary>
        /// Gets or Sets LinkedSetupEntityType
        /// </summary>
        [DataMember(Name="LinkedSetupEntityType", EmitDefaultValue=false)]
        public LinkedSetupEntityTypeEnum? LinkedSetupEntityType { get; set; }
        /// <summary>
        /// Defines LinkedSetupLinkMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinkedSetupLinkModeEnum
        {
            
            /// <summary>
            /// Enum Regular for value: Regular
            /// </summary>
            [EnumMember(Value = "Regular")]
            Regular = 1,
            
            /// <summary>
            /// Enum Multiselect for value: Multiselect
            /// </summary>
            [EnumMember(Value = "Multiselect")]
            Multiselect = 2
        }

        /// <summary>
        /// Gets or Sets LinkedSetupLinkMode
        /// </summary>
        [DataMember(Name="LinkedSetupLinkMode", EmitDefaultValue=false)]
        public LinkedSetupLinkModeEnum? LinkedSetupLinkMode { get; set; }
        /// <summary>
        /// Defines LinkedSetupLookupMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinkedSetupLookupModeEnum
        {
            
            /// <summary>
            /// Enum DropdownLists for value: DropdownLists
            /// </summary>
            [EnumMember(Value = "DropdownLists")]
            DropdownLists = 1,
            
            /// <summary>
            /// Enum FreeTextSearch for value: FreeTextSearch
            /// </summary>
            [EnumMember(Value = "FreeTextSearch")]
            FreeTextSearch = 2
        }

        /// <summary>
        /// Gets or Sets LinkedSetupLookupMode
        /// </summary>
        [DataMember(Name="LinkedSetupLookupMode", EmitDefaultValue=false)]
        public LinkedSetupLookupModeEnum? LinkedSetupLookupMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedSetupDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected LinkedSetupDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedSetupDto" /> class.
        /// </summary>
        /// <param name="LinkedSetupEntityType">LinkedSetupEntityType.</param>
        /// <param name="LinkedSetupField1">LinkedSetupField1.</param>
        /// <param name="LinkedSetupField2">LinkedSetupField2.</param>
        /// <param name="LinkedSetupField3">LinkedSetupField3.</param>
        /// <param name="LinkedSetupField4">LinkedSetupField4.</param>
        /// <param name="LinkedSetupField5">LinkedSetupField5.</param>
        /// <param name="LinkedSetupField6">LinkedSetupField6.</param>
        /// <param name="LinkedSetupField7">LinkedSetupField7.</param>
        /// <param name="LinkedSetupField8">LinkedSetupField8.</param>
        /// <param name="LinkedSetupField9">LinkedSetupField9.</param>
        /// <param name="LinkedSetupId">LinkedSetupId (required).</param>
        /// <param name="LinkedSetupIsUniqueValueRequired">LinkedSetupIsUniqueValueRequired.</param>
        /// <param name="LinkedSetupLinkMode">LinkedSetupLinkMode.</param>
        /// <param name="LinkedSetupLookupMode">LinkedSetupLookupMode.</param>
        /// <param name="LinkedSetupMemoField">LinkedSetupMemoField.</param>
        /// <param name="LinkedSetupUseItemGroup">LinkedSetupUseItemGroup.</param>
        public LinkedSetupDto(LinkedSetupEntityTypeEnum? LinkedSetupEntityType = default(LinkedSetupEntityTypeEnum?), int? LinkedSetupField1 = default(int?), int? LinkedSetupField2 = default(int?), int? LinkedSetupField3 = default(int?), int? LinkedSetupField4 = default(int?), int? LinkedSetupField5 = default(int?), int? LinkedSetupField6 = default(int?), int? LinkedSetupField7 = default(int?), int? LinkedSetupField8 = default(int?), int? LinkedSetupField9 = default(int?), int? LinkedSetupId = default(int?), bool? LinkedSetupIsUniqueValueRequired = default(bool?), LinkedSetupLinkModeEnum? LinkedSetupLinkMode = default(LinkedSetupLinkModeEnum?), LinkedSetupLookupModeEnum? LinkedSetupLookupMode = default(LinkedSetupLookupModeEnum?), int? LinkedSetupMemoField = default(int?), bool? LinkedSetupUseItemGroup = default(bool?))
        {
            // to ensure "LinkedSetupId" is required (not null)
            if (LinkedSetupId == null)
            {
                throw new InvalidDataException("LinkedSetupId is a required property for LinkedSetupDto and cannot be null");
            }
            else
            {
                this.LinkedSetupId = LinkedSetupId;
            }
            this.LinkedSetupEntityType = LinkedSetupEntityType;
            this.LinkedSetupField1 = LinkedSetupField1;
            this.LinkedSetupField2 = LinkedSetupField2;
            this.LinkedSetupField3 = LinkedSetupField3;
            this.LinkedSetupField4 = LinkedSetupField4;
            this.LinkedSetupField5 = LinkedSetupField5;
            this.LinkedSetupField6 = LinkedSetupField6;
            this.LinkedSetupField7 = LinkedSetupField7;
            this.LinkedSetupField8 = LinkedSetupField8;
            this.LinkedSetupField9 = LinkedSetupField9;
            this.LinkedSetupIsUniqueValueRequired = LinkedSetupIsUniqueValueRequired;
            this.LinkedSetupLinkMode = LinkedSetupLinkMode;
            this.LinkedSetupLookupMode = LinkedSetupLookupMode;
            this.LinkedSetupMemoField = LinkedSetupMemoField;
            this.LinkedSetupUseItemGroup = LinkedSetupUseItemGroup;
        }
        

        /// <summary>
        /// Gets or Sets LinkedSetupField1
        /// </summary>
        [DataMember(Name="LinkedSetupField1", EmitDefaultValue=false)]
        public int? LinkedSetupField1 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField2
        /// </summary>
        [DataMember(Name="LinkedSetupField2", EmitDefaultValue=false)]
        public int? LinkedSetupField2 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField3
        /// </summary>
        [DataMember(Name="LinkedSetupField3", EmitDefaultValue=false)]
        public int? LinkedSetupField3 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField4
        /// </summary>
        [DataMember(Name="LinkedSetupField4", EmitDefaultValue=false)]
        public int? LinkedSetupField4 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField5
        /// </summary>
        [DataMember(Name="LinkedSetupField5", EmitDefaultValue=false)]
        public int? LinkedSetupField5 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField6
        /// </summary>
        [DataMember(Name="LinkedSetupField6", EmitDefaultValue=false)]
        public int? LinkedSetupField6 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField7
        /// </summary>
        [DataMember(Name="LinkedSetupField7", EmitDefaultValue=false)]
        public int? LinkedSetupField7 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField8
        /// </summary>
        [DataMember(Name="LinkedSetupField8", EmitDefaultValue=false)]
        public int? LinkedSetupField8 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupField9
        /// </summary>
        [DataMember(Name="LinkedSetupField9", EmitDefaultValue=false)]
        public int? LinkedSetupField9 { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupId
        /// </summary>
        [DataMember(Name="LinkedSetupId", EmitDefaultValue=false)]
        public int? LinkedSetupId { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupIsUniqueValueRequired
        /// </summary>
        [DataMember(Name="LinkedSetupIsUniqueValueRequired", EmitDefaultValue=false)]
        public bool? LinkedSetupIsUniqueValueRequired { get; set; }



        /// <summary>
        /// Gets or Sets LinkedSetupMemoField
        /// </summary>
        [DataMember(Name="LinkedSetupMemoField", EmitDefaultValue=false)]
        public int? LinkedSetupMemoField { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSetupUseItemGroup
        /// </summary>
        [DataMember(Name="LinkedSetupUseItemGroup", EmitDefaultValue=false)]
        public bool? LinkedSetupUseItemGroup { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LinkedSetupDto);
        }

        /// <summary>
        /// Returns true if LinkedSetupDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedSetupDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedSetupDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinkedSetupEntityType == input.LinkedSetupEntityType ||
                    (this.LinkedSetupEntityType != null &&
                    this.LinkedSetupEntityType.Equals(input.LinkedSetupEntityType))
                ) && 
                (
                    this.LinkedSetupField1 == input.LinkedSetupField1 ||
                    (this.LinkedSetupField1 != null &&
                    this.LinkedSetupField1.Equals(input.LinkedSetupField1))
                ) && 
                (
                    this.LinkedSetupField2 == input.LinkedSetupField2 ||
                    (this.LinkedSetupField2 != null &&
                    this.LinkedSetupField2.Equals(input.LinkedSetupField2))
                ) && 
                (
                    this.LinkedSetupField3 == input.LinkedSetupField3 ||
                    (this.LinkedSetupField3 != null &&
                    this.LinkedSetupField3.Equals(input.LinkedSetupField3))
                ) && 
                (
                    this.LinkedSetupField4 == input.LinkedSetupField4 ||
                    (this.LinkedSetupField4 != null &&
                    this.LinkedSetupField4.Equals(input.LinkedSetupField4))
                ) && 
                (
                    this.LinkedSetupField5 == input.LinkedSetupField5 ||
                    (this.LinkedSetupField5 != null &&
                    this.LinkedSetupField5.Equals(input.LinkedSetupField5))
                ) && 
                (
                    this.LinkedSetupField6 == input.LinkedSetupField6 ||
                    (this.LinkedSetupField6 != null &&
                    this.LinkedSetupField6.Equals(input.LinkedSetupField6))
                ) && 
                (
                    this.LinkedSetupField7 == input.LinkedSetupField7 ||
                    (this.LinkedSetupField7 != null &&
                    this.LinkedSetupField7.Equals(input.LinkedSetupField7))
                ) && 
                (
                    this.LinkedSetupField8 == input.LinkedSetupField8 ||
                    (this.LinkedSetupField8 != null &&
                    this.LinkedSetupField8.Equals(input.LinkedSetupField8))
                ) && 
                (
                    this.LinkedSetupField9 == input.LinkedSetupField9 ||
                    (this.LinkedSetupField9 != null &&
                    this.LinkedSetupField9.Equals(input.LinkedSetupField9))
                ) && 
                (
                    this.LinkedSetupId == input.LinkedSetupId ||
                    (this.LinkedSetupId != null &&
                    this.LinkedSetupId.Equals(input.LinkedSetupId))
                ) && 
                (
                    this.LinkedSetupIsUniqueValueRequired == input.LinkedSetupIsUniqueValueRequired ||
                    (this.LinkedSetupIsUniqueValueRequired != null &&
                    this.LinkedSetupIsUniqueValueRequired.Equals(input.LinkedSetupIsUniqueValueRequired))
                ) && 
                (
                    this.LinkedSetupLinkMode == input.LinkedSetupLinkMode ||
                    (this.LinkedSetupLinkMode != null &&
                    this.LinkedSetupLinkMode.Equals(input.LinkedSetupLinkMode))
                ) && 
                (
                    this.LinkedSetupLookupMode == input.LinkedSetupLookupMode ||
                    (this.LinkedSetupLookupMode != null &&
                    this.LinkedSetupLookupMode.Equals(input.LinkedSetupLookupMode))
                ) && 
                (
                    this.LinkedSetupMemoField == input.LinkedSetupMemoField ||
                    (this.LinkedSetupMemoField != null &&
                    this.LinkedSetupMemoField.Equals(input.LinkedSetupMemoField))
                ) && 
                (
                    this.LinkedSetupUseItemGroup == input.LinkedSetupUseItemGroup ||
                    (this.LinkedSetupUseItemGroup != null &&
                    this.LinkedSetupUseItemGroup.Equals(input.LinkedSetupUseItemGroup))
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
                if (this.LinkedSetupEntityType != null)
                    hashCode = hashCode * 59 + this.LinkedSetupEntityType.GetHashCode();
                if (this.LinkedSetupField1 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField1.GetHashCode();
                if (this.LinkedSetupField2 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField2.GetHashCode();
                if (this.LinkedSetupField3 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField3.GetHashCode();
                if (this.LinkedSetupField4 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField4.GetHashCode();
                if (this.LinkedSetupField5 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField5.GetHashCode();
                if (this.LinkedSetupField6 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField6.GetHashCode();
                if (this.LinkedSetupField7 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField7.GetHashCode();
                if (this.LinkedSetupField8 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField8.GetHashCode();
                if (this.LinkedSetupField9 != null)
                    hashCode = hashCode * 59 + this.LinkedSetupField9.GetHashCode();
                if (this.LinkedSetupId != null)
                    hashCode = hashCode * 59 + this.LinkedSetupId.GetHashCode();
                if (this.LinkedSetupIsUniqueValueRequired != null)
                    hashCode = hashCode * 59 + this.LinkedSetupIsUniqueValueRequired.GetHashCode();
                if (this.LinkedSetupLinkMode != null)
                    hashCode = hashCode * 59 + this.LinkedSetupLinkMode.GetHashCode();
                if (this.LinkedSetupLookupMode != null)
                    hashCode = hashCode * 59 + this.LinkedSetupLookupMode.GetHashCode();
                if (this.LinkedSetupMemoField != null)
                    hashCode = hashCode * 59 + this.LinkedSetupMemoField.GetHashCode();
                if (this.LinkedSetupUseItemGroup != null)
                    hashCode = hashCode * 59 + this.LinkedSetupUseItemGroup.GetHashCode();
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
