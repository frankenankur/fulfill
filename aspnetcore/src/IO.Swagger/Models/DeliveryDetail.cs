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
    /// A request for shipment to a shipment location
    /// </summary>
    [DataContract]
    public partial class DeliveryDetail : IEquatable<DeliveryDetail>
    { 
        /// <summary>
        /// A reference to a shipping address in a shippingAddress array
        /// </summary>
        /// <value>A reference to a shipping address in a shippingAddress array</value>
        [Required]
        [DataMember(Name="shippingAddressReference")]
        public decimal? ShippingAddressReference { get; set; }

        /// <summary>
        /// The name of the shipping method.
        /// </summary>
        /// <value>The name of the shipping method.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MethodNameEnum
        {
            
            /// <summary>
            /// Enum GroundEnum for ground
            /// </summary>
            [EnumMember(Value = "ground")]
            GroundEnum = 1,
            
            /// <summary>
            /// Enum ExpressEnum for express
            /// </summary>
            [EnumMember(Value = "express")]
            ExpressEnum = 2
        }

        /// <summary>
        /// The name of the shipping method.
        /// </summary>
        /// <value>The name of the shipping method.</value>
        [Required]
        [DataMember(Name="methodName")]
        public MethodNameEnum? MethodName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryDetail {\n");
            sb.Append("  ShippingAddressReference: ").Append(ShippingAddressReference).Append("\n");
            sb.Append("  MethodName: ").Append(MethodName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DeliveryDetail)obj);
        }

        /// <summary>
        /// Returns true if DeliveryDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of DeliveryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ShippingAddressReference == other.ShippingAddressReference ||
                    ShippingAddressReference != null &&
                    ShippingAddressReference.Equals(other.ShippingAddressReference)
                ) && 
                (
                    MethodName == other.MethodName ||
                    MethodName != null &&
                    MethodName.Equals(other.MethodName)
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
                    if (ShippingAddressReference != null)
                    hashCode = hashCode * 59 + ShippingAddressReference.GetHashCode();
                    if (MethodName != null)
                    hashCode = hashCode * 59 + MethodName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DeliveryDetail left, DeliveryDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeliveryDetail left, DeliveryDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
