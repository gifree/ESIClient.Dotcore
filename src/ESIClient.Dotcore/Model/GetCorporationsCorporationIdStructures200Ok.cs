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
    public partial class GetCorporationsCorporationIdStructures200Ok :  IEquatable<GetCorporationsCorporationIdStructures200Ok>
    {
        /// <summary>
        /// state string
        /// </summary>
        /// <value>state string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Anchorvulnerable for value: anchor_vulnerable
            /// </summary>
            [EnumMember(Value = "anchor_vulnerable")]
            Anchorvulnerable = 1,
            
            /// <summary>
            /// Enum Anchoring for value: anchoring
            /// </summary>
            [EnumMember(Value = "anchoring")]
            Anchoring = 2,
            
            /// <summary>
            /// Enum Armorreinforce for value: armor_reinforce
            /// </summary>
            [EnumMember(Value = "armor_reinforce")]
            Armorreinforce = 3,
            
            /// <summary>
            /// Enum Armorvulnerable for value: armor_vulnerable
            /// </summary>
            [EnumMember(Value = "armor_vulnerable")]
            Armorvulnerable = 4,
            
            /// <summary>
            /// Enum Fittinginvulnerable for value: fitting_invulnerable
            /// </summary>
            [EnumMember(Value = "fitting_invulnerable")]
            Fittinginvulnerable = 5,
            
            /// <summary>
            /// Enum Hullreinforce for value: hull_reinforce
            /// </summary>
            [EnumMember(Value = "hull_reinforce")]
            Hullreinforce = 6,
            
            /// <summary>
            /// Enum Hullvulnerable for value: hull_vulnerable
            /// </summary>
            [EnumMember(Value = "hull_vulnerable")]
            Hullvulnerable = 7,
            
            /// <summary>
            /// Enum Onlinedeprecated for value: online_deprecated
            /// </summary>
            [EnumMember(Value = "online_deprecated")]
            Onlinedeprecated = 8,
            
            /// <summary>
            /// Enum Onliningvulnerable for value: onlining_vulnerable
            /// </summary>
            [EnumMember(Value = "onlining_vulnerable")]
            Onliningvulnerable = 9,
            
            /// <summary>
            /// Enum Shieldvulnerable for value: shield_vulnerable
            /// </summary>
            [EnumMember(Value = "shield_vulnerable")]
            Shieldvulnerable = 10,
            
            /// <summary>
            /// Enum Unanchored for value: unanchored
            /// </summary>
            [EnumMember(Value = "unanchored")]
            Unanchored = 11,
            
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 12
        }

        /// <summary>
        /// state string
        /// </summary>
        /// <value>state string</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdStructures200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdStructures200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdStructures200Ok" /> class.
        /// </summary>
        /// <param name="corporationId">ID of the corporation that owns the structure (required).</param>
        /// <param name="fuelExpires">Date on which the structure will run out of fuel.</param>
        /// <param name="nextReinforceApply">The date and time when the structure&#39;s newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect..</param>
        /// <param name="nextReinforceHour">The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply..</param>
        /// <param name="nextReinforceWeekday">The requested change to reinforce_weekday that will take effect at the time shown by next_reinforce_apply..</param>
        /// <param name="profileId">The id of the ACL profile for this citadel (required).</param>
        /// <param name="reinforceHour">The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property. (required).</param>
        /// <param name="reinforceWeekday">The day of the week when the structure exits its final reinforcement period and becomes vulnerable to attack against its hull. Monday is 0 and Sunday is 6. (required).</param>
        /// <param name="services">Contains a list of service upgrades, and their state.</param>
        /// <param name="state">state string (required).</param>
        /// <param name="stateTimerEnd">Date at which the structure will move to it&#39;s next state.</param>
        /// <param name="stateTimerStart">Date at which the structure entered it&#39;s current state.</param>
        /// <param name="structureId">The Item ID of the structure (required).</param>
        /// <param name="systemId">The solar system the structure is in (required).</param>
        /// <param name="typeId">The type id of the structure (required).</param>
        /// <param name="unanchorsAt">Date at which the structure will unanchor.</param>
        public GetCorporationsCorporationIdStructures200Ok(int? corporationId = default(int?), DateTime? fuelExpires = default(DateTime?), DateTime? nextReinforceApply = default(DateTime?), int? nextReinforceHour = default(int?), int? nextReinforceWeekday = default(int?), int? profileId = default(int?), int? reinforceHour = default(int?), int? reinforceWeekday = default(int?), List<GetCorporationsCorporationIdStructuresService> services = default(List<GetCorporationsCorporationIdStructuresService>), StateEnum state = default(StateEnum), DateTime? stateTimerEnd = default(DateTime?), DateTime? stateTimerStart = default(DateTime?), long? structureId = default(long?), int? systemId = default(int?), int? typeId = default(int?), DateTime? unanchorsAt = default(DateTime?))
        {
            // to ensure "corporationId" is required (not null)
            if (corporationId == null)
            {
                throw new InvalidDataException("corporationId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.CorporationId = corporationId;
            }
            // to ensure "profileId" is required (not null)
            if (profileId == null)
            {
                throw new InvalidDataException("profileId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.ProfileId = profileId;
            }
            // to ensure "reinforceHour" is required (not null)
            if (reinforceHour == null)
            {
                throw new InvalidDataException("reinforceHour is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.ReinforceHour = reinforceHour;
            }
            // to ensure "reinforceWeekday" is required (not null)
            if (reinforceWeekday == null)
            {
                throw new InvalidDataException("reinforceWeekday is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.ReinforceWeekday = reinforceWeekday;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "structureId" is required (not null)
            if (structureId == null)
            {
                throw new InvalidDataException("structureId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.StructureId = structureId;
            }
            // to ensure "systemId" is required (not null)
            if (systemId == null)
            {
                throw new InvalidDataException("systemId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.SystemId = systemId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
            this.FuelExpires = fuelExpires;
            this.NextReinforceApply = nextReinforceApply;
            this.NextReinforceHour = nextReinforceHour;
            this.NextReinforceWeekday = nextReinforceWeekday;
            this.Services = services;
            this.StateTimerEnd = stateTimerEnd;
            this.StateTimerStart = stateTimerStart;
            this.UnanchorsAt = unanchorsAt;
        }
        
        /// <summary>
        /// ID of the corporation that owns the structure
        /// </summary>
        /// <value>ID of the corporation that owns the structure</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// Date on which the structure will run out of fuel
        /// </summary>
        /// <value>Date on which the structure will run out of fuel</value>
        [DataMember(Name="fuel_expires", EmitDefaultValue=false)]
        public DateTime? FuelExpires { get; set; }

        /// <summary>
        /// The date and time when the structure&#39;s newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect.
        /// </summary>
        /// <value>The date and time when the structure&#39;s newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect.</value>
        [DataMember(Name="next_reinforce_apply", EmitDefaultValue=false)]
        public DateTime? NextReinforceApply { get; set; }

        /// <summary>
        /// The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply.
        /// </summary>
        /// <value>The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply.</value>
        [DataMember(Name="next_reinforce_hour", EmitDefaultValue=false)]
        public int? NextReinforceHour { get; set; }

        /// <summary>
        /// The requested change to reinforce_weekday that will take effect at the time shown by next_reinforce_apply.
        /// </summary>
        /// <value>The requested change to reinforce_weekday that will take effect at the time shown by next_reinforce_apply.</value>
        [DataMember(Name="next_reinforce_weekday", EmitDefaultValue=false)]
        public int? NextReinforceWeekday { get; set; }

        /// <summary>
        /// The id of the ACL profile for this citadel
        /// </summary>
        /// <value>The id of the ACL profile for this citadel</value>
        [DataMember(Name="profile_id", EmitDefaultValue=false)]
        public int? ProfileId { get; set; }

        /// <summary>
        /// The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property.
        /// </summary>
        /// <value>The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property.</value>
        [DataMember(Name="reinforce_hour", EmitDefaultValue=false)]
        public int? ReinforceHour { get; set; }

        /// <summary>
        /// The day of the week when the structure exits its final reinforcement period and becomes vulnerable to attack against its hull. Monday is 0 and Sunday is 6.
        /// </summary>
        /// <value>The day of the week when the structure exits its final reinforcement period and becomes vulnerable to attack against its hull. Monday is 0 and Sunday is 6.</value>
        [DataMember(Name="reinforce_weekday", EmitDefaultValue=false)]
        public int? ReinforceWeekday { get; set; }

        /// <summary>
        /// Contains a list of service upgrades, and their state
        /// </summary>
        /// <value>Contains a list of service upgrades, and their state</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<GetCorporationsCorporationIdStructuresService> Services { get; set; }


        /// <summary>
        /// Date at which the structure will move to it&#39;s next state
        /// </summary>
        /// <value>Date at which the structure will move to it&#39;s next state</value>
        [DataMember(Name="state_timer_end", EmitDefaultValue=false)]
        public DateTime? StateTimerEnd { get; set; }

        /// <summary>
        /// Date at which the structure entered it&#39;s current state
        /// </summary>
        /// <value>Date at which the structure entered it&#39;s current state</value>
        [DataMember(Name="state_timer_start", EmitDefaultValue=false)]
        public DateTime? StateTimerStart { get; set; }

        /// <summary>
        /// The Item ID of the structure
        /// </summary>
        /// <value>The Item ID of the structure</value>
        [DataMember(Name="structure_id", EmitDefaultValue=false)]
        public long? StructureId { get; set; }

        /// <summary>
        /// The solar system the structure is in
        /// </summary>
        /// <value>The solar system the structure is in</value>
        [DataMember(Name="system_id", EmitDefaultValue=false)]
        public int? SystemId { get; set; }

        /// <summary>
        /// The type id of the structure
        /// </summary>
        /// <value>The type id of the structure</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Date at which the structure will unanchor
        /// </summary>
        /// <value>Date at which the structure will unanchor</value>
        [DataMember(Name="unanchors_at", EmitDefaultValue=false)]
        public DateTime? UnanchorsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdStructures200Ok {\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  FuelExpires: ").Append(FuelExpires).Append("\n");
            sb.Append("  NextReinforceApply: ").Append(NextReinforceApply).Append("\n");
            sb.Append("  NextReinforceHour: ").Append(NextReinforceHour).Append("\n");
            sb.Append("  NextReinforceWeekday: ").Append(NextReinforceWeekday).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  ReinforceHour: ").Append(ReinforceHour).Append("\n");
            sb.Append("  ReinforceWeekday: ").Append(ReinforceWeekday).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateTimerEnd: ").Append(StateTimerEnd).Append("\n");
            sb.Append("  StateTimerStart: ").Append(StateTimerStart).Append("\n");
            sb.Append("  StructureId: ").Append(StructureId).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  UnanchorsAt: ").Append(UnanchorsAt).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdStructures200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdStructures200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdStructures200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdStructures200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.FuelExpires == input.FuelExpires ||
                    (this.FuelExpires != null &&
                    this.FuelExpires.Equals(input.FuelExpires))
                ) && 
                (
                    this.NextReinforceApply == input.NextReinforceApply ||
                    (this.NextReinforceApply != null &&
                    this.NextReinforceApply.Equals(input.NextReinforceApply))
                ) && 
                (
                    this.NextReinforceHour == input.NextReinforceHour ||
                    (this.NextReinforceHour != null &&
                    this.NextReinforceHour.Equals(input.NextReinforceHour))
                ) && 
                (
                    this.NextReinforceWeekday == input.NextReinforceWeekday ||
                    (this.NextReinforceWeekday != null &&
                    this.NextReinforceWeekday.Equals(input.NextReinforceWeekday))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.ReinforceHour == input.ReinforceHour ||
                    (this.ReinforceHour != null &&
                    this.ReinforceHour.Equals(input.ReinforceHour))
                ) && 
                (
                    this.ReinforceWeekday == input.ReinforceWeekday ||
                    (this.ReinforceWeekday != null &&
                    this.ReinforceWeekday.Equals(input.ReinforceWeekday))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateTimerEnd == input.StateTimerEnd ||
                    (this.StateTimerEnd != null &&
                    this.StateTimerEnd.Equals(input.StateTimerEnd))
                ) && 
                (
                    this.StateTimerStart == input.StateTimerStart ||
                    (this.StateTimerStart != null &&
                    this.StateTimerStart.Equals(input.StateTimerStart))
                ) && 
                (
                    this.StructureId == input.StructureId ||
                    (this.StructureId != null &&
                    this.StructureId.Equals(input.StructureId))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.UnanchorsAt == input.UnanchorsAt ||
                    (this.UnanchorsAt != null &&
                    this.UnanchorsAt.Equals(input.UnanchorsAt))
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
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.FuelExpires != null)
                    hashCode = hashCode * 59 + this.FuelExpires.GetHashCode();
                if (this.NextReinforceApply != null)
                    hashCode = hashCode * 59 + this.NextReinforceApply.GetHashCode();
                if (this.NextReinforceHour != null)
                    hashCode = hashCode * 59 + this.NextReinforceHour.GetHashCode();
                if (this.NextReinforceWeekday != null)
                    hashCode = hashCode * 59 + this.NextReinforceWeekday.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.ReinforceHour != null)
                    hashCode = hashCode * 59 + this.ReinforceHour.GetHashCode();
                if (this.ReinforceWeekday != null)
                    hashCode = hashCode * 59 + this.ReinforceWeekday.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateTimerEnd != null)
                    hashCode = hashCode * 59 + this.StateTimerEnd.GetHashCode();
                if (this.StateTimerStart != null)
                    hashCode = hashCode * 59 + this.StateTimerStart.GetHashCode();
                if (this.StructureId != null)
                    hashCode = hashCode * 59 + this.StructureId.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.UnanchorsAt != null)
                    hashCode = hashCode * 59 + this.UnanchorsAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
