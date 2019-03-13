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
    public partial class LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing : IEquatable<LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing>
    { 
        /// <summary>
        /// opt in for costco generated marketing communications
        /// </summary>
        /// <value>opt in for costco generated marketing communications</value>
        [Required]
        [DataMember(Name="costcoMarketingOptIn")]
        public bool? CostcoMarketingOptIn { get; set; }

        /// <summary>
        /// opt in for costco partner generated marketing communications
        /// </summary>
        /// <value>opt in for costco partner generated marketing communications</value>
        [Required]
        [DataMember(Name="costcoPartnerMarketingOptIn")]
        public bool? CostcoPartnerMarketingOptIn { get; set; }

        /// <summary>
        /// opt in for marketing via email
        /// </summary>
        /// <value>opt in for marketing via email</value>
        [Required]
        [DataMember(Name="marketingViaEmailOptIn")]
        public string MarketingViaEmailOptIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing {\n");
            sb.Append("  CostcoMarketingOptIn: ").Append(CostcoMarketingOptIn).Append("\n");
            sb.Append("  CostcoPartnerMarketingOptIn: ").Append(CostcoPartnerMarketingOptIn).Append("\n");
            sb.Append("  MarketingViaEmailOptIn: ").Append(MarketingViaEmailOptIn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing)obj);
        }

        /// <summary>
        /// Returns true if LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing instances are equal
        /// </summary>
        /// <param name="other">Instance of LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CostcoMarketingOptIn == other.CostcoMarketingOptIn ||
                    CostcoMarketingOptIn != null &&
                    CostcoMarketingOptIn.Equals(other.CostcoMarketingOptIn)
                ) && 
                (
                    CostcoPartnerMarketingOptIn == other.CostcoPartnerMarketingOptIn ||
                    CostcoPartnerMarketingOptIn != null &&
                    CostcoPartnerMarketingOptIn.Equals(other.CostcoPartnerMarketingOptIn)
                ) && 
                (
                    MarketingViaEmailOptIn == other.MarketingViaEmailOptIn ||
                    MarketingViaEmailOptIn != null &&
                    MarketingViaEmailOptIn.Equals(other.MarketingViaEmailOptIn)
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
                    if (CostcoMarketingOptIn != null)
                    hashCode = hashCode * 59 + CostcoMarketingOptIn.GetHashCode();
                    if (CostcoPartnerMarketingOptIn != null)
                    hashCode = hashCode * 59 + CostcoPartnerMarketingOptIn.GetHashCode();
                    if (MarketingViaEmailOptIn != null)
                    hashCode = hashCode * 59 + MarketingViaEmailOptIn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing left, LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing left, LoyaltyProgramsmembershipsMembersHouseholdMemberMarketing right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
