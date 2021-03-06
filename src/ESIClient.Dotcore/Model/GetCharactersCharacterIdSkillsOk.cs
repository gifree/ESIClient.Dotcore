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
    public partial class GetCharactersCharacterIdSkillsOk :  IEquatable<GetCharactersCharacterIdSkillsOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdSkillsOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdSkillsOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdSkillsOk" /> class.
        /// </summary>
        /// <param name="skills">skills array (required).</param>
        /// <param name="totalSp">total_sp integer (required).</param>
        /// <param name="unallocatedSp">Skill points available to be assigned.</param>
        public GetCharactersCharacterIdSkillsOk(List<GetCharactersCharacterIdSkillsSkill> skills = default(List<GetCharactersCharacterIdSkillsSkill>), long? totalSp = default(long?), int? unallocatedSp = default(int?))
        {
            // to ensure "skills" is required (not null)
            if (skills == null)
            {
                throw new InvalidDataException("skills is a required property for GetCharactersCharacterIdSkillsOk and cannot be null");
            }
            else
            {
                this.Skills = skills;
            }
            // to ensure "totalSp" is required (not null)
            if (totalSp == null)
            {
                throw new InvalidDataException("totalSp is a required property for GetCharactersCharacterIdSkillsOk and cannot be null");
            }
            else
            {
                this.TotalSp = totalSp;
            }
            this.UnallocatedSp = unallocatedSp;
        }
        
        /// <summary>
        /// skills array
        /// </summary>
        /// <value>skills array</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<GetCharactersCharacterIdSkillsSkill> Skills { get; set; }

        /// <summary>
        /// total_sp integer
        /// </summary>
        /// <value>total_sp integer</value>
        [DataMember(Name="total_sp", EmitDefaultValue=false)]
        public long? TotalSp { get; set; }

        /// <summary>
        /// Skill points available to be assigned
        /// </summary>
        /// <value>Skill points available to be assigned</value>
        [DataMember(Name="unallocated_sp", EmitDefaultValue=false)]
        public int? UnallocatedSp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdSkillsOk {\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  TotalSp: ").Append(TotalSp).Append("\n");
            sb.Append("  UnallocatedSp: ").Append(UnallocatedSp).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdSkillsOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdSkillsOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdSkillsOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdSkillsOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Skills == input.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(input.Skills)
                ) && 
                (
                    this.TotalSp == input.TotalSp ||
                    (this.TotalSp != null &&
                    this.TotalSp.Equals(input.TotalSp))
                ) && 
                (
                    this.UnallocatedSp == input.UnallocatedSp ||
                    (this.UnallocatedSp != null &&
                    this.UnallocatedSp.Equals(input.UnallocatedSp))
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
                if (this.Skills != null)
                    hashCode = hashCode * 59 + this.Skills.GetHashCode();
                if (this.TotalSp != null)
                    hashCode = hashCode * 59 + this.TotalSp.GetHashCode();
                if (this.UnallocatedSp != null)
                    hashCode = hashCode * 59 + this.UnallocatedSp.GetHashCode();
                return hashCode;
            }
        }
    }

}
