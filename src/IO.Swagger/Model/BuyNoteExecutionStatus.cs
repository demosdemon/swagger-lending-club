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
    /// Defines BuyNoteExecutionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuyNoteExecutionStatus
    {
        
        /// <summary>
        /// Enum SUCCESSPENDINGSETTLEMENT for "SUCCESS_PENDING_SETTLEMENT"
        /// </summary>
        [EnumMember(Value = "SUCCESS_PENDING_SETTLEMENT")]
        SUCCESSPENDINGSETTLEMENT = 1,
        
        /// <summary>
        /// Enum NOTEALREADYOWNED for "NOTE_ALREADY_OWNED"
        /// </summary>
        [EnumMember(Value = "NOTE_ALREADY_OWNED")]
        NOTEALREADYOWNED = 2,
        
        /// <summary>
        /// Enum NOTEDATASTALE for "NOTE_DATA_STALE"
        /// </summary>
        [EnumMember(Value = "NOTE_DATA_STALE")]
        NOTEDATASTALE = 3,
        
        /// <summary>
        /// Enum NOTENOTAVAILABLE for "NOTE_NOT_AVAILABLE"
        /// </summary>
        [EnumMember(Value = "NOTE_NOT_AVAILABLE")]
        NOTENOTAVAILABLE = 4,
        
        /// <summary>
        /// Enum NOTEDOESNOTEXIST for "NOTE_DOES_NOT_EXIST"
        /// </summary>
        [EnumMember(Value = "NOTE_DOES_NOT_EXIST")]
        NOTEDOESNOTEXIST = 5,
        
        /// <summary>
        /// Enum INSUFFICIENTCASH for "INSUFFICIENT_CASH"
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_CASH")]
        INSUFFICIENTCASH = 6,
        
        /// <summary>
        /// Enum UNKNOWNERROR for "UNKNOWN_ERROR"
        /// </summary>
        [EnumMember(Value = "UNKNOWN_ERROR")]
        UNKNOWNERROR = 7
    }

}