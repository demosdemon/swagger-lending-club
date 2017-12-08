/* 
 * Lending Club API
 *
 * Lending Club API
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PortfoliosOwned
    /// </summary>
    [DataContract]
    public partial class PortfoliosOwned :  IEquatable<PortfoliosOwned>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosOwned" /> class.
        /// </summary>
        /// <param name="MyPortfolios">MyPortfolios.</param>
        public PortfoliosOwned(List<Portfolio> MyPortfolios = default(List<Portfolio>))
        {
            this.MyPortfolios = MyPortfolios;
        }
        
        /// <summary>
        /// Gets or Sets MyPortfolios
        /// </summary>
        [DataMember(Name="myPortfolios", EmitDefaultValue=false)]
        public List<Portfolio> MyPortfolios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortfoliosOwned {\n");
            sb.Append("  MyPortfolios: ").Append(MyPortfolios).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortfoliosOwned);
        }

        /// <summary>
        /// Returns true if PortfoliosOwned instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfoliosOwned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfoliosOwned input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MyPortfolios == input.MyPortfolios ||
                    this.MyPortfolios != null &&
                    this.MyPortfolios.SequenceEqual(input.MyPortfolios)
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
                if (this.MyPortfolios != null)
                    hashCode = hashCode * 59 + this.MyPortfolios.GetHashCode();
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
