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
    /// Linked Fees represent \&quot;outside\&quot; taxes passed on to consumers for various government programs.
    /// </summary>
    [DataContract]
    public partial class LinkedFee :  IEquatable<LinkedFee>
    { 
        /// <summary>
        /// Costco Provided Linked Fee Item Number
        /// </summary>
        /// <value>Costco Provided Linked Fee Item Number</value>
        [Required]
        [DataMember(Name="feeSKU")]
        public string FeeSKU { get; set; }

        /// <summary>
        /// Unit Price of Fee Item, represented as a number
        /// </summary>
        /// <value>Unit Price of Fee Item, represented as a number</value>
        [Required]
        [DataMember(Name="feeUnitPrice")]
        public decimal? FeeUnitPrice { get; set; }

        /// <summary>
        /// The cost of tax for a fee unit, represented as a number
        /// </summary>
        /// <value>The cost of tax for a fee unit, represented as a number</value>
        [Required]
        [DataMember(Name="feeUnitTaxPrice")]
        public decimal? FeeUnitTaxPrice { get; set; }

        /// <summary>
        /// Quantity of Fee Items
        /// </summary>
        /// <value>Quantity of Fee Items</value>
        [Required]
        [DataMember(Name="quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Costco Provided Linked Fee Description
        /// </summary>
        /// <value>Costco Provided Linked Fee Description</value>
        [DataMember(Name="feeDescription")]
        public List<LinkedFeeFeeDescription> FeeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkedFee {\n");
            sb.Append("  FeeSKU: ").Append(FeeSKU).Append("\n");
            sb.Append("  FeeUnitPrice: ").Append(FeeUnitPrice).Append("\n");
            sb.Append("  FeeUnitTaxPrice: ").Append(FeeUnitTaxPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  FeeDescription: ").Append(FeeDescription).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LinkedFee)obj);
        }

        /// <summary>
        /// Returns true if LinkedFee instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkedFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedFee other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FeeSKU == other.FeeSKU ||
                    FeeSKU != null &&
                    FeeSKU.Equals(other.FeeSKU)
                ) && 
                (
                    FeeUnitPrice == other.FeeUnitPrice ||
                    FeeUnitPrice != null &&
                    FeeUnitPrice.Equals(other.FeeUnitPrice)
                ) && 
                (
                    FeeUnitTaxPrice == other.FeeUnitTaxPrice ||
                    FeeUnitTaxPrice != null &&
                    FeeUnitTaxPrice.Equals(other.FeeUnitTaxPrice)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    FeeDescription == other.FeeDescription ||
                    FeeDescription != null &&
                    FeeDescription.SequenceEqual(other.FeeDescription)
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
                    if (FeeSKU != null)
                    hashCode = hashCode * 59 + FeeSKU.GetHashCode();
                    if (FeeUnitPrice != null)
                    hashCode = hashCode * 59 + FeeUnitPrice.GetHashCode();
                    if (FeeUnitTaxPrice != null)
                    hashCode = hashCode * 59 + FeeUnitTaxPrice.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (FeeDescription != null)
                    hashCode = hashCode * 59 + FeeDescription.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LinkedFee left, LinkedFee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LinkedFee left, LinkedFee right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
