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
    /// naming object
    /// </summary>
    [DataContract]
    public partial class PutFleetsFleetIdSquadsSquadIdNaming :  IEquatable<PutFleetsFleetIdSquadsSquadIdNaming>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFleetsFleetIdSquadsSquadIdNaming" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PutFleetsFleetIdSquadsSquadIdNaming() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFleetsFleetIdSquadsSquadIdNaming" /> class.
        /// </summary>
        /// <param name="name">name string (required).</param>
        public PutFleetsFleetIdSquadsSquadIdNaming(string name = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PutFleetsFleetIdSquadsSquadIdNaming and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutFleetsFleetIdSquadsSquadIdNaming {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PutFleetsFleetIdSquadsSquadIdNaming);
        }

        /// <summary>
        /// Returns true if PutFleetsFleetIdSquadsSquadIdNaming instances are equal
        /// </summary>
        /// <param name="input">Instance of PutFleetsFleetIdSquadsSquadIdNaming to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutFleetsFleetIdSquadsSquadIdNaming input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
