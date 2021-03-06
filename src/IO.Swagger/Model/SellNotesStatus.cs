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
    /// Defines SellNotesStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SellNotesStatus
    {
        
        /// <summary>
        /// Enum SUCCESS for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        
        /// <summary>
        /// Enum ERROR for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR = 2,
        
        /// <summary>
        /// Enum NOLOANSTOSELL for "NO_LOANS_TO_SELL"
        /// </summary>
        [EnumMember(Value = "NO_LOANS_TO_SELL")]
        NOLOANSTOSELL = 3,
        
        /// <summary>
        /// Enum INVALIDORDEREXPIRATIONDATE for "INVALID_ORDER_EXPIRATION_DATE"
        /// </summary>
        [EnumMember(Value = "INVALID_ORDER_EXPIRATION_DATE")]
        INVALIDORDEREXPIRATIONDATE = 4,
        
        /// <summary>
        /// Enum ORDEREXPIREDATETOOSHORT for "ORDER_EXPIRE_DATE_TOO_SHORT"
        /// </summary>
        [EnumMember(Value = "ORDER_EXPIRE_DATE_TOO_SHORT")]
        ORDEREXPIREDATETOOSHORT = 5,
        
        /// <summary>
        /// Enum ORDEREXPIREDATETOOLONG for "ORDER_EXPIRE_DATE_TOO_LONG"
        /// </summary>
        [EnumMember(Value = "ORDER_EXPIRE_DATE_TOO_LONG")]
        ORDEREXPIREDATETOOLONG = 6,
        
        /// <summary>
        /// Enum UNEXPECTEDERROR for "UNEXPECTED_ERROR"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_ERROR")]
        UNEXPECTEDERROR = 7
    }

}
