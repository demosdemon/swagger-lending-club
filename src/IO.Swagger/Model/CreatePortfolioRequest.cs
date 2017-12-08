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
    /// CreatePortfolioRequest
    /// </summary>
    [DataContract]
    public partial class CreatePortfolioRequest :  IEquatable<CreatePortfolioRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePortfolioRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePortfolioRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePortfolioRequest" /> class.
        /// </summary>
        /// <param name="ActorId">The investor id (required).</param>
        /// <param name="PortfolioName">PortfolioName (required).</param>
        /// <param name="PortfolioDescription">PortfolioDescription.</param>
        public CreatePortfolioRequest(int? ActorId = default(int?), string PortfolioName = default(string), string PortfolioDescription = default(string))
        {
            // to ensure "ActorId" is required (not null)
            if (ActorId == null)
            {
                throw new InvalidDataException("ActorId is a required property for CreatePortfolioRequest and cannot be null");
            }
            else
            {
                this.ActorId = ActorId;
            }
            // to ensure "PortfolioName" is required (not null)
            if (PortfolioName == null)
            {
                throw new InvalidDataException("PortfolioName is a required property for CreatePortfolioRequest and cannot be null");
            }
            else
            {
                this.PortfolioName = PortfolioName;
            }
            this.PortfolioDescription = PortfolioDescription;
        }
        
        /// <summary>
        /// The investor id
        /// </summary>
        /// <value>The investor id</value>
        [DataMember(Name="actorId", EmitDefaultValue=false)]
        public int? ActorId { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioName
        /// </summary>
        [DataMember(Name="portfolioName", EmitDefaultValue=false)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioDescription
        /// </summary>
        [DataMember(Name="portfolioDescription", EmitDefaultValue=false)]
        public string PortfolioDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePortfolioRequest {\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  PortfolioName: ").Append(PortfolioName).Append("\n");
            sb.Append("  PortfolioDescription: ").Append(PortfolioDescription).Append("\n");
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
            return this.Equals(input as CreatePortfolioRequest);
        }

        /// <summary>
        /// Returns true if CreatePortfolioRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePortfolioRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePortfolioRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActorId == input.ActorId ||
                    (this.ActorId != null &&
                    this.ActorId.Equals(input.ActorId))
                ) && 
                (
                    this.PortfolioName == input.PortfolioName ||
                    (this.PortfolioName != null &&
                    this.PortfolioName.Equals(input.PortfolioName))
                ) && 
                (
                    this.PortfolioDescription == input.PortfolioDescription ||
                    (this.PortfolioDescription != null &&
                    this.PortfolioDescription.Equals(input.PortfolioDescription))
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
                if (this.ActorId != null)
                    hashCode = hashCode * 59 + this.ActorId.GetHashCode();
                if (this.PortfolioName != null)
                    hashCode = hashCode * 59 + this.PortfolioName.GetHashCode();
                if (this.PortfolioDescription != null)
                    hashCode = hashCode * 59 + this.PortfolioDescription.GetHashCode();
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