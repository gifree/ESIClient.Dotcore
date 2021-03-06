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
    public partial class GetDogmaAttributesAttributeIdOk :  IEquatable<GetDogmaAttributesAttributeIdOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDogmaAttributesAttributeIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDogmaAttributesAttributeIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDogmaAttributesAttributeIdOk" /> class.
        /// </summary>
        /// <param name="attributeId">attribute_id integer (required).</param>
        /// <param name="defaultValue">default_value number.</param>
        /// <param name="description">description string.</param>
        /// <param name="displayName">display_name string.</param>
        /// <param name="highIsGood">high_is_good boolean.</param>
        /// <param name="iconId">icon_id integer.</param>
        /// <param name="name">name string.</param>
        /// <param name="published">published boolean.</param>
        /// <param name="stackable">stackable boolean.</param>
        /// <param name="unitId">unit_id integer.</param>
        public GetDogmaAttributesAttributeIdOk(int? attributeId = default(int?), float? defaultValue = default(float?), string description = default(string), string displayName = default(string), bool? highIsGood = default(bool?), int? iconId = default(int?), string name = default(string), bool? published = default(bool?), bool? stackable = default(bool?), int? unitId = default(int?))
        {
            // to ensure "attributeId" is required (not null)
            if (attributeId == null)
            {
                throw new InvalidDataException("attributeId is a required property for GetDogmaAttributesAttributeIdOk and cannot be null");
            }
            else
            {
                this.AttributeId = attributeId;
            }
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.DisplayName = displayName;
            this.HighIsGood = highIsGood;
            this.IconId = iconId;
            this.Name = name;
            this.Published = published;
            this.Stackable = stackable;
            this.UnitId = unitId;
        }
        
        /// <summary>
        /// attribute_id integer
        /// </summary>
        /// <value>attribute_id integer</value>
        [DataMember(Name="attribute_id", EmitDefaultValue=false)]
        public int? AttributeId { get; set; }

        /// <summary>
        /// default_value number
        /// </summary>
        /// <value>default_value number</value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public float? DefaultValue { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// display_name string
        /// </summary>
        /// <value>display_name string</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// high_is_good boolean
        /// </summary>
        /// <value>high_is_good boolean</value>
        [DataMember(Name="high_is_good", EmitDefaultValue=false)]
        public bool? HighIsGood { get; set; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        /// <value>icon_id integer</value>
        [DataMember(Name="icon_id", EmitDefaultValue=false)]
        public int? IconId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        /// <value>published boolean</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// stackable boolean
        /// </summary>
        /// <value>stackable boolean</value>
        [DataMember(Name="stackable", EmitDefaultValue=false)]
        public bool? Stackable { get; set; }

        /// <summary>
        /// unit_id integer
        /// </summary>
        /// <value>unit_id integer</value>
        [DataMember(Name="unit_id", EmitDefaultValue=false)]
        public int? UnitId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDogmaAttributesAttributeIdOk {\n");
            sb.Append("  AttributeId: ").Append(AttributeId).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  HighIsGood: ").Append(HighIsGood).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Stackable: ").Append(Stackable).Append("\n");
            sb.Append("  UnitId: ").Append(UnitId).Append("\n");
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
            return this.Equals(input as GetDogmaAttributesAttributeIdOk);
        }

        /// <summary>
        /// Returns true if GetDogmaAttributesAttributeIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDogmaAttributesAttributeIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDogmaAttributesAttributeIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeId == input.AttributeId ||
                    (this.AttributeId != null &&
                    this.AttributeId.Equals(input.AttributeId))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.HighIsGood == input.HighIsGood ||
                    (this.HighIsGood != null &&
                    this.HighIsGood.Equals(input.HighIsGood))
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.Stackable == input.Stackable ||
                    (this.Stackable != null &&
                    this.Stackable.Equals(input.Stackable))
                ) && 
                (
                    this.UnitId == input.UnitId ||
                    (this.UnitId != null &&
                    this.UnitId.Equals(input.UnitId))
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
                if (this.AttributeId != null)
                    hashCode = hashCode * 59 + this.AttributeId.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.HighIsGood != null)
                    hashCode = hashCode * 59 + this.HighIsGood.GetHashCode();
                if (this.IconId != null)
                    hashCode = hashCode * 59 + this.IconId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.Stackable != null)
                    hashCode = hashCode * 59 + this.Stackable.GetHashCode();
                if (this.UnitId != null)
                    hashCode = hashCode * 59 + this.UnitId.GetHashCode();
                return hashCode;
            }
        }
    }

}
