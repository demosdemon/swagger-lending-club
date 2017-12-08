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
    /// AccountSummary
    /// </summary>
    [DataContract]
    public partial class AccountSummary :  IEquatable<AccountSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSummary" /> class.
        /// </summary>
        /// <param name="AvailableCash">Available cash amount.</param>
        /// <param name="InvestorId">Investor ID.</param>
        /// <param name="AccruedInterest">Accrued interest amount.</param>
        /// <param name="OutstandingPrincipal">Outstanding principal amount.</param>
        /// <param name="AccountTotal">Account total.</param>
        /// <param name="TotalNotes">Total notes.</param>
        /// <param name="TotalPortfolios">Total portfolios.</param>
        /// <param name="InFundingBalance">In-Funding balance.</param>
        /// <param name="ReceivedInterest">Received interest.</param>
        /// <param name="ReceivedPrincipal">Received principal.</param>
        /// <param name="ReceivedLateFees">Received late fees.</param>
        /// <param name="NetAnnualizedReturn">NetAnnualizedReturn.</param>
        /// <param name="Adjustments">Adjustments.</param>
        public AccountSummary(decimal? AvailableCash = default(decimal?), int? InvestorId = default(int?), decimal? AccruedInterest = default(decimal?), decimal? OutstandingPrincipal = default(decimal?), decimal? AccountTotal = default(decimal?), int? TotalNotes = default(int?), int? TotalPortfolios = default(int?), decimal? InFundingBalance = default(decimal?), decimal? ReceivedInterest = default(decimal?), decimal? ReceivedPrincipal = default(decimal?), decimal? ReceivedLateFees = default(decimal?), NetAnnualizedReturn NetAnnualizedReturn = default(NetAnnualizedReturn), Adjustments Adjustments = default(Adjustments))
        {
            this.AvailableCash = AvailableCash;
            this.InvestorId = InvestorId;
            this.AccruedInterest = AccruedInterest;
            this.OutstandingPrincipal = OutstandingPrincipal;
            this.AccountTotal = AccountTotal;
            this.TotalNotes = TotalNotes;
            this.TotalPortfolios = TotalPortfolios;
            this.InFundingBalance = InFundingBalance;
            this.ReceivedInterest = ReceivedInterest;
            this.ReceivedPrincipal = ReceivedPrincipal;
            this.ReceivedLateFees = ReceivedLateFees;
            this.NetAnnualizedReturn = NetAnnualizedReturn;
            this.Adjustments = Adjustments;
        }
        
        /// <summary>
        /// Available cash amount
        /// </summary>
        /// <value>Available cash amount</value>
        [DataMember(Name="availableCash", EmitDefaultValue=false)]
        public decimal? AvailableCash { get; set; }

        /// <summary>
        /// Investor ID
        /// </summary>
        /// <value>Investor ID</value>
        [DataMember(Name="investorId", EmitDefaultValue=false)]
        public int? InvestorId { get; set; }

        /// <summary>
        /// Accrued interest amount
        /// </summary>
        /// <value>Accrued interest amount</value>
        [DataMember(Name="accruedInterest", EmitDefaultValue=false)]
        public decimal? AccruedInterest { get; set; }

        /// <summary>
        /// Outstanding principal amount
        /// </summary>
        /// <value>Outstanding principal amount</value>
        [DataMember(Name="outstandingPrincipal", EmitDefaultValue=false)]
        public decimal? OutstandingPrincipal { get; set; }

        /// <summary>
        /// Account total
        /// </summary>
        /// <value>Account total</value>
        [DataMember(Name="accountTotal", EmitDefaultValue=false)]
        public decimal? AccountTotal { get; set; }

        /// <summary>
        /// Total notes
        /// </summary>
        /// <value>Total notes</value>
        [DataMember(Name="totalNotes", EmitDefaultValue=false)]
        public int? TotalNotes { get; set; }

        /// <summary>
        /// Total portfolios
        /// </summary>
        /// <value>Total portfolios</value>
        [DataMember(Name="totalPortfolios", EmitDefaultValue=false)]
        public int? TotalPortfolios { get; set; }

        /// <summary>
        /// In-Funding balance
        /// </summary>
        /// <value>In-Funding balance</value>
        [DataMember(Name="inFundingBalance", EmitDefaultValue=false)]
        public decimal? InFundingBalance { get; set; }

        /// <summary>
        /// Received interest
        /// </summary>
        /// <value>Received interest</value>
        [DataMember(Name="receivedInterest", EmitDefaultValue=false)]
        public decimal? ReceivedInterest { get; set; }

        /// <summary>
        /// Received principal
        /// </summary>
        /// <value>Received principal</value>
        [DataMember(Name="receivedPrincipal", EmitDefaultValue=false)]
        public decimal? ReceivedPrincipal { get; set; }

        /// <summary>
        /// Received late fees
        /// </summary>
        /// <value>Received late fees</value>
        [DataMember(Name="receivedLateFees", EmitDefaultValue=false)]
        public decimal? ReceivedLateFees { get; set; }

        /// <summary>
        /// Gets or Sets NetAnnualizedReturn
        /// </summary>
        [DataMember(Name="netAnnualizedReturn", EmitDefaultValue=false)]
        public NetAnnualizedReturn NetAnnualizedReturn { get; set; }

        /// <summary>
        /// Gets or Sets Adjustments
        /// </summary>
        [DataMember(Name="adjustments", EmitDefaultValue=false)]
        public Adjustments Adjustments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSummary {\n");
            sb.Append("  AvailableCash: ").Append(AvailableCash).Append("\n");
            sb.Append("  InvestorId: ").Append(InvestorId).Append("\n");
            sb.Append("  AccruedInterest: ").Append(AccruedInterest).Append("\n");
            sb.Append("  OutstandingPrincipal: ").Append(OutstandingPrincipal).Append("\n");
            sb.Append("  AccountTotal: ").Append(AccountTotal).Append("\n");
            sb.Append("  TotalNotes: ").Append(TotalNotes).Append("\n");
            sb.Append("  TotalPortfolios: ").Append(TotalPortfolios).Append("\n");
            sb.Append("  InFundingBalance: ").Append(InFundingBalance).Append("\n");
            sb.Append("  ReceivedInterest: ").Append(ReceivedInterest).Append("\n");
            sb.Append("  ReceivedPrincipal: ").Append(ReceivedPrincipal).Append("\n");
            sb.Append("  ReceivedLateFees: ").Append(ReceivedLateFees).Append("\n");
            sb.Append("  NetAnnualizedReturn: ").Append(NetAnnualizedReturn).Append("\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
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
            return this.Equals(input as AccountSummary);
        }

        /// <summary>
        /// Returns true if AccountSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableCash == input.AvailableCash ||
                    (this.AvailableCash != null &&
                    this.AvailableCash.Equals(input.AvailableCash))
                ) && 
                (
                    this.InvestorId == input.InvestorId ||
                    (this.InvestorId != null &&
                    this.InvestorId.Equals(input.InvestorId))
                ) && 
                (
                    this.AccruedInterest == input.AccruedInterest ||
                    (this.AccruedInterest != null &&
                    this.AccruedInterest.Equals(input.AccruedInterest))
                ) && 
                (
                    this.OutstandingPrincipal == input.OutstandingPrincipal ||
                    (this.OutstandingPrincipal != null &&
                    this.OutstandingPrincipal.Equals(input.OutstandingPrincipal))
                ) && 
                (
                    this.AccountTotal == input.AccountTotal ||
                    (this.AccountTotal != null &&
                    this.AccountTotal.Equals(input.AccountTotal))
                ) && 
                (
                    this.TotalNotes == input.TotalNotes ||
                    (this.TotalNotes != null &&
                    this.TotalNotes.Equals(input.TotalNotes))
                ) && 
                (
                    this.TotalPortfolios == input.TotalPortfolios ||
                    (this.TotalPortfolios != null &&
                    this.TotalPortfolios.Equals(input.TotalPortfolios))
                ) && 
                (
                    this.InFundingBalance == input.InFundingBalance ||
                    (this.InFundingBalance != null &&
                    this.InFundingBalance.Equals(input.InFundingBalance))
                ) && 
                (
                    this.ReceivedInterest == input.ReceivedInterest ||
                    (this.ReceivedInterest != null &&
                    this.ReceivedInterest.Equals(input.ReceivedInterest))
                ) && 
                (
                    this.ReceivedPrincipal == input.ReceivedPrincipal ||
                    (this.ReceivedPrincipal != null &&
                    this.ReceivedPrincipal.Equals(input.ReceivedPrincipal))
                ) && 
                (
                    this.ReceivedLateFees == input.ReceivedLateFees ||
                    (this.ReceivedLateFees != null &&
                    this.ReceivedLateFees.Equals(input.ReceivedLateFees))
                ) && 
                (
                    this.NetAnnualizedReturn == input.NetAnnualizedReturn ||
                    (this.NetAnnualizedReturn != null &&
                    this.NetAnnualizedReturn.Equals(input.NetAnnualizedReturn))
                ) && 
                (
                    this.Adjustments == input.Adjustments ||
                    (this.Adjustments != null &&
                    this.Adjustments.Equals(input.Adjustments))
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
                if (this.AvailableCash != null)
                    hashCode = hashCode * 59 + this.AvailableCash.GetHashCode();
                if (this.InvestorId != null)
                    hashCode = hashCode * 59 + this.InvestorId.GetHashCode();
                if (this.AccruedInterest != null)
                    hashCode = hashCode * 59 + this.AccruedInterest.GetHashCode();
                if (this.OutstandingPrincipal != null)
                    hashCode = hashCode * 59 + this.OutstandingPrincipal.GetHashCode();
                if (this.AccountTotal != null)
                    hashCode = hashCode * 59 + this.AccountTotal.GetHashCode();
                if (this.TotalNotes != null)
                    hashCode = hashCode * 59 + this.TotalNotes.GetHashCode();
                if (this.TotalPortfolios != null)
                    hashCode = hashCode * 59 + this.TotalPortfolios.GetHashCode();
                if (this.InFundingBalance != null)
                    hashCode = hashCode * 59 + this.InFundingBalance.GetHashCode();
                if (this.ReceivedInterest != null)
                    hashCode = hashCode * 59 + this.ReceivedInterest.GetHashCode();
                if (this.ReceivedPrincipal != null)
                    hashCode = hashCode * 59 + this.ReceivedPrincipal.GetHashCode();
                if (this.ReceivedLateFees != null)
                    hashCode = hashCode * 59 + this.ReceivedLateFees.GetHashCode();
                if (this.NetAnnualizedReturn != null)
                    hashCode = hashCode * 59 + this.NetAnnualizedReturn.GetHashCode();
                if (this.Adjustments != null)
                    hashCode = hashCode * 59 + this.Adjustments.GetHashCode();
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