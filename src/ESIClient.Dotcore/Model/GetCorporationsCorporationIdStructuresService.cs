/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.2
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
    /// service object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdStructuresService :  IEquatable<GetCorporationsCorporationIdStructuresService>
    {
        /// <summary>
        /// state string
        /// </summary>
        /// <value>state string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Online for value: online
            /// </summary>
            [EnumMember(Value = "online")]
            Online = 1,
            
            /// <summary>
            /// Enum Offline for value: offline
            /// </summary>
            [EnumMember(Value = "offline")]
            Offline = 2,
            
            /// <summary>
            /// Enum Cleanup for value: cleanup
            /// </summary>
            [EnumMember(Value = "cleanup")]
            Cleanup = 3
        }

        /// <summary>
        /// state string
        /// </summary>
        /// <value>state string</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdStructuresService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdStructuresService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdStructuresService" /> class.
        /// </summary>
        /// <param name="name">name string (required).</param>
        /// <param name="state">state string (required).</param>
        public GetCorporationsCorporationIdStructuresService(string name = default(string), StateEnum state = default(StateEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCorporationsCorporationIdStructuresService and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for GetCorporationsCorporationIdStructuresService and cannot be null");
            }
            else
            {
                this.State = state;
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
            sb.Append("class GetCorporationsCorporationIdStructuresService {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdStructuresService);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdStructuresService instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdStructuresService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdStructuresService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }

}