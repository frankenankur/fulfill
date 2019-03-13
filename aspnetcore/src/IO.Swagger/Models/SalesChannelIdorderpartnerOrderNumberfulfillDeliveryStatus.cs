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
    public partial class SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus : IEquatable<SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus>
    { 
        /// <summary>
        /// The quantity that was fulfilled
        /// </summary>
        /// <value>The quantity that was fulfilled</value>
        [Required]
        [DataMember(Name="quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum InTransitEnum for inTransit
            /// </summary>
            [EnumMember(Value = "inTransit")]
            InTransitEnum = 1,
            
            /// <summary>
            /// Enum DeliveredEnum for delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            DeliveredEnum = 2,
            
            /// <summary>
            /// Enum RefusedDeliveryEnum for refusedDelivery
            /// </summary>
            [EnumMember(Value = "refusedDelivery")]
            RefusedDeliveryEnum = 3,
            
            /// <summary>
            /// Enum DamagedOrLostEnum for damagedOrLost
            /// </summary>
            [EnumMember(Value = "damagedOrLost")]
            DamagedOrLostEnum = 4
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus)obj);
        }

        /// <summary>
        /// Returns true if SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
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
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus left, SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus left, SalesChannelIdorderpartnerOrderNumberfulfillDeliveryStatus right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
