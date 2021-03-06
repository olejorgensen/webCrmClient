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
    /// QuotationLineLinkedDataItemDto
    /// </summary>
    [DataContract]
    public partial class QuotationLineLinkedDataItemDto : BaseObject, IEquatable<QuotationLineLinkedDataItemDto>, IValidatableObject
    {
        /// <summary>
        /// Defines QuotationLineLinkedDataItemEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuotationLineLinkedDataItemEntityTypeEnum
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
        /// Gets or Sets QuotationLineLinkedDataItemEntityType
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemEntityType", EmitDefaultValue=false)]
        public QuotationLineLinkedDataItemEntityTypeEnum? QuotationLineLinkedDataItemEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotationLineLinkedDataItemDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected QuotationLineLinkedDataItemDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotationLineLinkedDataItemDto" /> class.
        /// </summary>
        /// <param name="QuotationLineLinkedDataItemCostPrice">QuotationLineLinkedDataItemCostPrice.</param>
        /// <param name="QuotationLineLinkedDataItemVatCode">QuotationLineLinkedDataItemVatCode.</param>
        /// <param name="QuotationLineLinkedDataItemData1">QuotationLineLinkedDataItemData1.</param>
        /// <param name="QuotationLineLinkedDataItemData2">QuotationLineLinkedDataItemData2.</param>
        /// <param name="QuotationLineLinkedDataItemData3">QuotationLineLinkedDataItemData3.</param>
        /// <param name="QuotationLineLinkedDataItemData4">QuotationLineLinkedDataItemData4.</param>
        /// <param name="QuotationLineLinkedDataItemData5">QuotationLineLinkedDataItemData5.</param>
        /// <param name="QuotationLineLinkedDataItemData6">QuotationLineLinkedDataItemData6.</param>
        /// <param name="QuotationLineLinkedDataItemData7">QuotationLineLinkedDataItemData7.</param>
        /// <param name="QuotationLineLinkedDataItemData8">QuotationLineLinkedDataItemData8.</param>
        /// <param name="QuotationLineLinkedDataItemData9">QuotationLineLinkedDataItemData9.</param>
        /// <param name="QuotationLineLinkedDataItemDataMemo">QuotationLineLinkedDataItemDataMemo.</param>
        /// <param name="QuotationLineLinkedDataItemEntityType">QuotationLineLinkedDataItemEntityType.</param>
        /// <param name="QuotationLineLinkedDataItemId">QuotationLineLinkedDataItemId (required).</param>
        /// <param name="QuotationLineLinkedDataItemItemGroup">QuotationLineLinkedDataItemItemGroup.</param>
        /// <param name="QuotationLineLinkedDataItemPrice">QuotationLineLinkedDataItemPrice.</param>
        public QuotationLineLinkedDataItemDto(double? QuotationLineLinkedDataItemCostPrice = default(double?), string QuotationLineLinkedDataItemVatCode = default(string), string QuotationLineLinkedDataItemData1 = default(string), string QuotationLineLinkedDataItemData2 = default(string), string QuotationLineLinkedDataItemData3 = default(string), string QuotationLineLinkedDataItemData4 = default(string), string QuotationLineLinkedDataItemData5 = default(string), string QuotationLineLinkedDataItemData6 = default(string), string QuotationLineLinkedDataItemData7 = default(string), string QuotationLineLinkedDataItemData8 = default(string), string QuotationLineLinkedDataItemData9 = default(string), string QuotationLineLinkedDataItemDataMemo = default(string), QuotationLineLinkedDataItemEntityTypeEnum? QuotationLineLinkedDataItemEntityType = default(QuotationLineLinkedDataItemEntityTypeEnum?), int? QuotationLineLinkedDataItemId = default(int?), string QuotationLineLinkedDataItemItemGroup = default(string), double? QuotationLineLinkedDataItemPrice = default(double?))
        {
            // to ensure "QuotationLineLinkedDataItemId" is required (not null)
            if (QuotationLineLinkedDataItemId == null)
            {
                throw new InvalidDataException("QuotationLineLinkedDataItemId is a required property for QuotationLineLinkedDataItemDto and cannot be null");
            }
            else
            {
                this.QuotationLineLinkedDataItemId = QuotationLineLinkedDataItemId;
            }
            this.QuotationLineLinkedDataItemCostPrice = QuotationLineLinkedDataItemCostPrice;
            this.QuotationLineLinkedDataItemVatCode = QuotationLineLinkedDataItemVatCode;
            this.QuotationLineLinkedDataItemData1 = QuotationLineLinkedDataItemData1;
            this.QuotationLineLinkedDataItemData2 = QuotationLineLinkedDataItemData2;
            this.QuotationLineLinkedDataItemData3 = QuotationLineLinkedDataItemData3;
            this.QuotationLineLinkedDataItemData4 = QuotationLineLinkedDataItemData4;
            this.QuotationLineLinkedDataItemData5 = QuotationLineLinkedDataItemData5;
            this.QuotationLineLinkedDataItemData6 = QuotationLineLinkedDataItemData6;
            this.QuotationLineLinkedDataItemData7 = QuotationLineLinkedDataItemData7;
            this.QuotationLineLinkedDataItemData8 = QuotationLineLinkedDataItemData8;
            this.QuotationLineLinkedDataItemData9 = QuotationLineLinkedDataItemData9;
            this.QuotationLineLinkedDataItemDataMemo = QuotationLineLinkedDataItemDataMemo;
            this.QuotationLineLinkedDataItemEntityType = QuotationLineLinkedDataItemEntityType;
            this.QuotationLineLinkedDataItemItemGroup = QuotationLineLinkedDataItemItemGroup;
            this.QuotationLineLinkedDataItemPrice = QuotationLineLinkedDataItemPrice;
        }
        
        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemCostPrice
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemCostPrice", EmitDefaultValue=false)]
        public double? QuotationLineLinkedDataItemCostPrice { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemVatCode
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemVatCode", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemVatCode { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData1
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData1", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData1 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData2
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData2", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData2 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData3
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData3", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData3 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData4
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData4", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData4 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData5
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData5", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData5 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData6
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData6", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData6 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData7
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData7", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData7 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData8
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData8", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData8 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemData9
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemData9", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemData9 { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemDataMemo
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemDataMemo", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemDataMemo { get; set; }


        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemId
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemId", EmitDefaultValue=false)]
        public int? QuotationLineLinkedDataItemId { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemItemGroup
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemItemGroup", EmitDefaultValue=false)]
        public string QuotationLineLinkedDataItemItemGroup { get; set; }

        /// <summary>
        /// Gets or Sets QuotationLineLinkedDataItemPrice
        /// </summary>
        [DataMember(Name="QuotationLineLinkedDataItemPrice", EmitDefaultValue=false)]
        public double? QuotationLineLinkedDataItemPrice { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotationLineLinkedDataItemDto);
        }

        /// <summary>
        /// Returns true if QuotationLineLinkedDataItemDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotationLineLinkedDataItemDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotationLineLinkedDataItemDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuotationLineLinkedDataItemCostPrice == input.QuotationLineLinkedDataItemCostPrice ||
                    (this.QuotationLineLinkedDataItemCostPrice != null &&
                    this.QuotationLineLinkedDataItemCostPrice.Equals(input.QuotationLineLinkedDataItemCostPrice))
                ) && 
                (
                    this.QuotationLineLinkedDataItemVatCode == input.QuotationLineLinkedDataItemVatCode ||
                    (this.QuotationLineLinkedDataItemVatCode != null &&
                    this.QuotationLineLinkedDataItemVatCode.Equals(input.QuotationLineLinkedDataItemVatCode))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData1 == input.QuotationLineLinkedDataItemData1 ||
                    (this.QuotationLineLinkedDataItemData1 != null &&
                    this.QuotationLineLinkedDataItemData1.Equals(input.QuotationLineLinkedDataItemData1))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData2 == input.QuotationLineLinkedDataItemData2 ||
                    (this.QuotationLineLinkedDataItemData2 != null &&
                    this.QuotationLineLinkedDataItemData2.Equals(input.QuotationLineLinkedDataItemData2))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData3 == input.QuotationLineLinkedDataItemData3 ||
                    (this.QuotationLineLinkedDataItemData3 != null &&
                    this.QuotationLineLinkedDataItemData3.Equals(input.QuotationLineLinkedDataItemData3))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData4 == input.QuotationLineLinkedDataItemData4 ||
                    (this.QuotationLineLinkedDataItemData4 != null &&
                    this.QuotationLineLinkedDataItemData4.Equals(input.QuotationLineLinkedDataItemData4))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData5 == input.QuotationLineLinkedDataItemData5 ||
                    (this.QuotationLineLinkedDataItemData5 != null &&
                    this.QuotationLineLinkedDataItemData5.Equals(input.QuotationLineLinkedDataItemData5))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData6 == input.QuotationLineLinkedDataItemData6 ||
                    (this.QuotationLineLinkedDataItemData6 != null &&
                    this.QuotationLineLinkedDataItemData6.Equals(input.QuotationLineLinkedDataItemData6))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData7 == input.QuotationLineLinkedDataItemData7 ||
                    (this.QuotationLineLinkedDataItemData7 != null &&
                    this.QuotationLineLinkedDataItemData7.Equals(input.QuotationLineLinkedDataItemData7))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData8 == input.QuotationLineLinkedDataItemData8 ||
                    (this.QuotationLineLinkedDataItemData8 != null &&
                    this.QuotationLineLinkedDataItemData8.Equals(input.QuotationLineLinkedDataItemData8))
                ) && 
                (
                    this.QuotationLineLinkedDataItemData9 == input.QuotationLineLinkedDataItemData9 ||
                    (this.QuotationLineLinkedDataItemData9 != null &&
                    this.QuotationLineLinkedDataItemData9.Equals(input.QuotationLineLinkedDataItemData9))
                ) && 
                (
                    this.QuotationLineLinkedDataItemDataMemo == input.QuotationLineLinkedDataItemDataMemo ||
                    (this.QuotationLineLinkedDataItemDataMemo != null &&
                    this.QuotationLineLinkedDataItemDataMemo.Equals(input.QuotationLineLinkedDataItemDataMemo))
                ) && 
                (
                    this.QuotationLineLinkedDataItemEntityType == input.QuotationLineLinkedDataItemEntityType ||
                    (this.QuotationLineLinkedDataItemEntityType != null &&
                    this.QuotationLineLinkedDataItemEntityType.Equals(input.QuotationLineLinkedDataItemEntityType))
                ) && 
                (
                    this.QuotationLineLinkedDataItemId == input.QuotationLineLinkedDataItemId ||
                    (this.QuotationLineLinkedDataItemId != null &&
                    this.QuotationLineLinkedDataItemId.Equals(input.QuotationLineLinkedDataItemId))
                ) && 
                (
                    this.QuotationLineLinkedDataItemItemGroup == input.QuotationLineLinkedDataItemItemGroup ||
                    (this.QuotationLineLinkedDataItemItemGroup != null &&
                    this.QuotationLineLinkedDataItemItemGroup.Equals(input.QuotationLineLinkedDataItemItemGroup))
                ) && 
                (
                    this.QuotationLineLinkedDataItemPrice == input.QuotationLineLinkedDataItemPrice ||
                    (this.QuotationLineLinkedDataItemPrice != null &&
                    this.QuotationLineLinkedDataItemPrice.Equals(input.QuotationLineLinkedDataItemPrice))
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
                if (this.QuotationLineLinkedDataItemCostPrice != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemCostPrice.GetHashCode();
                if (this.QuotationLineLinkedDataItemVatCode != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemVatCode.GetHashCode();
                if (this.QuotationLineLinkedDataItemData1 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData1.GetHashCode();
                if (this.QuotationLineLinkedDataItemData2 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData2.GetHashCode();
                if (this.QuotationLineLinkedDataItemData3 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData3.GetHashCode();
                if (this.QuotationLineLinkedDataItemData4 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData4.GetHashCode();
                if (this.QuotationLineLinkedDataItemData5 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData5.GetHashCode();
                if (this.QuotationLineLinkedDataItemData6 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData6.GetHashCode();
                if (this.QuotationLineLinkedDataItemData7 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData7.GetHashCode();
                if (this.QuotationLineLinkedDataItemData8 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData8.GetHashCode();
                if (this.QuotationLineLinkedDataItemData9 != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemData9.GetHashCode();
                if (this.QuotationLineLinkedDataItemDataMemo != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemDataMemo.GetHashCode();
                if (this.QuotationLineLinkedDataItemEntityType != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemEntityType.GetHashCode();
                if (this.QuotationLineLinkedDataItemId != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemId.GetHashCode();
                if (this.QuotationLineLinkedDataItemItemGroup != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemItemGroup.GetHashCode();
                if (this.QuotationLineLinkedDataItemPrice != null)
                    hashCode = hashCode * 59 + this.QuotationLineLinkedDataItemPrice.GetHashCode();
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
