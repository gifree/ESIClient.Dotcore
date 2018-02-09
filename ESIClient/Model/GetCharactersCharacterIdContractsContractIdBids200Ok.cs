/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.7.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ESIClient.Client.SwaggerDateConverter;

namespace ESIClient.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdContractsContractIdBids200Ok :  IEquatable<GetCharactersCharacterIdContractsContractIdBids200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdContractsContractIdBids200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdContractsContractIdBids200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdContractsContractIdBids200Ok" /> class.
        /// </summary>
        /// <param name="bidId">Unique ID for the bid (required).</param>
        /// <param name="bidderId">Character ID of the bidder (required).</param>
        /// <param name="dateBid">Datetime when the bid was placed (required).</param>
        /// <param name="amount">The amount bid, in ISK (required).</param>
        public GetCharactersCharacterIdContractsContractIdBids200Ok(int? bidId = default(int?), int? bidderId = default(int?), DateTime? dateBid = default(DateTime?), float? amount = default(float?))
        {
            // to ensure "bidId" is required (not null)
            if (bidId == null)
            {
                throw new InvalidDataException("bidId is a required property for GetCharactersCharacterIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.BidId = bidId;
            }
            // to ensure "bidderId" is required (not null)
            if (bidderId == null)
            {
                throw new InvalidDataException("bidderId is a required property for GetCharactersCharacterIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.BidderId = bidderId;
            }
            // to ensure "dateBid" is required (not null)
            if (dateBid == null)
            {
                throw new InvalidDataException("dateBid is a required property for GetCharactersCharacterIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.DateBid = dateBid;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for GetCharactersCharacterIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
        }
        
        /// <summary>
        /// Unique ID for the bid
        /// </summary>
        /// <value>Unique ID for the bid</value>
        [DataMember(Name="bid_id", EmitDefaultValue=false)]
        public int? BidId { get; set; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>
        /// <value>Character ID of the bidder</value>
        [DataMember(Name="bidder_id", EmitDefaultValue=false)]
        public int? BidderId { get; set; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>
        /// <value>Datetime when the bid was placed</value>
        [DataMember(Name="date_bid", EmitDefaultValue=false)]
        public DateTime? DateBid { get; set; }

        /// <summary>
        /// The amount bid, in ISK
        /// </summary>
        /// <value>The amount bid, in ISK</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdContractsContractIdBids200Ok {\n");
            sb.Append("  BidId: ").Append(BidId).Append("\n");
            sb.Append("  BidderId: ").Append(BidderId).Append("\n");
            sb.Append("  DateBid: ").Append(DateBid).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCharactersCharacterIdContractsContractIdBids200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdContractsContractIdBids200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdContractsContractIdBids200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdContractsContractIdBids200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BidId == input.BidId ||
                    (this.BidId != null &&
                    this.BidId.Equals(input.BidId))
                ) && 
                (
                    this.BidderId == input.BidderId ||
                    (this.BidderId != null &&
                    this.BidderId.Equals(input.BidderId))
                ) && 
                (
                    this.DateBid == input.DateBid ||
                    (this.DateBid != null &&
                    this.DateBid.Equals(input.DateBid))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.BidId != null)
                    hashCode = hashCode * 59 + this.BidId.GetHashCode();
                if (this.BidderId != null)
                    hashCode = hashCode * 59 + this.BidderId.GetHashCode();
                if (this.DateBid != null)
                    hashCode = hashCode * 59 + this.DateBid.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}