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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class PostCharactersCharacterIdAssetsNames200Ok :  IEquatable<PostCharactersCharacterIdAssetsNames200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdAssetsNames200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCharactersCharacterIdAssetsNames200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdAssetsNames200Ok" /> class.
        /// </summary>
        /// <param name="itemId">item_id integer (required).</param>
        /// <param name="name">name string (required).</param>
        public PostCharactersCharacterIdAssetsNames200Ok(long? itemId = default(long?), string name = default(string))
        {
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new InvalidDataException("itemId is a required property for PostCharactersCharacterIdAssetsNames200Ok and cannot be null");
            }
            else
            {
                this.ItemId = itemId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PostCharactersCharacterIdAssetsNames200Ok and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// item_id integer
        /// </summary>
        /// <value>item_id integer</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public long? ItemId { get; set; }

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
            sb.Append("class PostCharactersCharacterIdAssetsNames200Ok {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as PostCharactersCharacterIdAssetsNames200Ok);
        }

        /// <summary>
        /// Returns true if PostCharactersCharacterIdAssetsNames200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCharactersCharacterIdAssetsNames200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCharactersCharacterIdAssetsNames200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}