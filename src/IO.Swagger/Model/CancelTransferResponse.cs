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
    /// CancelTransferResponse
    /// </summary>
    [DataContract]
    public partial class CancelTransferResponse :  IEquatable<CancelTransferResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTransferResponse" /> class.
        /// </summary>
        /// <param name="InvestorId">InvestorId.</param>
        /// <param name="CancellationResults">CancellationResults.</param>
        public CancelTransferResponse(int? InvestorId = default(int?), List<CancellationResult> CancellationResults = default(List<CancellationResult>))
        {
            this.InvestorId = InvestorId;
            this.CancellationResults = CancellationResults;
        }
        
        /// <summary>
        /// Gets or Sets InvestorId
        /// </summary>
        [DataMember(Name="investorId", EmitDefaultValue=false)]
        public int? InvestorId { get; set; }

        /// <summary>
        /// Gets or Sets CancellationResults
        /// </summary>
        [DataMember(Name="cancellationResults", EmitDefaultValue=false)]
        public List<CancellationResult> CancellationResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelTransferResponse {\n");
            sb.Append("  InvestorId: ").Append(InvestorId).Append("\n");
            sb.Append("  CancellationResults: ").Append(CancellationResults).Append("\n");
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
            return this.Equals(input as CancelTransferResponse);
        }

        /// <summary>
        /// Returns true if CancelTransferResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelTransferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelTransferResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvestorId == input.InvestorId ||
                    (this.InvestorId != null &&
                    this.InvestorId.Equals(input.InvestorId))
                ) && 
                (
                    this.CancellationResults == input.CancellationResults ||
                    this.CancellationResults != null &&
                    this.CancellationResults.SequenceEqual(input.CancellationResults)
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
                if (this.InvestorId != null)
                    hashCode = hashCode * 59 + this.InvestorId.GetHashCode();
                if (this.CancellationResults != null)
                    hashCode = hashCode * 59 + this.CancellationResults.GetHashCode();
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
