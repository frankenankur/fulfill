/*
 * Costco Fulfillment API
 *
 * An API for fullfilling orders placed on non-Costco channels by Costco 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse2005PartnerOrderLineItems : IEquatable<InlineResponse2005PartnerOrderLineItems>
    { 
        /// <summary>
        /// The unique id of the line item that is shipped
        /// </summary>
        /// <value>The unique id of the line item that is shipped</value>
        [Required]
        [DataMember(Name="referenceNumber")]
        public decimal? ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets LineProcessingStatus
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LineProcessingStatusEnum
        {
            
            /// <summary>
            /// Enum InvalidBarCodeScannedEnum for invalidBarCodeScanned
            /// </summary>
            [EnumMember(Value = "invalidBarCodeScanned")]
            InvalidBarCodeScannedEnum = 1,
            
            /// <summary>
            /// Enum InvalidActionRequestedEnum for invalidActionRequested
            /// </summary>
            [EnumMember(Value = "invalidActionRequested")]
            InvalidActionRequestedEnum = 2,
            
            /// <summary>
            /// Enum InvalidItemEnum for invalidItem
            /// </summary>
            [EnumMember(Value = "invalidItem")]
            InvalidItemEnum = 3,
            
            /// <summary>
            /// Enum InvalidLineEnum for invalidLine
            /// </summary>
            [EnumMember(Value = "invalidLine")]
            InvalidLineEnum = 4,
            
            /// <summary>
            /// Enum InvalidPickEnum for invalidPick
            /// </summary>
            [EnumMember(Value = "invalidPick")]
            InvalidPickEnum = 5,
            
            /// <summary>
            /// Enum LineCancelledEnum for lineCancelled
            /// </summary>
            [EnumMember(Value = "lineCancelled")]
            LineCancelledEnum = 6,
            
            /// <summary>
            /// Enum LineUpdatedEnum for lineUpdated
            /// </summary>
            [EnumMember(Value = "lineUpdated")]
            LineUpdatedEnum = 7,
            
            /// <summary>
            /// Enum LineOKButUnprocessedEnum for lineOKButUnprocessed
            /// </summary>
            [EnumMember(Value = "lineOKButUnprocessed")]
            LineOKButUnprocessedEnum = 8,
            
            /// <summary>
            /// Enum LineNotProcessedEnum for lineNotProcessed
            /// </summary>
            [EnumMember(Value = "lineNotProcessed")]
            LineNotProcessedEnum = 9
        }

        /// <summary>
        /// Gets or Sets LineProcessingStatus
        /// </summary>
        [Required]
        [DataMember(Name="lineProcessingStatus")]
        public LineProcessingStatusEnum? LineProcessingStatus { get; set; }

        /// <summary>
        /// The Costco item number to be fulfilled
        /// </summary>
        /// <value>The Costco item number to be fulfilled</value>
        [Required]
        [DataMember(Name="itemNumber")]
        public string ItemNumber { get; set; }

        /// <summary>
        /// The quantity of units to be fulfilled
        /// </summary>
        /// <value>The quantity of units to be fulfilled</value>
        [Required]
        [DataMember(Name="quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// The sales price of unit, represented as a number
        /// </summary>
        /// <value>The sales price of unit, represented as a number</value>
        [Required]
        [DataMember(Name="unitSellPrice")]
        public decimal? UnitSellPrice { get; set; }

        /// <summary>
        /// The portion of a unit sell price dedicated to program markup
        /// </summary>
        /// <value>The portion of a unit sell price dedicated to program markup</value>
        [DataMember(Name="unitPriceMarkupAmount")]
        public decimal? UnitPriceMarkupAmount { get; set; }

        /// <summary>
        /// The cost of tax for a unit, represented as a number. (Base Tax Rate + Fees)
        /// </summary>
        /// <value>The cost of tax for a unit, represented as a number. (Base Tax Rate + Fees)</value>
        [Required]
        [DataMember(Name="unitItemTaxPrice")]
        public decimal? UnitItemTaxPrice { get; set; }

        /// <summary>
        /// The cost of shipping for a unit, represented as a number
        /// </summary>
        /// <value>The cost of shipping for a unit, represented as a number</value>
        [DataMember(Name="unitShippingPrice")]
        public decimal? UnitShippingPrice { get; set; }

        /// <summary>
        /// The cost of tax on shipping of a unit, represented as a number
        /// </summary>
        /// <value>The cost of tax on shipping of a unit, represented as a number</value>
        [DataMember(Name="unitShippingTaxPrice")]
        public decimal? UnitShippingTaxPrice { get; set; }

        /// <summary>
        /// A collection of fees associated with a line
        /// </summary>
        /// <value>A collection of fees associated with a line</value>
        [DataMember(Name="fees")]
        public List<LinkedFee> Fees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005PartnerOrderLineItems {\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  LineProcessingStatus: ").Append(LineProcessingStatus).Append("\n");
            sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitSellPrice: ").Append(UnitSellPrice).Append("\n");
            sb.Append("  UnitPriceMarkupAmount: ").Append(UnitPriceMarkupAmount).Append("\n");
            sb.Append("  UnitItemTaxPrice: ").Append(UnitItemTaxPrice).Append("\n");
            sb.Append("  UnitShippingPrice: ").Append(UnitShippingPrice).Append("\n");
            sb.Append("  UnitShippingTaxPrice: ").Append(UnitShippingTaxPrice).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse2005PartnerOrderLineItems)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2005PartnerOrderLineItems instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2005PartnerOrderLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005PartnerOrderLineItems other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ReferenceNumber == other.ReferenceNumber ||
                    ReferenceNumber != null &&
                    ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    LineProcessingStatus == other.LineProcessingStatus ||
                    LineProcessingStatus != null &&
                    LineProcessingStatus.Equals(other.LineProcessingStatus)
                ) && 
                (
                    ItemNumber == other.ItemNumber ||
                    ItemNumber != null &&
                    ItemNumber.Equals(other.ItemNumber)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    UnitSellPrice == other.UnitSellPrice ||
                    UnitSellPrice != null &&
                    UnitSellPrice.Equals(other.UnitSellPrice)
                ) && 
                (
                    UnitPriceMarkupAmount == other.UnitPriceMarkupAmount ||
                    UnitPriceMarkupAmount != null &&
                    UnitPriceMarkupAmount.Equals(other.UnitPriceMarkupAmount)
                ) && 
                (
                    UnitItemTaxPrice == other.UnitItemTaxPrice ||
                    UnitItemTaxPrice != null &&
                    UnitItemTaxPrice.Equals(other.UnitItemTaxPrice)
                ) && 
                (
                    UnitShippingPrice == other.UnitShippingPrice ||
                    UnitShippingPrice != null &&
                    UnitShippingPrice.Equals(other.UnitShippingPrice)
                ) && 
                (
                    UnitShippingTaxPrice == other.UnitShippingTaxPrice ||
                    UnitShippingTaxPrice != null &&
                    UnitShippingTaxPrice.Equals(other.UnitShippingTaxPrice)
                ) && 
                (
                    Fees == other.Fees ||
                    Fees != null &&
                    Fees.SequenceEqual(other.Fees)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ReferenceNumber != null)
                    hashCode = hashCode * 59 + ReferenceNumber.GetHashCode();
                    if (LineProcessingStatus != null)
                    hashCode = hashCode * 59 + LineProcessingStatus.GetHashCode();
                    if (ItemNumber != null)
                    hashCode = hashCode * 59 + ItemNumber.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (UnitSellPrice != null)
                    hashCode = hashCode * 59 + UnitSellPrice.GetHashCode();
                    if (UnitPriceMarkupAmount != null)
                    hashCode = hashCode * 59 + UnitPriceMarkupAmount.GetHashCode();
                    if (UnitItemTaxPrice != null)
                    hashCode = hashCode * 59 + UnitItemTaxPrice.GetHashCode();
                    if (UnitShippingPrice != null)
                    hashCode = hashCode * 59 + UnitShippingPrice.GetHashCode();
                    if (UnitShippingTaxPrice != null)
                    hashCode = hashCode * 59 + UnitShippingTaxPrice.GetHashCode();
                    if (Fees != null)
                    hashCode = hashCode * 59 + Fees.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2005PartnerOrderLineItems left, InlineResponse2005PartnerOrderLineItems right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2005PartnerOrderLineItems left, InlineResponse2005PartnerOrderLineItems right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
