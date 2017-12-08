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
    /// Defines ApplicationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplicationType
    {
        
        /// <summary>
        /// Enum INDIVIDUAL for "INDIVIDUAL"
        /// </summary>
        [EnumMember(Value = "INDIVIDUAL")]
        INDIVIDUAL = 1,
        
        /// <summary>
        /// Enum JOINT for "JOINT"
        /// </summary>
        [EnumMember(Value = "JOINT")]
        JOINT = 2,
        
        /// <summary>
        /// Enum DIRECTPAY for "DIRECT_PAY"
        /// </summary>
        [EnumMember(Value = "DIRECT_PAY")]
        DIRECTPAY = 3
    }

}