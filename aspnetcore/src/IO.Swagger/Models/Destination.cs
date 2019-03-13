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
    /// A representation of a delivery destination
    /// </summary>
    [DataContract]
    public partial class Destination : IEquatable<Destination>
    { 
        /// <summary>
        /// A unique entry ID
        /// </summary>
        /// <value>A unique entry ID</value>
        [DataMember(Name="referenceNumber")]
        public decimal? ReferenceNumber { get; set; }

        /// <summary>
        /// City, town or commune. May also include dependent localities or sublocalities (e.g. neighborhoods or suburbs).
        /// </summary>
        /// <value>City, town or commune. May also include dependent localities or sublocalities (e.g. neighborhoods or suburbs).</value>
        [Required]
        [DataMember(Name="city")]
        public string City { get; set; }

        /// <summary>
        /// Top-level administrative subdivision of the country (e.g. \&quot;CA\&quot;)
        /// </summary>
        /// <value>Top-level administrative subdivision of the country (e.g. \&quot;CA\&quot;)</value>
        [Required]
        [DataMember(Name="state")]
        public string State { get; set; }

        /// <summary>
        /// The CLDR territory code of the country to which an item will ship
        /// </summary>
        /// <value>The CLDR territory code of the country to which an item will ship</value>
        [DataMember(Name="countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Postal Code or ZIP (e.g. \&quot;94043\&quot;).
        /// </summary>
        /// <value>Postal Code or ZIP (e.g. \&quot;94043\&quot;).</value>
        [Required]
        [DataMember(Name="postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Destination {\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Destination)obj);
        }

        /// <summary>
        /// Returns true if Destination instances are equal
        /// </summary>
        /// <param name="other">Instance of Destination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destination other)
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
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    CountryCode == other.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    PostalCode == other.PostalCode ||
                    PostalCode != null &&
                    PostalCode.Equals(other.PostalCode)
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
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                    if (PostalCode != null)
                    hashCode = hashCode * 59 + PostalCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Destination left, Destination right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Destination left, Destination right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
