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
    /// BuyNotesResponse
    /// </summary>
    [DataContract]
    public partial class BuyNotesResponse :  IEquatable<BuyNotesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyNotesResponse" /> class.
        /// </summary>
        /// <param name="BuyNoteConfirmations">BuyNoteConfirmations.</param>
        public BuyNotesResponse(List<BuyNote> BuyNoteConfirmations = default(List<BuyNote>))
        {
            this.BuyNoteConfirmations = BuyNoteConfirmations;
        }
        
        /// <summary>
        /// Gets or Sets BuyNoteConfirmations
        /// </summary>
        [DataMember(Name="buyNoteConfirmations", EmitDefaultValue=false)]
        public List<BuyNote> BuyNoteConfirmations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuyNotesResponse {\n");
            sb.Append("  BuyNoteConfirmations: ").Append(BuyNoteConfirmations).Append("\n");
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
            return this.Equals(input as BuyNotesResponse);
        }

        /// <summary>
        /// Returns true if BuyNotesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyNotesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyNotesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuyNoteConfirmations == input.BuyNoteConfirmations ||
                    this.BuyNoteConfirmations != null &&
                    this.BuyNoteConfirmations.SequenceEqual(input.BuyNoteConfirmations)
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
                if (this.BuyNoteConfirmations != null)
                    hashCode = hashCode * 59 + this.BuyNoteConfirmations.GetHashCode();
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
