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
    /// DetailedNote
    /// </summary>
    [DataContract]
    public partial class DetailedNote :  IEquatable<DetailedNote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedNote" /> class.
        /// </summary>
        /// <param name="LoanId">LoanId.</param>
        /// <param name="NoteId">NoteId.</param>
        /// <param name="OrderId">OrderId.</param>
        /// <param name="InterestRate">InterestRate.</param>
        /// <param name="LoanLength">LoanLength.</param>
        /// <param name="LoanStatus">LoanStatus.</param>
        /// <param name="Grade">Grade.</param>
        /// <param name="LoanAmount">LoanAmount.</param>
        /// <param name="NoteAmount">NoteAmount.</param>
        /// <param name="PaymentsReceived">PaymentsReceived.</param>
        /// <param name="IssueDate">IssueDate.</param>
        /// <param name="OrderDate">OrderDate.</param>
        /// <param name="LoanStatusDate">LoanStatusDate.</param>
        /// <param name="Purpose">Purpose.</param>
        /// <param name="CurrentPaymentStatus">CurrentPaymentStatus.</param>
        /// <param name="CanBeTraded">CanBeTraded.</param>
        /// <param name="CreditTrend">CreditTrend.</param>
        /// <param name="AccruedInterest">AccruedInterest.</param>
        /// <param name="PrincipalPending">PrincipalPending.</param>
        /// <param name="InterestPending">InterestPending.</param>
        /// <param name="PrincipalReceived">PrincipalReceived.</param>
        /// <param name="InterestReceived">InterestReceived.</param>
        /// <param name="ApplicationType">ApplicationType.</param>
        /// <param name="DisbursementMethod">DisbursementMethod.</param>
        public DetailedNote(long? LoanId = default(long?), long? NoteId = default(long?), long? OrderId = default(long?), int? InterestRate = default(int?), int? LoanLength = default(int?), LoanStatus LoanStatus = default(LoanStatus), LoanGrade Grade = default(LoanGrade), decimal? LoanAmount = default(decimal?), decimal? NoteAmount = default(decimal?), decimal? PaymentsReceived = default(decimal?), DateTime? IssueDate = default(DateTime?), DateTime? OrderDate = default(DateTime?), DateTime? LoanStatusDate = default(DateTime?), string Purpose = default(string), PaymentStatus CurrentPaymentStatus = default(PaymentStatus), bool? CanBeTraded = default(bool?), CreditTrend CreditTrend = default(CreditTrend), decimal? AccruedInterest = default(decimal?), decimal? PrincipalPending = default(decimal?), decimal? InterestPending = default(decimal?), decimal? PrincipalReceived = default(decimal?), decimal? InterestReceived = default(decimal?), ApplicationType ApplicationType = default(ApplicationType), DisbursementMethod DisbursementMethod = default(DisbursementMethod))
        {
            this.LoanId = LoanId;
            this.NoteId = NoteId;
            this.OrderId = OrderId;
            this.InterestRate = InterestRate;
            this.LoanLength = LoanLength;
            this.LoanStatus = LoanStatus;
            this.Grade = Grade;
            this.LoanAmount = LoanAmount;
            this.NoteAmount = NoteAmount;
            this.PaymentsReceived = PaymentsReceived;
            this.IssueDate = IssueDate;
            this.OrderDate = OrderDate;
            this.LoanStatusDate = LoanStatusDate;
            this.Purpose = Purpose;
            this.CurrentPaymentStatus = CurrentPaymentStatus;
            this.CanBeTraded = CanBeTraded;
            this.CreditTrend = CreditTrend;
            this.AccruedInterest = AccruedInterest;
            this.PrincipalPending = PrincipalPending;
            this.InterestPending = InterestPending;
            this.PrincipalReceived = PrincipalReceived;
            this.InterestReceived = InterestReceived;
            this.ApplicationType = ApplicationType;
            this.DisbursementMethod = DisbursementMethod;
        }
        
        /// <summary>
        /// Gets or Sets LoanId
        /// </summary>
        [DataMember(Name="loanId", EmitDefaultValue=false)]
        public long? LoanId { get; set; }

        /// <summary>
        /// Gets or Sets NoteId
        /// </summary>
        [DataMember(Name="noteId", EmitDefaultValue=false)]
        public long? NoteId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets InterestRate
        /// </summary>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public int? InterestRate { get; set; }

        /// <summary>
        /// Gets or Sets LoanLength
        /// </summary>
        [DataMember(Name="loanLength", EmitDefaultValue=false)]
        public int? LoanLength { get; set; }

        /// <summary>
        /// Gets or Sets LoanStatus
        /// </summary>
        [DataMember(Name="loanStatus", EmitDefaultValue=false)]
        public LoanStatus LoanStatus { get; set; }

        /// <summary>
        /// Gets or Sets Grade
        /// </summary>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public LoanGrade Grade { get; set; }

        /// <summary>
        /// Gets or Sets LoanAmount
        /// </summary>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public decimal? LoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets NoteAmount
        /// </summary>
        [DataMember(Name="noteAmount", EmitDefaultValue=false)]
        public decimal? NoteAmount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentsReceived
        /// </summary>
        [DataMember(Name="paymentsReceived", EmitDefaultValue=false)]
        public decimal? PaymentsReceived { get; set; }

        /// <summary>
        /// Gets or Sets IssueDate
        /// </summary>
        [DataMember(Name="issueDate", EmitDefaultValue=false)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets LoanStatusDate
        /// </summary>
        [DataMember(Name="loanStatusDate", EmitDefaultValue=false)]
        public DateTime? LoanStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPaymentStatus
        /// </summary>
        [DataMember(Name="currentPaymentStatus", EmitDefaultValue=false)]
        public PaymentStatus CurrentPaymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets CanBeTraded
        /// </summary>
        [DataMember(Name="canBeTraded", EmitDefaultValue=false)]
        public bool? CanBeTraded { get; set; }

        /// <summary>
        /// Gets or Sets CreditTrend
        /// </summary>
        [DataMember(Name="creditTrend", EmitDefaultValue=false)]
        public CreditTrend CreditTrend { get; set; }

        /// <summary>
        /// Gets or Sets AccruedInterest
        /// </summary>
        [DataMember(Name="accruedInterest", EmitDefaultValue=false)]
        public decimal? AccruedInterest { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalPending
        /// </summary>
        [DataMember(Name="principalPending", EmitDefaultValue=false)]
        public decimal? PrincipalPending { get; set; }

        /// <summary>
        /// Gets or Sets InterestPending
        /// </summary>
        [DataMember(Name="interestPending", EmitDefaultValue=false)]
        public decimal? InterestPending { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalReceived
        /// </summary>
        [DataMember(Name="principalReceived", EmitDefaultValue=false)]
        public decimal? PrincipalReceived { get; set; }

        /// <summary>
        /// Gets or Sets InterestReceived
        /// </summary>
        [DataMember(Name="interestReceived", EmitDefaultValue=false)]
        public decimal? InterestReceived { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationType
        /// </summary>
        [DataMember(Name="applicationType", EmitDefaultValue=false)]
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Gets or Sets DisbursementMethod
        /// </summary>
        [DataMember(Name="disbursementMethod", EmitDefaultValue=false)]
        public DisbursementMethod DisbursementMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedNote {\n");
            sb.Append("  LoanId: ").Append(LoanId).Append("\n");
            sb.Append("  NoteId: ").Append(NoteId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  LoanLength: ").Append(LoanLength).Append("\n");
            sb.Append("  LoanStatus: ").Append(LoanStatus).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  NoteAmount: ").Append(NoteAmount).Append("\n");
            sb.Append("  PaymentsReceived: ").Append(PaymentsReceived).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  LoanStatusDate: ").Append(LoanStatusDate).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  CurrentPaymentStatus: ").Append(CurrentPaymentStatus).Append("\n");
            sb.Append("  CanBeTraded: ").Append(CanBeTraded).Append("\n");
            sb.Append("  CreditTrend: ").Append(CreditTrend).Append("\n");
            sb.Append("  AccruedInterest: ").Append(AccruedInterest).Append("\n");
            sb.Append("  PrincipalPending: ").Append(PrincipalPending).Append("\n");
            sb.Append("  InterestPending: ").Append(InterestPending).Append("\n");
            sb.Append("  PrincipalReceived: ").Append(PrincipalReceived).Append("\n");
            sb.Append("  InterestReceived: ").Append(InterestReceived).Append("\n");
            sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
            sb.Append("  DisbursementMethod: ").Append(DisbursementMethod).Append("\n");
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
            return this.Equals(input as DetailedNote);
        }

        /// <summary>
        /// Returns true if DetailedNote instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanId == input.LoanId ||
                    (this.LoanId != null &&
                    this.LoanId.Equals(input.LoanId))
                ) && 
                (
                    this.NoteId == input.NoteId ||
                    (this.NoteId != null &&
                    this.NoteId.Equals(input.NoteId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.LoanLength == input.LoanLength ||
                    (this.LoanLength != null &&
                    this.LoanLength.Equals(input.LoanLength))
                ) && 
                (
                    this.LoanStatus == input.LoanStatus ||
                    (this.LoanStatus != null &&
                    this.LoanStatus.Equals(input.LoanStatus))
                ) && 
                (
                    this.Grade == input.Grade ||
                    (this.Grade != null &&
                    this.Grade.Equals(input.Grade))
                ) && 
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) && 
                (
                    this.NoteAmount == input.NoteAmount ||
                    (this.NoteAmount != null &&
                    this.NoteAmount.Equals(input.NoteAmount))
                ) && 
                (
                    this.PaymentsReceived == input.PaymentsReceived ||
                    (this.PaymentsReceived != null &&
                    this.PaymentsReceived.Equals(input.PaymentsReceived))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.LoanStatusDate == input.LoanStatusDate ||
                    (this.LoanStatusDate != null &&
                    this.LoanStatusDate.Equals(input.LoanStatusDate))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.CurrentPaymentStatus == input.CurrentPaymentStatus ||
                    (this.CurrentPaymentStatus != null &&
                    this.CurrentPaymentStatus.Equals(input.CurrentPaymentStatus))
                ) && 
                (
                    this.CanBeTraded == input.CanBeTraded ||
                    (this.CanBeTraded != null &&
                    this.CanBeTraded.Equals(input.CanBeTraded))
                ) && 
                (
                    this.CreditTrend == input.CreditTrend ||
                    (this.CreditTrend != null &&
                    this.CreditTrend.Equals(input.CreditTrend))
                ) && 
                (
                    this.AccruedInterest == input.AccruedInterest ||
                    (this.AccruedInterest != null &&
                    this.AccruedInterest.Equals(input.AccruedInterest))
                ) && 
                (
                    this.PrincipalPending == input.PrincipalPending ||
                    (this.PrincipalPending != null &&
                    this.PrincipalPending.Equals(input.PrincipalPending))
                ) && 
                (
                    this.InterestPending == input.InterestPending ||
                    (this.InterestPending != null &&
                    this.InterestPending.Equals(input.InterestPending))
                ) && 
                (
                    this.PrincipalReceived == input.PrincipalReceived ||
                    (this.PrincipalReceived != null &&
                    this.PrincipalReceived.Equals(input.PrincipalReceived))
                ) && 
                (
                    this.InterestReceived == input.InterestReceived ||
                    (this.InterestReceived != null &&
                    this.InterestReceived.Equals(input.InterestReceived))
                ) && 
                (
                    this.ApplicationType == input.ApplicationType ||
                    (this.ApplicationType != null &&
                    this.ApplicationType.Equals(input.ApplicationType))
                ) && 
                (
                    this.DisbursementMethod == input.DisbursementMethod ||
                    (this.DisbursementMethod != null &&
                    this.DisbursementMethod.Equals(input.DisbursementMethod))
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
                if (this.LoanId != null)
                    hashCode = hashCode * 59 + this.LoanId.GetHashCode();
                if (this.NoteId != null)
                    hashCode = hashCode * 59 + this.NoteId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.LoanLength != null)
                    hashCode = hashCode * 59 + this.LoanLength.GetHashCode();
                if (this.LoanStatus != null)
                    hashCode = hashCode * 59 + this.LoanStatus.GetHashCode();
                if (this.Grade != null)
                    hashCode = hashCode * 59 + this.Grade.GetHashCode();
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.NoteAmount != null)
                    hashCode = hashCode * 59 + this.NoteAmount.GetHashCode();
                if (this.PaymentsReceived != null)
                    hashCode = hashCode * 59 + this.PaymentsReceived.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.LoanStatusDate != null)
                    hashCode = hashCode * 59 + this.LoanStatusDate.GetHashCode();
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                if (this.CurrentPaymentStatus != null)
                    hashCode = hashCode * 59 + this.CurrentPaymentStatus.GetHashCode();
                if (this.CanBeTraded != null)
                    hashCode = hashCode * 59 + this.CanBeTraded.GetHashCode();
                if (this.CreditTrend != null)
                    hashCode = hashCode * 59 + this.CreditTrend.GetHashCode();
                if (this.AccruedInterest != null)
                    hashCode = hashCode * 59 + this.AccruedInterest.GetHashCode();
                if (this.PrincipalPending != null)
                    hashCode = hashCode * 59 + this.PrincipalPending.GetHashCode();
                if (this.InterestPending != null)
                    hashCode = hashCode * 59 + this.InterestPending.GetHashCode();
                if (this.PrincipalReceived != null)
                    hashCode = hashCode * 59 + this.PrincipalReceived.GetHashCode();
                if (this.InterestReceived != null)
                    hashCode = hashCode * 59 + this.InterestReceived.GetHashCode();
                if (this.ApplicationType != null)
                    hashCode = hashCode * 59 + this.ApplicationType.GetHashCode();
                if (this.DisbursementMethod != null)
                    hashCode = hashCode * 59 + this.DisbursementMethod.GetHashCode();
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
            // LoanLength (int?) maximum
            if(this.LoanLength > (int?)60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoanLength, must be a value less than or equal to 60.", new [] { "LoanLength" });
            }

            // LoanLength (int?) minimum
            if(this.LoanLength < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoanLength, must be a value greater than or equal to 0.", new [] { "LoanLength" });
            }

            yield break;
        }
    }

}
