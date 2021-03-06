/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.5
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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ESIClient.Dotcore.Client.SwaggerDateConverter;

namespace ESIClient.Dotcore.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdFwStatsOk :  IEquatable<GetCharactersCharacterIdFwStatsOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdFwStatsOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdFwStatsOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdFwStatsOk" /> class.
        /// </summary>
        /// <param name="currentRank">The given character&#39;s current faction rank.</param>
        /// <param name="enlistedOn">The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare.</param>
        /// <param name="factionId">The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare.</param>
        /// <param name="highestRank">The given character&#39;s highest faction rank achieved.</param>
        /// <param name="kills">kills (required).</param>
        /// <param name="victoryPoints">victoryPoints (required).</param>
        public GetCharactersCharacterIdFwStatsOk(int? currentRank = default(int?), DateTime? enlistedOn = default(DateTime?), int? factionId = default(int?), int? highestRank = default(int?), GetCharactersCharacterIdFwStatsKills kills = default(GetCharactersCharacterIdFwStatsKills), GetCharactersCharacterIdFwStatsVictoryPoints victoryPoints = default(GetCharactersCharacterIdFwStatsVictoryPoints))
        {
            // to ensure "kills" is required (not null)
            if (kills == null)
            {
                throw new InvalidDataException("kills is a required property for GetCharactersCharacterIdFwStatsOk and cannot be null");
            }
            else
            {
                this.Kills = kills;
            }
            // to ensure "victoryPoints" is required (not null)
            if (victoryPoints == null)
            {
                throw new InvalidDataException("victoryPoints is a required property for GetCharactersCharacterIdFwStatsOk and cannot be null");
            }
            else
            {
                this.VictoryPoints = victoryPoints;
            }
            this.CurrentRank = currentRank;
            this.EnlistedOn = enlistedOn;
            this.FactionId = factionId;
            this.HighestRank = highestRank;
        }
        
        /// <summary>
        /// The given character&#39;s current faction rank
        /// </summary>
        /// <value>The given character&#39;s current faction rank</value>
        [DataMember(Name="current_rank", EmitDefaultValue=false)]
        public int? CurrentRank { get; set; }

        /// <summary>
        /// The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare
        /// </summary>
        /// <value>The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare</value>
        [DataMember(Name="enlisted_on", EmitDefaultValue=false)]
        public DateTime? EnlistedOn { get; set; }

        /// <summary>
        /// The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare
        /// </summary>
        /// <value>The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// The given character&#39;s highest faction rank achieved
        /// </summary>
        /// <value>The given character&#39;s highest faction rank achieved</value>
        [DataMember(Name="highest_rank", EmitDefaultValue=false)]
        public int? HighestRank { get; set; }

        /// <summary>
        /// Gets or Sets Kills
        /// </summary>
        [DataMember(Name="kills", EmitDefaultValue=false)]
        public GetCharactersCharacterIdFwStatsKills Kills { get; set; }

        /// <summary>
        /// Gets or Sets VictoryPoints
        /// </summary>
        [DataMember(Name="victory_points", EmitDefaultValue=false)]
        public GetCharactersCharacterIdFwStatsVictoryPoints VictoryPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdFwStatsOk {\n");
            sb.Append("  CurrentRank: ").Append(CurrentRank).Append("\n");
            sb.Append("  EnlistedOn: ").Append(EnlistedOn).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  HighestRank: ").Append(HighestRank).Append("\n");
            sb.Append("  Kills: ").Append(Kills).Append("\n");
            sb.Append("  VictoryPoints: ").Append(VictoryPoints).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdFwStatsOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdFwStatsOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdFwStatsOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdFwStatsOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentRank == input.CurrentRank ||
                    (this.CurrentRank != null &&
                    this.CurrentRank.Equals(input.CurrentRank))
                ) && 
                (
                    this.EnlistedOn == input.EnlistedOn ||
                    (this.EnlistedOn != null &&
                    this.EnlistedOn.Equals(input.EnlistedOn))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.HighestRank == input.HighestRank ||
                    (this.HighestRank != null &&
                    this.HighestRank.Equals(input.HighestRank))
                ) && 
                (
                    this.Kills == input.Kills ||
                    (this.Kills != null &&
                    this.Kills.Equals(input.Kills))
                ) && 
                (
                    this.VictoryPoints == input.VictoryPoints ||
                    (this.VictoryPoints != null &&
                    this.VictoryPoints.Equals(input.VictoryPoints))
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
                if (this.CurrentRank != null)
                    hashCode = hashCode * 59 + this.CurrentRank.GetHashCode();
                if (this.EnlistedOn != null)
                    hashCode = hashCode * 59 + this.EnlistedOn.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.HighestRank != null)
                    hashCode = hashCode * 59 + this.HighestRank.GetHashCode();
                if (this.Kills != null)
                    hashCode = hashCode * 59 + this.Kills.GetHashCode();
                if (this.VictoryPoints != null)
                    hashCode = hashCode * 59 + this.VictoryPoints.GetHashCode();
                return hashCode;
            }
        }
    }

}
