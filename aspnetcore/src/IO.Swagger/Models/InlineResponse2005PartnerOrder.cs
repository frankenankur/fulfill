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
    public partial class InlineResponse2005PartnerOrder : IEquatable<InlineResponse2005PartnerOrder>
    { 
        /// <summary>
        /// Costco Order Status after results of request
        /// </summary>
        /// <value>Costco Order Status after results of request</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OrderStatusEnum
        {
            
            /// <summary>
            /// Enum NewEnum for new
            /// </summary>
            [EnumMember(Value = "new")]
            NewEnum = 1,
            
            /// <summary>
            /// Enum InprocessEnum for inprocess
            /// </summary>
            [EnumMember(Value = "inprocess")]
            InprocessEnum = 2,
            
            /// <summary>
            /// Enum CompleteEnum for complete
            /// </summary>
            [EnumMember(Value = "complete")]
            CompleteEnum = 3,
            
            /// <summary>
            /// Enum CancelledEnum for cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            CancelledEnum = 4
        }

        /// <summary>
        /// Costco Order Status after results of request
        /// </summary>
        /// <value>Costco Order Status after results of request</value>
        [Required]
        [DataMember(Name="orderStatus")]
        public OrderStatusEnum? OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets OrderSummary
        /// </summary>
        [Required]
        [DataMember(Name="orderSummary")]
        public InlineResponse2005PartnerOrderOrderSummary OrderSummary { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems")]
        public List<InlineResponse2005PartnerOrderLineItems> LineItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005PartnerOrder {\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderSummary: ").Append(OrderSummary).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse2005PartnerOrder)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2005PartnerOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2005PartnerOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005PartnerOrder other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OrderStatus == other.OrderStatus ||
                    OrderStatus != null &&
                    OrderStatus.Equals(other.OrderStatus)
                ) && 
                (
                    OrderSummary == other.OrderSummary ||
                    OrderSummary != null &&
                    OrderSummary.Equals(other.OrderSummary)
                ) && 
                (
                    LineItems == other.LineItems ||
                    LineItems != null &&
                    LineItems.SequenceEqual(other.LineItems)
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
                    if (OrderStatus != null)
                    hashCode = hashCode * 59 + OrderStatus.GetHashCode();
                    if (OrderSummary != null)
                    hashCode = hashCode * 59 + OrderSummary.GetHashCode();
                    if (LineItems != null)
                    hashCode = hashCode * 59 + LineItems.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2005PartnerOrder left, InlineResponse2005PartnerOrder right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2005PartnerOrder left, InlineResponse2005PartnerOrder right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
