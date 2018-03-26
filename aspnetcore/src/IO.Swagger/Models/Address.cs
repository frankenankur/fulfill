/*
 * Costco Fullfillment API
 *
 * An API for fullfilling orders placed on non-Costco channels by Costco 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
    /// A representation of an address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>
    { 
        /// <summary>
        /// A unique entry ID
        /// </summary>
        /// <value>A unique entry ID</value>
        [Required]
        [DataMember(Name="referenceNumber")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// First name of the recipient.
        /// </summary>
        /// <value>First name of the recipient.</value>
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the recipient.
        /// </summary>
        /// <value>Last Name of the recipient.</value>
        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The delivery address first line
        /// </summary>
        /// <value>The delivery address first line</value>
        [Required]
        [DataMember(Name="address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The delivery address second line
        /// </summary>
        /// <value>The delivery address second line</value>
        [DataMember(Name="address2")]
        public string Address2 { get; set; }

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
        /// The phone number of the person receiving the delivery.
        /// </summary>
        /// <value>The phone number of the person receiving the delivery.</value>
        [DataMember(Name="phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Address)obj);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
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
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    Address1 == other.Address1 ||
                    Address1 != null &&
                    Address1.Equals(other.Address1)
                ) && 
                (
                    Address2 == other.Address2 ||
                    Address2 != null &&
                    Address2.Equals(other.Address2)
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
                ) && 
                (
                    PhoneNumber == other.PhoneNumber ||
                    PhoneNumber != null &&
                    PhoneNumber.Equals(other.PhoneNumber)
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
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (Address1 != null)
                    hashCode = hashCode * 59 + Address1.GetHashCode();
                    if (Address2 != null)
                    hashCode = hashCode * 59 + Address2.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                    if (PostalCode != null)
                    hashCode = hashCode * 59 + PostalCode.GetHashCode();
                    if (PhoneNumber != null)
                    hashCode = hashCode * 59 + PhoneNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Address left, Address right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Address left, Address right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
